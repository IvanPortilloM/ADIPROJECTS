using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;

namespace WSBiometrico
{
    /// <summary>
    /// Mini-servidor HTTP del protocolo PUSH/ADMS (iclock) de ZKTeco. El reloj (MB360 Plus,
    /// firmware ZMM501 — generación que NO expone sus datos por el SDK PULL clásico) se configura
    /// con "Dirección del Servidor" = IP de esta máquina y EMPUJA él solo sus marcas:
    ///
    ///   GET  /iclock/cdata?SN=...&options=all   -> handshake inicial: se le responde la "tabla de
    ///                                              opciones" (Realtime=1, stamps, etc.)
    ///   POST /iclock/cdata?SN=...&table=ATTLOG  -> las MARCAS: una por línea, campos separados por
    ///                                              TAB: usuario, fecha-hora, estado, verificación...
    ///   GET  /iclock/getrequest?SN=...          -> polling de comandos pendientes -> "OK"
    ///
    /// Las marcas se insertan vía RepositorioBiometrico.InsertarMarcas (transaccional, deduplicado
    /// por IdBiometrico+FechaHora): el reloj puede reenviar todo su log sin duplicar nada.
    /// Se usa TcpListener y no HttpListener a propósito: no requiere reserva de URL (urlacl) y es
    /// el mismo mecanismo ya probado contra el equipo durante el diagnóstico (2026-07-20).
    /// </summary>
    public class ServidorAdms
    {
        private readonly int _puerto;
        private readonly Action<string> _log;
        private readonly RepositorioBiometrico _repo = new RepositorioBiometrico();
        private TcpListener _listener;
        private Thread _hiloAceptador;
        private volatile bool _corriendo;

        public ServidorAdms(int puerto, Action<string> log)
        {
            _puerto = puerto;
            _log = log ?? delegate { };
        }

        public void Iniciar()
        {
            _listener = new TcpListener(IPAddress.Any, _puerto);
            _listener.Start();
            _corriendo = true;
            _hiloAceptador = new Thread(BucleAceptador) { IsBackground = true, Name = "AdmsAceptador" };
            _hiloAceptador.Start();
            _log("Servidor ADMS escuchando en 0.0.0.0:" + _puerto);
        }

        public void Detener()
        {
            _corriendo = false;
            try { _listener.Stop(); } catch { }
            if (_hiloAceptador != null && !_hiloAceptador.Join(3000))
            {
                // El hilo es background: si no salió en 3s, morirá con el proceso.
            }
            _log("Servidor ADMS detenido");
        }

        private void BucleAceptador()
        {
            while (_corriendo)
            {
                TcpClient cliente;
                try { cliente = _listener.AcceptTcpClient(); }
                catch { break; } // Stop() interrumpe el Accept
                ThreadPool.QueueUserWorkItem(delegate { AtenderCliente(cliente); });
            }
        }

        private void AtenderCliente(TcpClient cliente)
        {
            string remoto = "?";
            try
            {
                remoto = cliente.Client.RemoteEndPoint.ToString();
                using (cliente)
                using (NetworkStream ns = cliente.GetStream())
                {
                    ns.ReadTimeout = 15000;
                    ns.WriteTimeout = 15000;

                    string lineaPeticion, cuerpo;
                    Dictionary<string, string> cabeceras;
                    if (!LeerPeticion(ns, out lineaPeticion, out cabeceras, out cuerpo)) return;

                    string[] partes = lineaPeticion.Split(' ');
                    if (partes.Length < 2) return;
                    string metodo = partes[0].ToUpperInvariant();
                    string rutaYQuery = partes[1];
                    string ruta = rutaYQuery.Split('?')[0].ToLowerInvariant();
                    Dictionary<string, string> query = ParsearQuery(rutaYQuery);
                    string sn = query.ContainsKey("SN") ? query["SN"] : "";

                    string respuesta;
                    if (metodo == "GET" && ruta == "/iclock/cdata")
                    {
                        respuesta = RespuestaHandshake(sn, query.ContainsKey("pushver"));
                        _log("Handshake de SN=" + sn + " desde " + remoto +
                             (query.ContainsKey("pushver") ? " (pushver=" + query["pushver"] + ")" : " (dialecto clásico)"));
                    }
                    else if (metodo == "POST" && ruta == "/iclock/cdata")
                    {
                        string tabla = query.ContainsKey("table") ? query["table"].ToUpperInvariant() : "";
                        if (tabla == "ATTLOG")
                        {
                            respuesta = ProcesarAttlog(sn, cuerpo);
                        }
                        else
                        {
                            int lineas = ContarLineas(cuerpo);
                            _log("POST tabla=" + tabla + " SN=" + sn + " (" + lineas + " línea(s), solo reconocida)");
                            respuesta = "OK: " + lineas;
                        }
                    }
                    else if (ruta == "/iclock/getrequest" || ruta == "/iclock/devicecmd" || ruta == "/iclock/ping")
                    {
                        respuesta = "OK"; // sin comandos pendientes para el equipo
                    }
                    else
                    {
                        _log("Petición no reconocida: " + metodo + " " + rutaYQuery + " desde " + remoto);
                        respuesta = "OK";
                    }

                    EscribirRespuesta(ns, respuesta);
                }
            }
            catch (Exception ex)
            {
                _log("ERROR atendiendo a " + remoto + ": " + ex.Message);
            }
        }

        // ----- Protocolo -----

        /// <summary>Tabla de opciones del handshake. Realtime=1 = empujar cada marca al instante;
        /// stamp "desde cero" = el equipo sube TODO su log (la deduplicación lo hace inocuo).
        /// El dialecto nuevo (query con pushver) usa claves ATTLOGStamp/TransData.</summary>
        private static string RespuestaHandshake(string sn, bool dialectoNuevo)
        {
            if (dialectoNuevo)
            {
                return "GET OPTION FROM: " + sn + "\r\n" +
                       "ATTLOGStamp=None\r\n" +
                       "OPERLOGStamp=None\r\n" +
                       "ATTPHOTOStamp=None\r\n" +
                       "ErrorDelay=30\r\n" +
                       "Delay=10\r\n" +
                       "TransTimes=00:00;14:05\r\n" +
                       "TransInterval=1\r\n" +
                       "TransFlag=TransData AttLog\tOpLog\r\n" +
                       "TimeZone=-6\r\n" +
                       "Realtime=1\r\n" +
                       "Encrypt=None\r\n";
            }
            return "GET OPTION FROM: " + sn + "\r\n" +
                   "Stamp=9999\r\n" +
                   "OpStamp=9999\r\n" +
                   "ErrorDelay=30\r\n" +
                   "Delay=10\r\n" +
                   "TransTimes=00:00;14:05\r\n" +
                   "TransInterval=1\r\n" +
                   "TransFlag=1111000000\r\n" +
                   "Realtime=1\r\n" +
                   "Encrypt=0\r\n" +
                   "TimeZone=-6\r\n";
        }

        /// <summary>Parsea el cuerpo de un POST table=ATTLOG (una marca por línea, campos por TAB:
        /// [0]=usuario, [1]=fecha "yyyy-MM-dd HH:mm:ss", [2]=estado in/out, [3]=verificación) y las
        /// inserta deduplicadas. Devuelve "OK: n" — el ACK que el reloj espera para avanzar su puntero.</summary>
        private string ProcesarAttlog(string sn, string cuerpo)
        {
            var marcas = new List<MarcaBiometrico>();
            int lineasMalas = 0;
            foreach (string cruda in cuerpo.Split('\n'))
            {
                string linea = cruda.TrimEnd('\r').Trim();
                if (linea.Length == 0) continue;
                string[] campos = linea.Split('\t');

                int idBiometrico;
                DateTime fechaHora;
                if (campos.Length < 2 ||
                    !int.TryParse(campos[0].Trim(), out idBiometrico) ||
                    !DateTime.TryParseExact(campos[1].Trim(), "yyyy-MM-dd HH:mm:ss",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaHora))
                {
                    lineasMalas++;
                    _log("  línea ATTLOG no reconocida: [" + linea + "]");
                    continue;
                }
                int verificacion = 0;
                if (campos.Length > 3) int.TryParse(campos[3].Trim(), out verificacion);

                marcas.Add(new MarcaBiometrico
                {
                    IdBiometrico = idBiometrico,
                    FechaHora = fechaHora,
                    ModoVerificacion = verificacion
                });
            }

            int nuevas = 0, existentes = 0;
            if (marcas.Count > 0)
            {
                var resultado = _repo.InsertarMarcas(marcas, DateTime.Now);
                nuevas = resultado.Nuevas;
                existentes = resultado.Existentes;
            }
            _log("ATTLOG SN=" + sn + ": " + marcas.Count + " marca(s) recibidas -> " + nuevas +
                 " nuevas, " + existentes + " ya existían" +
                 (lineasMalas > 0 ? ", " + lineasMalas + " línea(s) no reconocidas" : ""));

            // El ACK cuenta TODAS las líneas recibidas (también las duplicadas): así el reloj avanza
            // su puntero y no las reenvía en bucle.
            return "OK: " + (marcas.Count + lineasMalas);
        }

        // ----- HTTP crudo -----

        private static bool LeerPeticion(NetworkStream ns, out string lineaPeticion,
            out Dictionary<string, string> cabeceras, out string cuerpo)
        {
            lineaPeticion = null;
            cabeceras = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            cuerpo = "";

            var buffer = new MemoryStream();
            var bloque = new byte[8192];
            int finCabeceras = -1;

            // Leer hasta el fin de cabeceras (\r\n\r\n)
            while (finCabeceras < 0)
            {
                int n;
                try { n = ns.Read(bloque, 0, bloque.Length); } catch { return false; }
                if (n <= 0) return false;
                buffer.Write(bloque, 0, n);
                finCabeceras = BuscarFinCabeceras(buffer.ToArray());
                if (buffer.Length > 1048576) return false; // cabeceras absurdas: abortar
            }

            byte[] datos = buffer.ToArray();
            string textoCabeceras = Encoding.UTF8.GetString(datos, 0, finCabeceras);
            string[] lineas = textoCabeceras.Split(new[] { "\r\n" }, StringSplitOptions.None);
            if (lineas.Length == 0) return false;
            lineaPeticion = lineas[0];
            for (int i = 1; i < lineas.Length; i++)
            {
                int p = lineas[i].IndexOf(':');
                if (p > 0) cabeceras[lineas[i].Substring(0, p).Trim()] = lineas[i].Substring(p + 1).Trim();
            }

            // Leer el cuerpo completo según Content-Length
            int contentLength = 0;
            if (cabeceras.ContainsKey("Content-Length")) int.TryParse(cabeceras["Content-Length"], out contentLength);
            int cuerpoYaLeido = datos.Length - (finCabeceras + 4);
            var cuerpoBytes = new MemoryStream();
            if (cuerpoYaLeido > 0) cuerpoBytes.Write(datos, finCabeceras + 4, cuerpoYaLeido);
            while (cuerpoBytes.Length < contentLength)
            {
                int n;
                try { n = ns.Read(bloque, 0, bloque.Length); } catch { break; }
                if (n <= 0) break;
                cuerpoBytes.Write(bloque, 0, n);
            }
            cuerpo = Encoding.UTF8.GetString(cuerpoBytes.ToArray());
            return true;
        }

        private static int BuscarFinCabeceras(byte[] datos)
        {
            for (int i = 0; i + 3 < datos.Length; i++)
                if (datos[i] == 13 && datos[i + 1] == 10 && datos[i + 2] == 13 && datos[i + 3] == 10)
                    return i;
            return -1;
        }

        private static void EscribirRespuesta(NetworkStream ns, string cuerpo)
        {
            byte[] cuerpoBytes = Encoding.UTF8.GetBytes(cuerpo);
            string cabecera = "HTTP/1.1 200 OK\r\n" +
                              "Server: ADIGGM-WSBiometrico\r\n" +
                              "Content-Type: text/plain\r\n" +
                              "Content-Length: " + cuerpoBytes.Length + "\r\n" +
                              "Connection: close\r\n\r\n";
            byte[] cabeceraBytes = Encoding.ASCII.GetBytes(cabecera);
            ns.Write(cabeceraBytes, 0, cabeceraBytes.Length);
            ns.Write(cuerpoBytes, 0, cuerpoBytes.Length);
            ns.Flush();
        }

        private static Dictionary<string, string> ParsearQuery(string rutaYQuery)
        {
            var d = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            int q = rutaYQuery.IndexOf('?');
            if (q < 0) return d;
            foreach (string par in rutaYQuery.Substring(q + 1).Split('&'))
            {
                int e = par.IndexOf('=');
                if (e > 0) d[Uri.UnescapeDataString(par.Substring(0, e))] = Uri.UnescapeDataString(par.Substring(e + 1));
            }
            return d;
        }

        private static int ContarLineas(string cuerpo)
        {
            int n = 0;
            foreach (string l in cuerpo.Split('\n')) if (l.Trim().Length > 0) n++;
            return n;
        }
    }
}
