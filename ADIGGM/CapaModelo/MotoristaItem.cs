namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Ítem de listado de motoristas (para combos y grids del módulo HE).
    /// La propiedad se llama 'Motorista' para coincidir con los DisplayMember /
    /// DataPropertyName ("Motorista") ya usados en los formularios.
    /// </summary>
    public class MotoristaItem
    {
        public int IdMotorista { get; set; }
        public string Motorista { get; set; }
    }
}
