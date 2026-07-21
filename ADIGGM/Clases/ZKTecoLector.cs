using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ADIGGM.CapaModelo;

namespace ADIGGM.Clases
{
    /// <summary>
    /// Lector del reloj biométrico ZKTeco (MB360 Plus y familia) vía el Standalone SDK GRATUITO
    /// (zkemkeeper.dll, COM, TCP/IP puerto 4370 — PULL: la app se conecta y descarga el log).
    ///
    /// Se usa LATE BINDING (dynamic sobre el ProgID) A PROPÓSITO: el proyecto NO referencia el COM,
    /// así la solución compila y la app corre en PCs SIN el SDK instalado (el ClickOnce no se ve
    /// afectado). Solo la PC que descarga marcas necesita el SDK registrado: bajar de
    /// github.com/ZKTeco/Standalone-SDK y ejecutar Register_SDK.bat como administrador.
    /// </summary>
    public static class ZKTecoLector
    {
        /// <summary>
        /// Descarga TODO el log de asistencia del reloj (el equipo guarda hasta 100,000 eventos y NO
        /// se borra — decisión v1; la deduplicación la hace RepositorioBiometrico.InsertarMarcas).
        /// Lanza InvalidOperationException con mensaje claro si el SDK no está instalado o el reloj
        /// no responde.
        /// </summary>
        public static List<MarcaBiometrico> DescargarMarcas(string ip, int puerto)
        {
            Type tipo = Type.GetTypeFromProgID("zkemkeeper.ZKEM");
            if (tipo == null)
                throw new InvalidOperationException(
                    "El SDK de ZKTeco no está instalado en esta PC.\n\nDescargue el Standalone SDK " +
                    "(github.com/ZKTeco/Standalone-SDK) y ejecute Register_SDK.bat como administrador.");

            dynamic zk = Activator.CreateInstance(tipo);
            try
            {
                if (!zk.Connect_Net(ip, puerto))
                    throw new InvalidOperationException(
                        "No se pudo conectar al reloj en " + ip + ":" + puerto +
                        ".\n\nVerifique que el equipo esté encendido, conectado a la red y con esa IP " +
                        "(Menú > Comunicación en el reloj).\n\nSi la red está bien y aun así no conecta, " +
                        "REINICIE EL RELOJ: estos equipos solo aceptan una conexión a la vez y una sesión " +
                        "colgada de un intento anterior bloquea las nuevas (comprobado 2026-07-20).");

                var marcas = new List<MarcaBiometrico>();
                const int maquina = 1;
                zk.EnableDevice(maquina, false);   // pausa el teclado del equipo durante la lectura (recomendación del SDK)
                try
                {
                    if (zk.ReadGeneralLogData(maquina))
                    {
                        string enroll = "";
                        int verifyMode = 0, inOutMode = 0, anio = 0, mes = 0, dia = 0, hora = 0, minuto = 0, segundo = 0, workcode = 0;
                        while (zk.SSR_GetGeneralLogData(maquina, ref enroll, ref verifyMode, ref inOutMode,
                                   ref anio, ref mes, ref dia, ref hora, ref minuto, ref segundo, ref workcode))
                        {
                            int idBiometrico;
                            if (!int.TryParse(enroll, out idBiometrico)) continue; // enrolamientos no numéricos: se ignoran
                            marcas.Add(new MarcaBiometrico
                            {
                                IdBiometrico = idBiometrico,
                                FechaHora = new DateTime(anio, mes, dia, hora, minuto, segundo),
                                ModoVerificacion = verifyMode
                            });
                        }
                    }
                }
                finally
                {
                    zk.EnableDevice(maquina, true);
                }
                return marcas;
            }
            finally
            {
                try { zk.Disconnect(); } catch { /* el equipo pudo no estar conectado */ }
                Marshal.FinalReleaseComObject((object)zk);
            }
        }
    }
}
