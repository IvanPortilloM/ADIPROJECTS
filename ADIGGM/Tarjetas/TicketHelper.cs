using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public class TicketHelper
    {
        // Variables internas para armar el ticket
        private string _titulo;
        private string _codigo;
        private string _referencia;
        private string _montoOPuntos;
        private string _nuevoSaldo;
        private string _cajero;

        public void ImprimirTicket(string titulo, string codigo, string referencia, string montoOPuntos, string nuevoSaldo, string cajero)
        {
            _titulo = titulo;
            _codigo = codigo;
            _referencia = referencia;
            _montoOPuntos = montoOPuntos;
            _nuevoSaldo = nuevoSaldo;
            _cajero = cajero;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(GenerarDiseñoTicket);

            try
            {
                // --- NUEVO CÓDIGO DE VISTA PREVIA ---
                PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
                vistaPrevia.Document = printDoc;
                vistaPrevia.Text = "Vista Previa del Comprobante";

                // Ajustamos un tamaño cómodo para ver el formato de ticket de supermercado
                vistaPrevia.Width = 450;
                vistaPrevia.Height = 600;

                // Posicionamos la ventana al centro de la pantalla
                vistaPrevia.StartPosition = FormStartPosition.CenterScreen;

                // Mostramos la ventana. El cajero verá el ticket y podrá darle al icono de "Imprimir"
                vistaPrevia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la vista previa: " + ex.Message, "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerarDiseñoTicket(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            // Usamos una fuente monoespaciada para que todo quede bien alineado
            Font fontTitulo = new Font("Courier New", 12, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 9, FontStyle.Regular);
            Font fontNegrita = new Font("Courier New", 9, FontStyle.Bold);

            int y = 10;
            int margenIzquierdo = 5; // Ajustable según si el rollo es de 58mm o 80mm

            // --- ENCABEZADO ---
            g.DrawString("SUPERMERCADO ADIGGM", fontTitulo, Brushes.Black, margenIzquierdo, y);
            y += 20;
            g.DrawString(_titulo, fontNegrita, Brushes.Black, margenIzquierdo, y);
            y += 20;
            g.DrawString("--------------------------------", fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;

            // --- DETALLES DE TRANSACCIÓN ---
            g.DrawString("Fecha : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;
            g.DrawString("Cajero: " + _cajero, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;
            g.DrawString("Ref   : " + _referencia, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;
            g.DrawString("Tarjeta/Mem: " + _codigo, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;
            g.DrawString("--------------------------------", fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;

            // --- MONTOS ---
            g.DrawString(_montoOPuntos, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 15;
            g.DrawString("NUEVO SALDO: " + _nuevoSaldo, fontNegrita, Brushes.Black, margenIzquierdo, y);
            y += 20;
            g.DrawString("--------------------------------", fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 20;

            // --- PIE DE PÁGINA ---
            g.DrawString(" ¡Gracias por su preferencia!", fontNormal, Brushes.Black, margenIzquierdo, y);
        }
    }
}