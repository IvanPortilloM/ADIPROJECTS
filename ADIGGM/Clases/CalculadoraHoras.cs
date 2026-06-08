using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIGGM.Clases
{
    // --- CLASES DE SOPORTE ---

    /// <summary>
    /// Define las reglas de pago específicas para un empleado.
    /// </summary>
    public class PoliticaPago
    {
        public int PoliticaID { get; set; }
        public string NombrePolitica { get; set; }
        public bool PagaExtrasDiarias { get; set; } // Si es false, las extras 25/50/75 se pagan como horas normales.
        public bool PagaDomingos { get; set; }      // Si es true, el Domingo se paga al 100%. Si es false, se paga normal.
        public bool PagaFeriados { get; set; }      // Si es true, el Feriado se paga al 100%.
        public bool AplicaJornadaMixta { get; set; } // Si es true, se aplica la regla de jornada mixta (7 horas regulares).
    }

    /// <summary>
    /// Contiene el desglose calculado para un día específico.
    /// </summary>
    public class ResultadoDia
    {
        public DateTime Fecha { get; set; }
        public decimal TotalHoras { get; set; }

        // Horas Pagadas a precio Normal (Sencillo)
        public decimal RegularesDiurnas { get; set; }
        public decimal RegularesNocturnas { get; set; }

        // Horas Pagadas con Recargo
        public decimal Extras25 { get; set; }
        public decimal Extras50 { get; set; }
        public decimal Extras75 { get; set; }
        public decimal Extras100 { get; set; } // Domingos y Feriados

        public string TipoJornadaDetectada { get; set; }
    }

    /// <summary>
    /// Representa un bloque de tiempo trabajado (Entrada y Salida).
    /// </summary>
    public class RangoHora
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public double DuracionHoras => (Fin - Inicio).TotalHours;
    }

    // --- CLASE PRINCIPAL DE CÁLCULO ---

    public static class CalculadoraHoras
    {
        /// <summary>
        /// Calcula el desglose de horas para un día, aplicando la Ley de Honduras y la Política de la Empresa.
        /// </summary>
        public static ResultadoDia CalcularDia(DateTime fechaDia, List<RangoHora> rangos, bool esFeriado, PoliticaPago politica)
        {            
            ResultadoDia resultado = new ResultadoDia { Fecha = fechaDia.Date };

            if (rangos == null || rangos.Count == 0) return resultado;

            // ---------------------------------------------------------
            // PRIORIDAD 1: ¿ES DÍA DE PAGO DOBLE (100%)?
            // ---------------------------------------------------------
            bool esDomingoCalendario = fechaDia.DayOfWeek == DayOfWeek.Sunday;

            // Verificamos si la política permite el pago doble para este caso
            bool aplicaPagoDomingo = esDomingoCalendario && politica.PagaDomingos;
            bool aplicaPagoFeriado = esFeriado && politica.PagaFeriados;

            if (aplicaPagoFeriado || aplicaPagoDomingo)
            {
                resultado.TipoJornadaDetectada = esFeriado ? "Feriado (100%)" : "Domingo (100%)";
                resultado.TotalHoras = (decimal)rangos.Sum(r => r.DuracionHoras);

                // Todo se va a la bolsa del 100%
                resultado.Extras100 = resultado.TotalHoras;

                return resultado; // Terminamos, no hay más cálculos para este día.
            }

            // ---------------------------------------------------------
            // CÁLCULO DE JORNADA ESTÁNDAR (Si no fue pago doble)
            // ---------------------------------------------------------

            // 1. Desglosar cada rango en horas Diurnas (5am-7pm) y Nocturnas (7pm-5am)
            decimal totalDiurno = 0;
            decimal totalNocturno = 0;

            foreach (var rango in rangos)
            {
                var desglose = DesglosarRango(rango.Inicio, rango.Fin);
                totalDiurno += desglose.Diurno;
                totalNocturno += desglose.Nocturno;
            }

            resultado.TotalHoras = totalDiurno + totalNocturno;

            // 2. Clasificar la Jornada y Definir el Límite de Horas Regulares
            decimal limiteRegular;
            string tipoJornada;

            // PRIORIDAD 2: ¿ES SÁBADO? (Regla especial de empresa: límite 4 horas)
            if (fechaDia.DayOfWeek == DayOfWeek.Saturday)
            {
                limiteRegular = 4; // Límite reducido

                // Clasificación legal para determinar el tipo de recargo (aunque el límite sea 4)
                if (totalNocturno >= 3) tipoJornada = "Nocturna";
                else if (totalNocturno > 0) tipoJornada = "Mixta";
                else tipoJornada = "Diurna";

                resultado.TipoJornadaDetectada = tipoJornada + " (Sábado)";
            }
            // PRIORIDAD 3: LUNES A VIERNES
            else
            {
                // Por defecto Diurna (8 horas)
                limiteRegular = 8;
                tipoJornada = "Diurna";

                if (totalNocturno >= 3) // Regla de 3 horas nocturnas
                {
                    tipoJornada = "Nocturna";
                    limiteRegular = 6;
                }
                else if (totalNocturno > 0)
                {
                    // AQUÍ APLICAMOS EL CHECK DE RRHH
                    if (politica.AplicaJornadaMixta)
                    {
                        // Lógica Legal Estricta
                        tipoJornada = "Mixta";
                        limiteRegular = 7; // Baja a 7 horas
                    }
                    else
                    {
                        // Lógica RRHH (Mantener 8 horas)
                        tipoJornada = "Diurna Ext.";
                        limiteRegular = 8; // Se mantiene en 8 horas
                    }
                }
                resultado.TipoJornadaDetectada = tipoJornada;
            }

            // 3. Separar Horas Regulares de Extras (Matemática pura)
            decimal horasRegularesRestantes = limiteRegular;

            // 3a. Llenar cupo regular con horas diurnas
            decimal diurnasUsadasComoRegular = Math.Min(totalDiurno, horasRegularesRestantes);
            resultado.RegularesDiurnas = diurnasUsadasComoRegular;
            horasRegularesRestantes -= diurnasUsadasComoRegular;

            // 3b. Llenar cupo regular con horas nocturnas (si sobra cupo)
            decimal nocturnasUsadasComoRegular = Math.Min(totalNocturno, horasRegularesRestantes);
            resultado.RegularesNocturnas = nocturnasUsadasComoRegular;

            // 4. Calcular las Extras Brutas
            decimal extrasDiurnas = totalDiurno - diurnasUsadasComoRegular;
            decimal extrasNocturnas = totalNocturno - nocturnasUsadasComoRegular;

            // 5. Asignar a las categorías de pago (25%, 50%, 75%)
            if (tipoJornada == "Nocturna")
            {
                // Prolongación de jornada nocturna = +75% (Art. 330)
                resultado.Extras75 = extrasDiurnas + extrasNocturnas;
            }
            else // Jornada Diurna o Mixta
            {
                resultado.Extras25 = extrasDiurnas;    // Extras de día
                resultado.Extras50 = extrasNocturnas;  // Extras de noche
            }

            // ---------------------------------------------------------
            // FILTRO FINAL: APLICAR POLÍTICA DE PAGO
            // ---------------------------------------------------------

            if (!politica.PagaExtrasDiarias)
            {
                // CASO: Retroexcavadora o Tractor en un día normal.
                // La política dice que NO se pagan horas extras diarias (25/50/75).
                // Por lo tanto, convertimos esas "Extras" calculadas en "Regulares".
                // (Se pagan sencillo, no doble ni con recargo).

                decimal totalExtrasCalculadas = resultado.Extras25 + resultado.Extras50 + resultado.Extras75;

                // Las movemos a regulares (las sumamos a RegularesDiurnas para simplificar el total sencillo)
                resultado.RegularesDiurnas += totalExtrasCalculadas;

                // Ponemos las bolsas de extras en cero
                resultado.Extras25 = 0;
                resultado.Extras50 = 0;
                resultado.Extras75 = 0;

                resultado.TipoJornadaDetectada += " (Sin Recargos)";
            }

            return resultado;
        }

        // --- MÉTODO AUXILIAR: DESGLOSE MATEMÁTICO ---
        /// <summary>
        /// Determina cuántas horas de un rango caen en periodo Diurno (5am-7pm) y cuántas en Nocturno.
        /// </summary>
        private static (decimal Diurno, decimal Nocturno) DesglosarRango(DateTime inicio, DateTime fin)
        {
            if (inicio >= fin) return (0, 0);

            double minutosDiurnos = 0;
            double minutosNocturnos = 0;

            // Iteración minuto a minuto para precisión máxima en cruces de franjas
            DateTime cursor = inicio;

            while (cursor < fin)
            {
                // Definición Legal: Día es >= 5:00 AM y < 7:00 PM (19:00)
                int hora = cursor.Hour;
                bool esDeDia = (hora >= 5 && hora < 19);

                if (esDeDia)
                    minutosDiurnos++;
                else
                    minutosNocturnos++;

                cursor = cursor.AddMinutes(1);
            }

            return ((decimal)(minutosDiurnos / 60.0), (decimal)(minutosNocturnos / 60.0));
        }
    }
}
