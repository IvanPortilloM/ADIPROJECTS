using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using ADIGGM.FAC.Transacciones;
using ADIGGM.Herramientas;
using ADIGGM.IA.Busquedas;
using ADIGGM.INV.Mantenimiento;
using ADIGGM.INV.Transacciones;
using ADIGGM.INV.Visores;
using ADIGGM.Mantenimiento;
using ADIGGM.OC.Mantenimiento;
using ADIGGM.OC.Reportes;
using ADIGGM.OC.Transacciones;
using ADIGGM.OC.Visores;
using ADIGGM.PRESUPUESTO.Mantenimiento;
using ADIGGM.PRESUPUESTO.Transaccionales;
using ADIGGM.PRESUPUESTO.Visores;
using ADIGGM.SAC;
using ADIGGM.Seguridad;
using System.Data.SqlClient;
using ADIGGM.SAC.Visores;
using System.Drawing;
using System.Timers;
using ADIGGM.HE;
using ADIGGM.Tarjetas;

namespace ADIGGM.Formularios_Base
{
    public partial class MdiPrincipal : Form
    {
        private int idusuario;
        private static string lastClipboardText = string.Empty;
        private static System.Windows.Forms.Timer clipboardTimer;
        private NotifyIcon notifyIcon = new NotifyIcon();
        public MdiPrincipal(int idusuario_esperado)
        {
            InitializeComponent();

            idusuario = idusuario_esperado;
        }
        
        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmClientes"] != null)
            {
                Application.OpenForms["FrmClientes"].Activate();
            }
            else
            {
                FrmClientes clientes = new FrmClientes
                {
                    MdiParent = this
                };
                clientes.Show();
            }
        }

        private void registroDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tContratistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmContratistas"] != null)
            {
                Application.OpenForms["FrmContratistas"].Activate();
            }
            else
            {
                FrmContratistas contratistas = new FrmContratistas
                {
                    MdiParent = this
                };
                contratistas.Show();
            }
        }

        private void tMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmMotoristas"] != null)
            {
                Application.OpenForms["FrmMotoristas"].Activate();
            }
            else
            {
                FrmMotoristas motoristas = new FrmMotoristas
                {
                    MdiParent = this
                };
                motoristas.Show();
            }
        }

        private void tVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmVehiculos"] != null)
            {
                Application.OpenForms["FrmVehiculos"].Activate();
            }
            else
            {
                FrmVehiculos vehiculos = new FrmVehiculos
                {
                    MdiParent = this
                };
                vehiculos.Show();
            }
        }

        private void tTipoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTipoVehiculos"] != null)
            {
                Application.OpenForms["FrmTipoVehiculos"].Activate();
            }
            else
            {
                FrmTipoVehiculos tipoVehiculos = new FrmTipoVehiculos
                {
                    MdiParent = this
                };
                tipoVehiculos.Show();
            }
        }

        private void tRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRutas"] != null)
            {
                Application.OpenForms["FrmRutas"].Activate();
            }
            else
            {
                FrmRutas rutas = new FrmRutas { MdiParent = this };
                rutas.Show();
            }
        }

        private void tAsignarRutasAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAsigRutaClientes"] != null)
            {
                Application.OpenForms["FrmAsigRutaClientes"].Activate();
            }
            else
            {
                FrmAsigRutaClientes asigRutaClientes = new FrmAsigRutaClientes { MdiParent = this };
                asigRutaClientes.Show();
            }
        }

        private void tTarifaPorRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAsigTarifas"] != null)
            {
                Application.OpenForms["FrmAsigTarifas"].Activate();
            }
            else
            {
                FrmAsigTarifas tarifaRutas = new FrmAsigTarifas { MdiParent = this };
                tarifaRutas.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tPrefijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmPrefijos"] != null)
            {
                Application.OpenForms["FrmPrefijos"].Activate();
            }
            else
            {
                FrmPrefijos prefijos = new FrmPrefijos { MdiParent = this };
                prefijos.Show();
            }
        }

        private void reporteDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RptMaestro"] != null)
            {
                Application.OpenForms["RptMaestro"].Activate();
            }
            else
            {
                Reportes.RptMaestro rptViajes = new Reportes.RptMaestro { MdiParent = this };
                rptViajes.Show();
            }
        }

        private void t10AsigRutaTipoVehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAsigRutaTpVeh"] != null)
            {
                Application.OpenForms["FrmAsigRutaTpVeh"].Activate();
            }
            else
            {
                FrmAsigRutaTpVeh rutasTipoVeh = new FrmAsigRutaTpVeh { MdiParent = this };
                rutasTipoVeh.Show();
            }
        }
        private void CambiarOpcionesMenu(ToolStripItemCollection colOpcionesMenu)
        {
            // recorrer el submenú

            foreach (ToolStripItem itmOpcion in colOpcionesMenu.OfType<ToolStripMenuItem>())
            {
                itmOpcion.Visible = false;

                if (((ToolStripMenuItem)itmOpcion).DropDownItems.Count > 0)
                {
                    this.CambiarOpcionesMenu(((ToolStripMenuItem)itmOpcion).DropDownItems);
                }
            }
        }
        private bool busca(ToolStripMenuItem item, string nombreItem)
        {
            if (item.DropDownItems.ContainsKey(nombreItem))
            {
                item.DropDownItems[nombreItem].Visible = !item.DropDownItems[nombreItem].Visible;
                return true;
            }
            else
            {
                if (item.DropDownItems.Count != 0)
                {
                    foreach (ToolStripDropDownItem subitem in item.DropDownItems)
                    {
                        if (buscaSubitems(subitem, nombreItem)) return true;
                    }
                }
            }
            return false;
        }
        private bool buscaSubitems(ToolStripDropDownItem subitem, string nombreItem)
        {
            if (subitem.DropDownItems.ContainsKey(nombreItem))
            {
                subitem.DropDownItems[nombreItem].Visible = !subitem.DropDownItems[nombreItem].Visible;
                return true;
            }
            else
            {
                if (subitem.DropDownItems.Count != 0)
                {
                    foreach (ToolStripDropDownItem subitem2 in subitem.DropDownItems)
                    {
                        return buscaSubitems(subitem2, nombreItem);
                    }
                }
            }
            return false;
        }
        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            DateTime FechaMin = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMinCierre()),
                     FechaMax = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMaxCierre());

            foreach (ToolStripMenuItem mnuitOpcion in this.menuStrip1.Items.OfType<ToolStripMenuItem>())
            {
                mnuitOpcion.Visible = false;

                if (mnuitOpcion.DropDownItems.Count > 0)
                {
                    this.CambiarOpcionesMenu(mnuitOpcion.DropDownItems);
                }
            }

            List<CapaModelo.Menu> permisos_esperados = CD_Usuario.ObtenerPermisos(idusuario);

            foreach(CapaModelo.Menu objMenu in permisos_esperados)
            {
                ToolStripMenuItem menuPadre = new ToolStripMenuItem(objMenu.NombreMenu);

                if (menuStrip1.Items.ContainsKey(menuPadre.Text))
                {
                    menuStrip1.Items[menuPadre.Text].Visible = true;
                }

                foreach (SubMenu objsubmenu in objMenu.ListaSubMenu)
                {
                    ToolStripMenuItem menuHijo = new ToolStripMenuItem(objsubmenu.NombreMenu);

                    //if (menuStrip1.Items.ContainsKey(menuHijo.Text))
                    //{
                    //    menuStrip1.Items[menuHijo.Text].Visible = true;
                    //}
                    //else
                    //{
                        foreach (ToolStripMenuItem item in menuStrip1.Items)
                        {
                            busca(item, menuHijo.Text);
                        }
                    //}

                    foreach (SubMenuNieto objdetsubmenu in objsubmenu.ListaSubMenuNieto)
                    {
                        ToolStripMenuItem menuNieto = new ToolStripMenuItem(objdetsubmenu.NombreMenu);

                        //if (menuStrip1.Items.ContainsKey(menuNieto.Text))
                        //{
                        //    menuStrip1.Items[menuNieto.Text].Visible = true;
                        //}
                        //else
                        //{
                            foreach (ToolStripMenuItem item in menuStrip1.Items)
                            {
                                busca(item, menuNieto.Text);
                            }
                        //}
                    }
                }                
            }
            toolStripStatusLabel4.Text = "| Cierre actual desde " + FechaMin.ToShortDateString() + " Hasta el " + FechaMax.ToShortDateString();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                toolStripStatusLabel2.Text = "| Versión: " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            toolStripStatusLabel5.Text = "| Usuario: "+ Clases.VarGlobales.Usuario;

            //// Define your connection string
            //string connectionString = "Initial Catalog=TransporteAdiggm;Data Source=ADIGGM.granjasmarinas.hn;Persist Security Info=True;User ID=sa;Password=ADIGGM*2016+";

            //// Define your query or stored procedure
            //string query = "SELECT Correlativo Consecutivo, CodVehiculo + ' - ' + Placa Unidad, CONVERT (varchar(10), Fecha, 103) [Fecha Ingreso], CONVERT (varchar(10), FechaEstimada, 103) [Fecha Estimada],DATEDIFF (DAY, GETDATE(), FechaEstimada) [Dias Estimados], DescripcionServicio Descripción FROM OC_OrdenCompra OC INNER JOIN OC_OrdenCompraDet OCDet ON OC.IdOC = OCDet.IdOC INNER JOIN TR_Vehiculos V ON V.IdVehiculo = OCDet.IdVehiculo WHERE IdTipoOC = 4";

            //// Create a new DataTable
            //DataTable datos = new DataTable();

            //// Connect to the database and execute the query
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        connection.Open();

            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            // Load the results into the DataTable
            //            datos.Load(reader);
            //        }
            //    }
            //}

            //// Send the email

            //enviarcorreo(datos);

            notifyIcon.Icon = SystemIcons.Information; // Cambia el icono según sea necesario
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Notificación del Sistema";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;


            // Inicia el monitoreo del portapapeles
            clipboardTimer = new System.Windows.Forms.Timer();
            clipboardTimer.Interval = 1000; // Verifica cada 1 segundo
            clipboardTimer.Tick += (s, ev) => CheckClipboard();
            clipboardTimer.Start();
        }

        private bool IsValidNumber(string input)
        {
            // Elimina todos los espacios del texto
            string cleanInput = input.Replace(" ", "");

            // Verifica si es el código de la empresa y lo excluye
            if (cleanInput == "6019007096426")
            {
                return false; // No es válido si es el código de la empresa
            }

            // Verifica si cumple con el formato esperado (13 o 15 caracteres con guiones)
            return cleanInput.Length == 13 ||
                   (cleanInput.Length == 15 && cleanInput[4] == '-' && cleanInput[9] == '-');
        }

        private static (string nombreAsociado, List<string> messages) GetDataForNotification(string idAsociado)
        {
            var messages = new List<string>();
            string nombreAsociado = "Desconocido";

            using (var connection = new SqlConnection(ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm")))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT TOP 3 CONVERT(VARCHAR, FechaOrden, 103) AS FechaOrden, 
                           NombreAsociado, 
                           NombreProveedor, 
                           SUM(Valor) AS Valor
                        FROM SAC_Ordenes O 
                        LEFT JOIN OC_Proveedores P ON O.IdProveedor = P.IdProveedor
                        WHERE IdAsociado = @IdAsociado AND Estado = 'False'
                        GROUP BY FechaOrden, NombreAsociado, NombreProveedor, NumOrden
                        ORDER BY NumOrden DESC";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdAsociado", idAsociado);

                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                messages.Add("No se encontraron registros para el asociado.");
                                return (nombreAsociado, messages);
                            }

                            while (reader.Read())
                            {
                                // Captura el nombre del asociado
                                nombreAsociado = reader["NombreAsociado"].ToString();

                                // Agrega los registros a los mensajes
                                messages.Add($"{reader["FechaOrden"]} | {reader["NombreProveedor"]} | {reader["Valor"]:N2}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al consultar la base de datos: {ex.Message}");
                    messages.Add("Error al obtener los datos.");
                }
            }

            return (nombreAsociado, messages);
        }


        private Queue<string> notificationQueue = new Queue<string>();
        private System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();

        private void ShowNotifications(IEnumerable<string> messages, string title)
        {
            // Establece el título de la notificación
            notifyIcon.BalloonTipTitle = title;

            // Encola los mensajes
            foreach (var message in messages)
            {
                notificationQueue.Enqueue(message);
            }

            // Configura el temporizador
            notificationTimer.Interval = 3000; // 3 segundos entre notificaciones
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();

            // Muestra la primera notificación inmediatamente
            ShowNextNotification();
        }


        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            ShowNextNotification();
        }

        private void ShowNextNotification()
        {
            if (notificationQueue.Count > 0)
            {
                string message = notificationQueue.Dequeue();
                notifyIcon.BalloonTipText = message;
                notifyIcon.ShowBalloonTip(3000);
            }
            else
            {
                // Detiene el temporizador cuando no hay más notificaciones
                notificationTimer.Stop();
            }
        }

        private void CheckClipboard()
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();

                    if (clipboardText != lastClipboardText)
                    {
                        lastClipboardText = clipboardText;

                        if (IsValidNumber(clipboardText))
                        {
                            string cleanText = clipboardText.Replace(" ", ""); // Elimina espacios
                            cleanText = cleanText.Replace("-", ""); //Elimina guiones
                            var (nombreAsociado, messages) = GetDataForNotification(cleanText);

                            // Establece el título como el nombre del asociado
                            string title = string.IsNullOrEmpty(nombreAsociado) ? "Desconocido" : nombreAsociado;
                            if (title != "Desconocido")
                            {
                                ShowNotifications(messages, title);
                            }                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al acceder al portapapeles: {ex.Message}");
            }
        }
        private void enviarcorreo(DataTable datos)
        {
            // Creación del correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("serviciosadiggm@adiggm.hn", "Servidor A.D.I.-GGM");

            // Añadir destinatarios
            //mail.To.Add("dperdomo@adiggm.hn");
            //mail.To.Add("jflores@adiggm.hn");
            //mail.To.Add("nflores@adiggm.hn");
            //mail.To.Add("fmercado@adiggm.hn");
            //mail.To.Add("glrivera@granjasmarinas.com");
            mail.To.Add("jportillo@adiggm.hn");
            // Puedes agregar tantos destinatarios como desees.

            // Configuración del correo
            mail.Subject = "El sistema ha encontrado requisiciones vencidas";
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
            client.Credentials = new NetworkCredential(ADIGGM.CapaDatos.AppConfig.SmtpUsuario, ADIGGM.CapaDatos.AppConfig.SmtpClave);
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            // Enviar el correo
            client.Send(mail);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "| Fecha y Hora: " +DateTime.Now.ToString();
        }

        private void MdiPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsKeyLocked(Keys.Insert))
            {
                SendKeys.Send("{Insert}");
            }
        }

        private void tClaseDeTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmClaseTrabajos"] != null)
            {
                Application.OpenForms["FrmClaseTrabajos"].Activate();
            }
            else
            {
                FrmClaseTrabajos claseTrabajos = new FrmClaseTrabajos { MdiParent = this };
                claseTrabajos.Show();
            }
        }

        private void r00FincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmFincas"] != null)
            {
                Application.OpenForms["FrmFincas"].Activate();
            }
            else
            {
                FrmFincas fincas = new FrmFincas { MdiParent = this };
                fincas.Show();
            }
        }

        private void R01AsigFincaAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAsigFincaClientes"] != null)
            {
                Application.OpenForms["FrmAsigFincaClientes"].Activate();
            }
            else
            {
                FrmAsigFincaClientes asigFincaClientes = new FrmAsigFincaClientes { MdiParent = this };
                asigFincaClientes.Show();
            }
        }

        private void R02LagunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["FrmLagunas"] != null)
            {
                Application.OpenForms["FrmLagunas"].Activate();
            }
            else
            {
                FrmLagunas lagunas = new FrmLagunas { MdiParent = this };
                lagunas.Show();
            }
        }

        private void r03ZonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmZonas"] != null)
            {
                Application.OpenForms["FrmZonas"].Activate();
            }
            else
            {
                FrmZonas zonas = new FrmZonas { MdiParent = this };
                zonas.Show();
            }
        }

        private void r04BloquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmBloques"] != null)
            {
                Application.OpenForms["FrmBloques"].Activate();
            }
            else
            {
                FrmBloques bloques = new FrmBloques { MdiParent = this };
                bloques.Show();
            }
        }

        private void f00TipoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTipoFac"] != null)
            {
                Application.OpenForms["FrmTipoFac"].Activate();
            }
            else
            {
                FrmTipoFac tipoFac = new FrmTipoFac { MdiParent = this };
                tipoFac.Show();
            }
        }

        private void f01AsigTipoFacATipoVehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAsigTpFacTpVeh"] != null)
            {
                Application.OpenForms["FrmAsigTpFacTpVeh"].Activate();
            }
            else
            {
                FrmAsigTpFacTpVeh asigTpFacTpVeh = new FrmAsigTpFacTpVeh { MdiParent = this };
                asigTpFacTpVeh.Show();
            }
        }

        private void h01EnvíoDeEstCtaMasivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void h00SincronizarCODEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void h04SolicitudWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["FrmSyncSolicitudWeb"] != null)
            //{
            //    Application.OpenForms["FrmSyncSolicitudWeb"].Activate();
            //}
            //else
            //{
            //    SACWeb.FrmSyncSolicitudWeb syncSolicitudWeb = new SACWeb.FrmSyncSolicitudWeb { MdiParent = this };
            //    syncSolicitudWeb.Show();
            //}
        }

        private void h05AsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["FrmWebAsoc"] != null)
            //{
            //    Application.OpenForms["FrmWebAsoc"].Activate();
            //}
            //else
            //{
            //    SACWeb.FrmWebAsoc frmWebAsoc = new SACWeb.FrmWebAsoc { MdiParent = this };
            //    frmWebAsoc.Show();
            //}
        }
        private void oC01TipoOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManTipoOC"] != null)
            {
                Application.OpenForms["ManTipoOC"].Activate();
            }
            else
            {
                ManTipoOC manTipoOC = new ManTipoOC { MdiParent = this };
                manTipoOC.Show();
            }

        }

        private void oC02ProductosCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManCatProductos"] != null)
            {
                Application.OpenForms["ManCatProductos"].Activate();
            }
            else
            {
                OC.ManCatProductos manCatProductos = new OC.ManCatProductos { MdiParent = this };
                manCatProductos.Show();
            }
        }

        private void oC03ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManProductos"] != null)
            {
                Application.OpenForms["ManProductos"].Activate();
            }
            else
            {
                OC.ManProductos manProductos = new OC.ManProductos { MdiParent = this };
                manProductos.Show();
            }
        }

        private void oC04ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisProveedores"] != null)
            {
                Application.OpenForms["VisProveedores"].Activate();
            }
            else
            {
                VisProveedores visProveedores = new VisProveedores { MdiParent = this };
                visProveedores.Show();
            }
        }

        private void oC05AsignarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManAsigCuentas"] != null)
            {
                Application.OpenForms["ManAsigCuentas"].Activate();
            }
            else
            {
                ManAsigCuentas manAsigCuentas = new ManAsigCuentas { MdiParent = this };
                manAsigCuentas.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void oCOrdenesConfirmadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oC06DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManDepartamentos"] != null)
            {
                Application.OpenForms["ManDepartamentos"].Activate();
            }
            else
            {
                ManDepartamentos manDepartamentos = new ManDepartamentos { MdiParent = this };
                manDepartamentos.Show();
            }
        }

        private void oC07ParametrizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManParametrizacion"] != null)
            {
                Application.OpenForms["ManParametrizacion"].Activate();
            }
            else
            {
                ManParametrizacion manParametrizacion = new ManParametrizacion { MdiParent = this };
                manParametrizacion.Show();
            }
        }

        private void cXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fAC03TipoFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_TipoFacturas"] != null)
            {
                Application.OpenForms["FAC_TipoFacturas"].Activate();
            }
            else
            {
                FAC.Mantenimiento.FAC_TipoFacturas manParametrizacion = new FAC.Mantenimiento.FAC_TipoFacturas { MdiParent = this };
                manParametrizacion.Show();
            }
        }

        private void fAC01CAIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_CAI"] != null)
            {
                Application.OpenForms["FAC_CAI"].Activate();
            }
            else
            {
                FAC.Mantenimiento.FAC_CAI cAI = new FAC.Mantenimiento.FAC_CAI { MdiParent = this };
                cAI.Show();
            }
        }

        private void fAC02ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_Productos"] != null)
            {
                Application.OpenForms["FAC_Productos"].Activate();
            }
            else
            {
                FAC.Mantenimiento.FAC_Productos productos = new FAC.Mantenimiento.FAC_Productos { MdiParent = this };
                productos.Show();
            }
        }

        private void fAC04AsigTipoFacUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_TipoFacUsuarios"] != null)
            {
                Application.OpenForms["FAC_TipoFacUsuarios"].Activate();
            }
            else
            {
                FAC.Mantenimiento.FAC_TipoFacUsuarios tipoFacUsuarios = new FAC.Mantenimiento.FAC_TipoFacUsuarios { MdiParent = this };
                tipoFacUsuarios.Show();
            }
        }

        private void fACTipoMonedatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_TipoMoneda"] != null)
            {
                Application.OpenForms["FAC_TipoMoneda"].Activate();
            }
            else
            {
                FAC.Mantenimiento.FAC_TipoMoneda tipoMoneda = new FAC.Mantenimiento.FAC_TipoMoneda { MdiParent = this };
                tipoMoneda.Show();
            }
        }

        private void reporteProformasFincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_ReporteCierres"] != null)
            {
                Application.OpenForms["FAC_ReporteCierres"].Activate();
            }
            else
            {
                FAC.Reportes.FAC_ReporteCierres reporteCierres = new FAC.Reportes.FAC_ReporteCierres { MdiParent = this };
                reporteCierres.Show();
            }
        }

        private void oC08ResponsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManResponsables"] != null)
            {
                Application.OpenForms["ManResponsables"].Activate();
            }
            else
            {
                ManResponsables manResponsables = new ManResponsables
                {
                    MdiParent = this
                };
                manResponsables.Show();
            }
        }

        private void reporteTrazabilidadVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TrazabilidadVehiculo"] != null)
            {
                Application.OpenForms["TrazabilidadVehiculo"].Activate();
            }
            else
            {
                TrazabilidadVehiculo trazabilidadVehiculo = new TrazabilidadVehiculo { MdiParent = this };
                trazabilidadVehiculo.Show();
            }
        }

        private void reporteMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ReporteMaestro"] != null)
            {
                Application.OpenForms["ReporteMaestro"].Activate();
            }
            else
            {
                ReporteMaestro reporteMaestro = new ReporteMaestro { MdiParent = this };
                reporteMaestro.Show();
            }
        }
        private void pR01tipoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTipoContratos"] != null)
            {
                Application.OpenForms["FrmTipoContratos"].Activate();
            }
            else
            {
                frmTipoContratos TipoContrato = new frmTipoContratos { MdiParent = this };
                TipoContrato.Show();
            }
        }
        private void pR02TipoDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoMoneda"] != null)
            {
                Application.OpenForms["frmTipoMoneda"].Activate();
            }
            else
            {
                frmTipoMoneda tipoMoneda = new frmTipoMoneda { MdiParent = this };
                tipoMoneda.Show();
            }
        }

        private void pR03TipoDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoMateriales"] != null)
            {
                Application.OpenForms["frmTipoMateriales"].Activate();
            }
            else
            {
                frmTipoMateriales tipoMateriales = new frmTipoMateriales { MdiParent = this };
                tipoMateriales.Show();
            }
        }

        private void pR04AñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAños"] != null)
            {
                Application.OpenForms["frmAños"].Activate();
            }
            else
            {
                frmAños años = new frmAños { MdiParent = this };
                años.Show();
            }
        }

        private void pR05MesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMeses"] != null)
            {
                Application.OpenForms["frmMeses"].Activate();
            }
            else
            {
                frmMeses meses = new frmMeses { MdiParent = this };
                meses.Show();
            }
        }

        private void pR06SemanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSemanas"] != null)
            {
                Application.OpenForms["frmSemanas"].Activate();
            }
            else
            {
                frmSemanas semanas = new frmSemanas { MdiParent = this };
                semanas.Show();
            }
        }

        private void pR07DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDepartamentos"] != null)
            {
                Application.OpenForms["frmDepartamentos"].Activate();
            }
            else
            {
                frmDepartamentos departamentos = new frmDepartamentos { MdiParent = this };
                departamentos.Show();
            }
        }

        private void pR08CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCargos"] != null)
            {
                Application.OpenForms["frmCargos"].Activate();
            }
            else
            {
                frmCargos cargos = new frmCargos { MdiParent = this };
                cargos.Show();
            }
        }

        private void pR09UnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUndMedidas"] != null)
            {
                Application.OpenForms["frmUndMedidas"].Activate();
            }
            else
            {
                frmUndMedidas undMedidas = new frmUndMedidas { MdiParent = this };
                undMedidas.Show();
            }
        }

        private void pR10CuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCuentasContables"] != null)
            {
                Application.OpenForms["frmCuentasContables"].Activate();
            }
            else
            {
                frmCuentasContables cuentasContables = new frmCuentasContables { MdiParent = this };
                cuentasContables.Show();
            }
        }

        private void pR11EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEmpleados"] != null)
            {
                Application.OpenForms["frmEmpleados"].Activate();
            }
            else
            {
                frmEmpleados empleados = new frmEmpleados { MdiParent = this };
                empleados.Show();
            }
        }

        private void pR12GeneroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Genero"] != null)
            {
                Application.OpenForms["frm_Genero"].Activate();
            }
            else
            {
                frm_Genero genero = new frm_Genero { MdiParent = this };
                genero.Show();
            }
        }

        private void pR13MaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMateriales"] != null)
            {
                Application.OpenForms["frmMateriales"].Activate();
            }
            else
            {
                frmMateriales materiales = new frmMateriales { MdiParent = this };
                materiales.Show();
            }
        }

        private void pR14AsignarDepartamentosAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAsigDeptosAUsu"] != null)
            {
                Application.OpenForms["frmAsigDeptosAUsu"].Activate();
            }
            else
            {
                frmAsigDeptosAUsu asigDeptosAUsu = new frmAsigDeptosAUsu { MdiParent = this };
                asigDeptosAUsu.Show();
            }
        }

        private void pR15AsignarCuentasADepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAsigDeptosCtas"] != null)
            {
                Application.OpenForms["frmAsigDeptosCtas"].Activate();
            }
            else
            {
                frmAsigDeptosACtas asigDeptosCtas = new frmAsigDeptosACtas { MdiParent = this };
                asigDeptosCtas.Show();
            }
        }
        private void pR17AsignarCuentasAMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAsigCtasAMat"] != null)
            {
                Application.OpenForms["frmAsigCtasAMat"].Activate();
            }
            else
            {
                frmAsigCtasAMat asigCtasAMat = new frmAsigCtasAMat { MdiParent = this };
                asigCtasAMat.Show();
            }
        }

        private void pR18CategoriasDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCuentaCategoria"] != null)
            {
                Application.OpenForms["frmCuentaCategoria"].Activate();
            }
            else
            {
                frmCuentaCategoria cuentaCategoria = new frmCuentaCategoria { MdiParent = this };
                cuentaCategoria.Show();
            }
        }

        private void h04ConsultaDeAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void h05MenúCafeteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void c02ConfFechasDeAmortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elaborarOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TranOrdenCompra"] != null)
            {
                Application.OpenForms["TranOrdenCompra"].WindowState = FormWindowState.Normal;
                Application.OpenForms["TranOrdenCompra"].Activate();
            }
            else
            {
                TranOrdenCompra tranOrdenCompra = new TranOrdenCompra(0)
                {
                    MdiParent = this
                };
                tranOrdenCompra.Show();
            }
        }

        private void elaborarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_Facturas"] != null)
            {
                Application.OpenForms["FAC_Facturas"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FAC_Facturas"].Activate();
            }
            else
            {
                FAC_Factura factura = new FAC_Factura { MdiParent = this };
                factura.Show();
            }
        }

        private void registrarBoletasDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmViajes"] != null)
            {
                Application.OpenForms["FrmViajes"].Activate();
            }
            else
            {
                Transaccionales.FrmViajes viajes = new Transaccionales.FrmViajes(0, "", "", DateTime.Now, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0)
                {
                    MdiParent = this
                };
                viajes.Show();
            }
        }

        private void generarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmGenerarPresupuesto"] != null)
            {
                Application.OpenForms["frmGenerarPresupuesto"].Activate();
            }
            else
            {
                frmGenerarPresupuesto generarPresupuesto = new frmGenerarPresupuesto { MdiParent = this };
                generarPresupuesto.Show();
            }
        }

        private void registarBoletasDeViajesRetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmViajesRetro"] != null)
            {
                Application.OpenForms["FrmViajesRetro"].Activate();
            }
            else
            {
                Transaccionales.FrmViajesRetro viajesRetro = new Transaccionales.FrmViajesRetro(0, 0, "", "", DateTime.Now, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0)
                {
                    MdiParent = this
                };
                viajesRetro.Show();
            }
        }

        private void c00CierreSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmCierres"] != null)
            {
                Application.OpenForms["FrmCierres"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmCierres"].Activate();
            }
            else
            {
                FrmCierres cierres = new FrmCierres
                {
                    MdiParent = this
                };
                cierres.Show();
            }
        }

        private void solicitudesReimprimirDesconfirmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisOCSolicitudes"] != null)
            {
                Application.OpenForms["VisOCSolicitudes"].Activate();
            }
            else
            {
                VisOCSolicitudes visOcSolicitudes = new VisOCSolicitudes { MdiParent = this };
                visOcSolicitudes.Show();
            }
        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmVisorPresSemanal"] != null)
            {
                Application.OpenForms["frmVisorPresSemanal"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmVisorPresSemanal"].Activate();
            }
            else
            {
                frmVisorPresupuesto presSemanal = new frmVisorPresupuesto { MdiParent = this };
                presSemanal.Show();
            }
        }

        private void MdiPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void s00UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmMantUsuarios"] != null)
            {
                Application.OpenForms["FrmMantUsuarios"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmMantUsuarios"].Activate();
            }
            else
            {
                FrmMantUsuarios mantUsuarios = new FrmMantUsuarios { MdiParent = this };
                mantUsuarios.Show();
            }
        }

        private void s01MenusDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMenuSistema"] != null)
            {
                Application.OpenForms["frmMenuSistema"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmMenuSistema"].Activate();
            }
            else
            {
                frmMenuSistema menuSistema = new frmMenuSistema { MdiParent = this };
                menuSistema.Show();
            }
        }

        private void s02SubMenusDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSubMenu"] != null)
            {
                Application.OpenForms["frmSubMenu"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmSubMenu"].Activate();
            }
            else
            {
                frmSubMenu subMenu = new frmSubMenu { MdiParent = this };
                subMenu.Show();
            }
        }

        private void c00ConfTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmConfig"] != null)
            {
                Application.OpenForms["FrmConfig"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmConfig"].Activate();
            }
            else
            {
                FrmConfig config = new FrmConfig { MdiParent = this };
                config.Show();
            }
        }

        private void cambiosDeAceiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisCambioAceite"] != null)
            {
                Application.OpenForms["VisCambioAceite"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisCambioAceite"].Activate();
            }
            else
            {
                VisCambioAceite cambioAceite = new VisCambioAceite { MdiParent = this };
                cambioAceite.Show();
            }
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmVisorViajes"] != null)
            {
                Application.OpenForms["FrmVisorViajes"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmVisorViajes"].Activate();
            }
            else
            {
                Visores.FrmVisorViajes visorViajes = new Visores.FrmVisorViajes { MdiParent = this };
                visorViajes.Show();
            }
        }

        private void oCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisOrdenesTrabajo"] != null)
            {
                Application.OpenForms["VisOrdenesTrabajo"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisOrdenesTrabajo"].Activate();
            }
            else
            {
                VisOrdenesTrabajo visOrdenesTrabajo = new VisOrdenesTrabajo { MdiParent = this };
                visOrdenesTrabajo.Show();
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FAC_VisorFacturas"] != null)
            {
                Application.OpenForms["FAC_VisorFacturas"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FAC_VisorFacturas"].Activate();
            }
            else
            {
                FAC.Visores.FAC_VisorFacturas manParametrizacion = new FAC.Visores.FAC_VisorFacturas { MdiParent = this };
                manParametrizacion.Show();
            }
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmVisorPrestamos"] != null)
            {
                Application.OpenForms["FrmVisorPrestamos"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmVisorPrestamos"].Activate();
            }
            else
            {
                ADIGGM.Visores.FrmVisorPrestamos visorPrestamo = new ADIGGM.Visores.FrmVisorPrestamos
                {
                    MdiParent = this
                };
                visorPrestamo.Show();
            }
        }

        private void oCCODEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisOCCodeas"] != null)
            {
                Application.OpenForms["VisOCCodeas"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisOCCodeas"].Activate();
            }
            else
            {
                VisOCCodeas visOCCodeas = new VisOCCodeas { MdiParent = this };
                visOCCodeas.Show();
            }
        }

        private void oCConfirmadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisOCConfirmadas"] != null)
            {
                Application.OpenForms["VisOCConfirmadas"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisOCConfirmadas"].Activate();
            }
            else
            {
                VisOCConfirmadas visOCConfirmadas = new VisOCConfirmadas { MdiParent = this };
                visOCConfirmadas.Show();
            }
        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisAbonos"] != null)
            {
                Application.OpenForms["VisAbonos"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisAbonos"].Activate();
            }
            else
            {
                VisAbonos visAbonos = new VisAbonos { MdiParent = this };
                visAbonos.Show();
            }
        }

        private void presupuestoMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmReporteMaestro"] != null)
            {
                Application.OpenForms["frmReporteMaestro"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmReporteMaestro"].Activate();
            }
            else
            {
                frmReporteMaestro reporteMaestro = new frmReporteMaestro { MdiParent = this };
                reporteMaestro.Show();
            }
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisCxP"] != null)
            {
                Application.OpenForms["VisCxP"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisCxP"].Activate();
            }
            else
            {
                VisCxP visCxP = new VisCxP { MdiParent = this };
                visCxP.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VisProveedores"] != null)
            {
                Application.OpenForms["VisProveedores"].WindowState = FormWindowState.Normal;
                Application.OpenForms["VisProveedores"].Activate();
            }
            else
            {
                VisProveedores visProveedores = new VisProveedores { MdiParent = this };
                visProveedores.Show();
            }
        }

        private void SincronizarCODEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSyncTransCod"] != null)
            {
                Application.OpenForms["FrmSyncTransCod"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmSyncTransCod"].Activate();
            }
            else
            {
                FrmSyncTransCod syncTransCod = new FrmSyncTransCod { MdiParent = this };
                syncTransCod.Show();
            }
        }

        private void EnvíoDeEstCtaMasivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmEstadosDeCuenta"] != null)
            {
                Application.OpenForms["FrmEstadosDeCuenta"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmEstadosDeCuenta"].Activate();
            }
            else
            {
                FrmEstadosDeCuenta estadosDeCuenta = new FrmEstadosDeCuenta { MdiParent = this };
                estadosDeCuenta.Show();
            }
        }

        private void ConsultaDeAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBuscarAsociados"] != null)
            {
                Application.OpenForms["frmBuscarAsociados"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmBuscarAsociados"].Activate();
            }
            else
            {
                frmBuscarAsociados buscarAsociados = new frmBuscarAsociados() { MdiParent = this };
                buscarAsociados.Show();
            }
        }

        private void MenúCafeteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMenu"] != null)
            {
                Application.OpenForms["frmMenu"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmMenu"].Activate();
            }
            else
            {
                SAC.frmMenu menu = new SAC.frmMenu() { MdiParent = this };
                menu.Show();
            }
        }

        private void s03DetalleDeSubMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDetSubMenu"] != null)
            {
                Application.OpenForms["frmDetSubMenu"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmDetSubMenu"].Activate();
            }
            else
            {
                frmDetSubMenu detSubMenu = new frmDetSubMenu() { MdiParent = this };
                detSubMenu.Show();
            }
        }

        private void s04PermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmAsigPermisos"] != null)
            {
                Application.OpenForms["frmAsigPermisos"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmAsigPermisos"].Activate();
            }
            else
            {
                frmAsigPermisos asigPermisos = new frmAsigPermisos() { MdiParent = this };
                asigPermisos.Show();
            }
        }

        private void solicitudDePréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSolCred"] != null)
            {
                Application.OpenForms["FrmSolCred"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FrmSolCred"].Activate();
            }
            else
            {
                FrmSolCred solCred = new FrmSolCred(false, false, 0, 0, "", "") { MdiParent = this };
                solCred.Show();
            }
        }

        private void pR16AsignarCtasAMaterialesPrevioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAsigCtasMatPrev"] != null)
            {
                Application.OpenForms["frmAsigCtasMatPrev"].Activate();
            }
            else
            {
                frmAsigCtasMatPrev asigCtasMatPrev = new frmAsigCtasMatPrev { MdiParent = this };
                asigCtasMatPrev.Show();
            }
        }

        private void c01ConfFechasDeAmortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFechasCorte"] != null)
            {
                Application.OpenForms["frmFechasCorte"].Activate();
            }
            else
            {
                frmFechasCorte fechasCorte = new frmFechasCorte { MdiParent = this };
                fechasCorte.Show();
            }
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmInventario"] != null)
            {
                Application.OpenForms["frmInventario"].Activate();
            }
            else
            {
                frmInventario inventario = new frmInventario { MdiParent = this };
                inventario.Show();
            }
        }

        private void iNBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBodegas"] != null)
            {
                Application.OpenForms["frmBodegas"].Activate();
            }
            else
            {
                frmBodegas bodegas = new frmBodegas { MdiParent = this };
                bodegas.Show();
            }
        }

        private void iNTipoDeOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoOp"] != null)
            {
                Application.OpenForms["frmTipoOp"].Activate();
            }
            else
            {
                frmTipoOp tipoOp = new frmTipoOp { MdiParent = this };
                tipoOp.Show();
            }
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmVisorExistencias"] != null)
            {
                Application.OpenForms["frmVisorExistencias"].Activate();
            }
            else
            {
                frmVisorExistencias visorExistencias = new frmVisorExistencias { MdiParent = this };
                visorExistencias.Show();
            }
        }

        private void rTNClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmClientesRTN"] != null)
            {
                Application.OpenForms["frmClientesRTN"].Activate();
            }
            else
            {
                frmClientesRTN clientesRTN = new frmClientesRTN { MdiParent = this };
                clientesRTN.Show();
            }
        }

        private void digitarElEstadoDeCuentaDelBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDigitarEstadoCuentaBCO"] != null)
            {
                Application.OpenForms["frmDigitarEstadoCuentaBCO"].Activate();
            }
            else
            {
                frmDigitarEstadoCuentaBCO digitarEstadoCuentaBCO = new frmDigitarEstadoCuentaBCO { MdiParent = this };
                digitarEstadoCuentaBCO.Show();
            }
        }

        private void c02ConfEnvCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTrayNotifi"] != null)
            {
                Application.OpenForms["frmTrayNotifi"].Activate();
            }
            else
            {
                frmTrayNotifi trayNotifi = new frmTrayNotifi { MdiParent = this };
                trayNotifi.Show();
            }
        }

        private void controlDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmOrdenes"] != null)
            {
                Application.OpenForms["frmOrdenes"].Activate();
            }
            else
            {
                frmOrdenes ordenes = new frmOrdenes { MdiParent = this };
                ordenes.Show();
            }
        }

        private void visorDeLiquidacionesYRenunciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmVisorLiqudaciones"] != null)
            {
                Application.OpenForms["frmVisorLiqudaciones"].Activate();
            }
            else
            {
                frmVisorLiqudaciones visorLiqudaciones = new frmVisorLiqudaciones { MdiParent = this };
                visorLiqudaciones.Show();
            }
        }

        private void sincSalidasInventarioCodeasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmVisorInventarioSync"] != null)
            {
                Application.OpenForms["frmVisorInventarioSync"].Activate();
            }
            else
            {
                frmVisorInventarioSync visorInventarioSync = new frmVisorInventarioSync { MdiParent = this };
                visorInventarioSync.Show();
            }
        }

        private void correcionDeDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDevoluciones"] != null)
            {
                Application.OpenForms["frmDevoluciones"].Activate();
            }
            else
            {
                frmDevoluciones devoluciones = new frmDevoluciones { MdiParent = this };
                devoluciones.Show();
            }
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmVisorOrdenesSAC"] != null)
            {
                Application.OpenForms["frmVisorOrdenesSAC"].Activate();
            }
            else
            {
                frmVisorOrdenesSAC visorOrdenesSAC = new frmVisorOrdenesSAC { MdiParent = this };
                visorOrdenesSAC.Show();
            }
        }

        private void diferenciaDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDifImpuestos"] != null)
            {
                Application.OpenForms["frmDifImpuestos"].Activate();
            }
            else
            {
                frmDifImpuestos difImpuestos = new frmDifImpuestos { MdiParent = this };
                difImpuestos.Show();
            }
        }

        private void accionesDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAccionPersonalTrans"] != null)
            {
                Application.OpenForms["frmAccionPersonalTrans"].Activate();
            }
            else
            {
                frmAccionPersonalTrans accionPersonalTrans = new frmAccionPersonalTrans { MdiParent = this };
                accionPersonalTrans.Show();
            }
        }

        private void asistenciaMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAsistencias"] != null)
            {
                Application.OpenForms["frmAsistencias"].Activate();
            }
            else
            {
                frmAsistencias asistencias = new frmAsistencias { MdiParent = this };
                asistencias.Show();
            }
        }

        private void formalizacionDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFechasCorte"] != null)
            {
                Application.OpenForms["frmFechasCorte"].Activate();
            }
            else
            {
                frmFechasCorte fechasCorte = new frmFechasCorte { MdiParent = this };
                fechasCorte.Show();
            }
        }

        private void tarjetasDeRegaloYMembresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestiónDeTarjetasYPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTarjetas"] != null)
            {
                Application.OpenForms["frmTarjetas"].Activate();
            }
            else
            {
                frmTarjetas tarjetas = new frmTarjetas { MdiParent = this };
                tarjetas.Show();
            }
        }

        private void inscripciónDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroCliente"] != null)
            {
                Application.OpenForms["frmRegistroCliente"].Activate();
            }
            else
            {
                frmRegistroCliente registroCliente = new frmRegistroCliente { MdiParent = this };
                registroCliente.Show();
            }
        }

        private void centroDeCanjeDePremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCanjePremios"] != null)
            {
                Application.OpenForms["frmCanjePremios"].Activate();
            }
            else
            {
                frmCanjePremios canjePremios = new frmCanjePremios { MdiParent = this };
                canjePremios.Show();
            }
        }

        private void activarTarjetaDeRegaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmActivarTarjeta"] != null)
            {
                Application.OpenForms["frmActivarTarjeta"].Activate();
            }
            else
            {
                frmActivarTarjeta activarTarjeta = new frmActivarTarjeta { MdiParent = this };
                activarTarjeta.Show();
            }
        }

        private void anulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmAnulaciones"] != null)
            {
                Application.OpenForms["frmAnulaciones"].Activate();
            }
            else
            {
                frmAnulaciones anulaciones = new frmAnulaciones { MdiParent = this };
                anulaciones.Show();
            }
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSeguridad"] != null)
            {
                Application.OpenForms["frmSeguridad"].Activate();
            }
            else
            {
                frmSeguridad seguridad = new frmSeguridad { MdiParent = this };
                seguridad.Show();
            }
        }

        private void t11ActualizarTarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmActualizarTarifas"] != null)
            {
                Application.OpenForms["FrmActualizarTarifas"].Activate();
            }
            else
            {
                FrmActualizarTarifas actualizarTarifas = new FrmActualizarTarifas { MdiParent = this };
                actualizarTarifas.Show();
            }
        }
    }
}