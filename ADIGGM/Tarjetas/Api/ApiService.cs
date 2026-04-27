using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Requiere el paquete NuGet que instalaste

namespace ADIGGM.Tarjetas.Api // Asegúrate de que este sea el nombre real de tu proyecto
{

    // Esta clase sirve como "molde" para entender la respuesta que manda PHP
    public class RespuestaApi
    {
        public bool error { get; set; }
        public string mensaje { get; set; }
        public dynamic datos { get; set; }

        // --- Propiedades extra que devuelve PHP en la raíz del JSON ---
        public decimal? nuevo_saldo { get; set; } // Para cobros de tarjeta
        public int? puntos_sumados { get; set; }  // Para acumulación de membresía
        public int? nuevo_saldo_puntos { get; set; } // Para membresías
        public int? puntos_descontados { get; set; } // Para canjes
    }
    public class ApiService
    {
        private readonly HttpClient _client;

        // Reemplaza esto con la URL real donde subiste tu carpeta "api"
        private readonly string _baseUrl = "https://adiggm.hn/api/v1/";

        public ApiService()
        {
            // Fuerza a la aplicación a usar seguridad TLS 1.2 para que el servidor en la nube no rechace la conexión
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            _client = new HttpClient();

            // --- NUEVA LÍNEA DE SEGURIDAD ---
            // Agregamos la llave maestra que definimos en PHP. 
            // _client se encargará de enviarla en absolutamente todas las peticiones automáticamente.
            _client.DefaultRequestHeaders.Add("X-API-KEY", "Adiggm_Super_Secreta_2026_**");
        }

        // Método para consultar el saldo de una tarjeta de regalo
        public async Task<RespuestaApi> ConsultarTarjetaAsync(string codigoQr)
        {
            try
            {
                string url = _baseUrl + "consultar_tarjeta.php";

                // Preparamos los datos en formato anónimo
                var datos = new { codigo_qr = codigoQr };

                // Convertimos los datos a texto JSON
                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Hacemos la petición POST a tu servidor en PHP
                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                // Leemos la respuesta del servidor
                string respuestaJson = await response.Content.ReadAsStringAsync();

                // Convertimos el JSON de texto a un objeto de C#
                return JsonConvert.DeserializeObject<RespuestaApi>(respuestaJson);
            }
            catch (Exception ex)
            {
                // Si se cae el internet o falla el servidor, lo atrapamos aquí
                return new RespuestaApi
                {
                    error = true,
                    mensaje = "Error de conexión: " + ex.Message
                };
            }
        }
        // Método para cobrar (descontar saldo) de la Tarjeta de Regalo
        public async Task<RespuestaApi> CobrarTarjetaAsync(string codigoQr, decimal monto, string ticketPos, string cajero)
        {
            try
            {
                string url = _baseUrl + "cobrar_tarjeta.php";

                // Empaquetamos exactamente los datos que PHP está esperando
                var datos = new
                {
                    codigo_qr = codigoQr,
                    monto_cobrar = monto,
                    referencia_ticket_pos = ticketPos,
                    usuario_cajero = cajero
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string respuestaJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RespuestaApi>(respuestaJson);
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de conexión: " + ex.Message };
            }
        }
        // --- MÉTODOS PARA MEMBRESÍAS ---

        public async Task<RespuestaApi> ConsultarMembresiaAsync(string codigoQr)
        {
            try
            {
                var datos = new { codigo_qr = codigoQr };
                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(_baseUrl + "consultar_membresia.php", content);
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<RespuestaApi>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error: " + ex.Message };
            }
        }

        public async Task<RespuestaApi> SumarPuntosAsync(string codigoQr, decimal montoFactura, string ticketPos, string cajero)
        {
            try
            {
                var datos = new
                {
                    codigo_qr = codigoQr,
                    monto_factura = montoFactura,
                    referencia_ticket_pos = ticketPos,
                    usuario_cajero = cajero
                };
                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(_baseUrl + "sumar_puntos.php", content);
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<RespuestaApi>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error: " + ex.Message };
            }
        }
        // Método para canjear puntos por premios
        public async Task<RespuestaApi> CanjearPuntosAsync(string codigoQr, int puntos, string referencia, string cajero)
        {
            try
            {
                // Empaquetamos exactamente los datos que el PHP de canje está esperando
                var datos = new
                {
                    codigo_qr = codigoQr,
                    puntos_a_canjear = puntos,
                    referencia_ticket_pos = referencia,
                    usuario_cajero = cajero
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(_baseUrl + "canjear_puntos.php", content);
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<RespuestaApi>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de conexión: " + ex.Message };
            }
        }
        // Método para registrar un nuevo cliente (Membresía)
        public async Task<RespuestaApi> RegistrarClienteAsync(string nombre, string telefono, string codigoQr)
        {
            try
            {
                string url = _baseUrl + "registrar_cliente.php";

                var datos = new
                {
                    nombre_completo = nombre,
                    telefono = telefono,
                    codigo_qr = codigoQr
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string respuestaJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RespuestaApi>(respuestaJson);
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de conexión: " + ex.Message };
            }
        }
        // Método para ACTIVAR una nueva Tarjeta de Regalo
        public async Task<RespuestaApi> ActivarTarjetaAsync(string codigoQr, decimal montoInicial, string ticketPos, string cajero)
        {
            try
            {
                string url = _baseUrl + "activar_tarjeta.php";

                var datos = new
                {
                    codigo_qr = codigoQr,
                    monto_inicial = montoInicial,
                    referencia_ticket_pos = ticketPos,
                    usuario_cajero = cajero
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string respuestaJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RespuestaApi>(respuestaJson);
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de conexión: " + ex.Message };
            }
        }
        // Método para Anular Transacciones (Devolver dinero o quitar puntos)
        public async Task<RespuestaApi> AnularTransaccionAsync(string codigoQr, decimal montoRevertir, string ticketOrigen, string supervisor)
        {
            try
            {
                string url = _baseUrl + "anular_transaccion.php";

                var datos = new
                {
                    codigo_qr = codigoQr,
                    monto_revertir = montoRevertir,
                    ticket_origen = ticketOrigen,
                    usuario_supervisor = supervisor
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string respuestaJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RespuestaApi>(respuestaJson);
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de conexión: " + ex.Message };
            }
        }
        public async Task<RespuestaApi> GestionarSeguridadAsync(string qrActual, string accion, string supervisor, string nuevoQr = "")
        {
            try
            {
                var datos = new
                {
                    codigo_qr_actual = qrActual,
                    accion = accion,
                    usuario_supervisor = supervisor,
                    nuevo_qr = nuevoQr
                };

                string json = JsonConvert.SerializeObject(datos);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(_baseUrl + "gestionar_estados.php", content);
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<RespuestaApi>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new RespuestaApi { error = true, mensaje = "Error de seguridad: " + ex.Message };
            }
        }
    }
}