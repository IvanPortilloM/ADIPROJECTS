using System;
using System.Net.Mail;
using System.Net;
using System.ServiceProcess;
using System.Timers;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace WSCorreos
{
    public partial class WSCorreos : ServiceBase
    {
        private Timer timer;
        private Timer monthlyTimer;
        public WSCorreos()
        {
            InitializeComponent();
            //Para cargar la clase EventLog para guardar eventos en los eventos del sistema
            eventosSistema = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("WSCorreos"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "WSCorreos", "Application");
            }
            eventosSistema.Source = "WSCorreos";
            eventosSistema.Log = "Application";
        }
        protected override void OnStart(string[] args)
        {
            TimeSpan timeToFirstExecution = GetTimeToFirstExecution();
            double interval = timeToFirstExecution.TotalMilliseconds;

            timer = new Timer(interval);
            timer.Elapsed += new ElapsedEventHandler(this.OnTimerElapsed);
            timer.Start();

            TimeSpan timeToNext6AM = GetTimeToNext6AM();
            monthlyTimer = new Timer(timeToNext6AM.TotalMilliseconds);
            monthlyTimer.Elapsed += new ElapsedEventHandler(this.OnMonthlyTimerElapsed);
            monthlyTimer.Start();

            //Escribir un evento en Application de los eventos del sistema
            eventosSistema.WriteEntry("Iniciado servicio de envío de correos automáticos de requisiciones");
        }

        protected override void OnStop()
        {
            timer.Stop();
            //Escribir un evento en Application de los eventos del sistema
            eventosSistema.WriteEntry("Detenido servicio de envío de correos automáticos de requisiciones");
        }
        private TimeSpan GetTimeToFirstExecution()
        {
            // Replace with the time you want the task to run each day
            TimeSpan runTime = new TimeSpan(6, 0, 0); // runs at 6 am

            DateTime now = DateTime.Now;
            DateTime todayRunTime = DateTime.Today.Add(runTime);

            if (now > todayRunTime)
            {
                // If the run time has already passed for today, schedule it for tomorrow
                return (todayRunTime.AddDays(1) - now);
            }
            else
            {
                // If the run time has not passed yet, schedule it for later today
                return (todayRunTime - now);
            }
        }
        //private TimeSpan GetTimeToFirstExecutionMonthly()
        //{
        //    DateTime now = DateTime.Now;
        //    DateTime nextMonth = now.AddMonths(1);
        //    DateTime firstDayNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);

        //    return (firstDayNextMonth - now);
        //}
        private void enviarcorreo(DataTable datos, bool diario)
        {
            // Creación del correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("serviciosadiggm@adiggm.hn", "Servidor A.D.I.-GGM");

            // Añadir destinatarios
            //mail.To.Add("dperdomo@adiggm.hn");
            //mail.To.Add("jflores@adiggm.hn");
            //mail.To.Add("nflores@adiggm.hn");
            mail.To.Add("fmercado@adiggm.hn");
            //mail.To.Add("glrivera@granjasmarinas.com");
            mail.To.Add("jportillo@adiggm.hn");

            // Puedes agregar tantos destinatarios como desees.

            // Configuración del correo
            mail.Subject = diario == true ? "El sistema ha encontrado requisiciones vencidas" : "Reporte mensual de requisiciones";
            mail.IsBodyHtml = true;  // Esto permite el formato HTML

            StringBuilder html = new StringBuilder();
            html.Append("<html><body><div style='text-align: center;'>");
            html.AppendLine("<h1>Detalles de la requisición</h1>");
            // Empieza la tabla
            
            html.AppendLine("<table border='1' style='margin: 0 auto;'>");

            // Agrega los encabezados de la tabla
            html.AppendLine("<tr>");
            foreach (DataColumn column in datos.Columns)
            {
                html.AppendLine("<th>" + column.ColumnName + "</th>");
            }
            html.AppendLine("</tr>");

            // Agrega los datos de la tabla
            foreach (DataRow row in datos.Rows)
            {
                html.AppendLine("<tr>");
                foreach (DataColumn column in datos.Columns)
                {
                    html.AppendLine("<td>" + row[column.ColumnName] + "</td>");
                }
                html.AppendLine("</tr>");
            }

            // Termina la tabla
            html.AppendLine("</table></div></body></html>");

            mail.Body = html.ToString();

            // Creación del cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("serviciosadiggm@adiggm.hn", "serviciosadi@2020");
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            // Enviar el correo
            client.Send(mail);
        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop(); // stop the timer while we are running the task

            // TODO: Add your code here to query the database and send emails
            // Define your connection string
            string connectionString = ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm");

            // Define your query or stored procedure
            string query = "SELECT Correlativo Consecutivo, CodVehiculo + ' - ' + Placa Unidad, CONVERT (varchar(10), Fecha, 103) [Fecha Ingreso], CONVERT (varchar(10), FechaEstimada, 103) [Fecha Estimada], DATEDIFF (DAY, GETDATE(), FechaEstimada) [Dif. de Días], DescripcionServicio Descripción " +
                "FROM OC_OrdenCompra OC INNER JOIN OC_OrdenCompraDet OCDet ON OC.IdOC = OCDet.IdOC INNER JOIN TR_Vehiculos V ON V.IdVehiculo = OCDet.IdVehiculo " +
                "WHERE IdTipoOC = 4 AND FechaEstimada < GETDATE() AND (OC.Confirmado IS NULL OR OC.Confirmado = 0) AND (Notificado IS NULL OR Notificado = 0)";

            // Create a new DataTable
            DataTable datos = new DataTable();

            // Connect to the database and execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Load the results into the DataTable
                        datos.Load(reader);
                    }
                }
            }

            // Send the email only if there are rows in the DataTable
            if (datos.Rows.Count > 0)
            {
                enviarcorreo(datos, true);

                string updateQuery = "UPDATE OC_OrdenCompra SET Notificado = 1 WHERE IdTipoOC = 4 AND FechaEstimada < GETDATE() AND (Confirmado IS NULL OR Confirmado = 0) AND (Notificado IS NULL OR Notificado = 0)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

            // After the task has run, reset the timer interval to 24 hours and start the timer again
            timer.Interval = TimeSpan.FromDays(1).TotalMilliseconds;
            timer.Start();
        }
        private void OnMonthlyTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Comprueba si hoy es el primer día del mes
            if (DateTime.Today.Day != 1)
            {
                return; // Si no es el primer día del mes, no hagas nada
            }

            monthlyTimer.Stop(); // stop the timer while we are running the task

            // Define your connection string
            string connectionString = ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm");

            // Define your query or stored procedure
            // This is just a placeholder, replace with your actual query
            string query = "SELECT Correlativo Consecutivo, CodVehiculo + ' - ' + Placa Unidad, CONVERT (varchar(10), Fecha, 103) [Fecha Ingreso], CONVERT (varchar(10), FechaEstimada, 103) [Fecha Estimada], ISNULL(CONVERT (varchar(10), FechaConfirmacion, 103),'') [Fecha Reparación], DATEDIFF (DAY, Fecha, FechaEstimada) [Días Est. Rep.], ISNULL(DATEDIFF (DAY, Fecha, FechaConfirmacion), '') [Días Reales Rep.], ISNULL(DATEDIFF (DAY, FechaEstimada, FechaConfirmacion), '') [Dif. de Días], DescripcionServicio Descripción " +
                "FROM OC_OrdenCompra OC INNER JOIN OC_OrdenCompraDet OCDet ON OC.IdOC = OCDet.IdOC INNER JOIN TR_Vehiculos V ON V.IdVehiculo = OCDet.IdVehiculo " +
                "WHERE MONTH(Fecha) = MONTH(DATEADD(MONTH, -1, GETDATE())) AND YEAR(Fecha) = YEAR(DATEADD(MONTH, -1, GETDATE())) AND IdTipoOC = 4 AND (Anulado IS NULL OR Anulado = 0)";

            // Create a new DataTable
            DataTable datos = new DataTable();

            // Connect to the database and execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Load the results into the DataTable
                        datos.Load(reader);
                    }
                }
            }

            // Send the email only if there are rows in the DataTable
            if (datos.Rows.Count > 0)
            {
                enviarcorreo(datos, false);
            }

            // After the task has run, reset the timer interval to 24 hours and start the timer again
            monthlyTimer.Interval = TimeSpan.FromDays(1).TotalMilliseconds;
            monthlyTimer.Start();
        }
        private TimeSpan GetTimeToNext6AM()
        {
            DateTime now = DateTime.Now;
            DateTime next6AM = DateTime.Today.AddHours(6);

            // Si ya pasaron las 6 AM de hoy, calcula la diferencia hasta las 6 AM de mañana
            if (now > next6AM)
            {
                next6AM = next6AM.AddDays(1);
            }

            return (next6AM - now);
        }

    }
}