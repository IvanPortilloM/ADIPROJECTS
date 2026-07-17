using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Una marca (checada) descargada del reloj biométrico ZKTeco. IdBiometrico es el número de
    /// usuario enrolado en el equipo (= PK de BIO_Empleados; los empleados se enrolan con ese número).
    /// </summary>
    public class MarcaBiometrico
    {
        public int IdBiometrico { get; set; }
        public DateTime FechaHora { get; set; }
        /// <summary>Modo de verificación reportado por el equipo (1=huella, 15=rostro, 2=tarjeta, 0=contraseña).</summary>
        public int ModoVerificacion { get; set; }
    }
}
