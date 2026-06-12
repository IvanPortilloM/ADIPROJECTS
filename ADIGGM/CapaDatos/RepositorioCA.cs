using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Cuentas de Ahorro / IA (BD CA).
    /// Reemplaza al DataSet tipado DsCA de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioCA : RepositorioBase
    {
        public RepositorioCA() : base(Conexion.CA) { }

        // ===== Visores IA =====

        /// <summary>Movimientos de un producto/deducción del asociado (frmDetProducto).</summary>
        public DataTable CargarMovimientosProducto(string cidasociad, string ccoddeducc, string cnumdeducc)
        {
            return ConsultarTabla("dbo.USP_Sel_Cobros_CargarMovimientosProductos_Filter",
                new { CIDASOCIAD = cidasociad, CCODDEDUCC = ccoddeducc, CNUMDEDUCC = cnumdeducc },
                CommandType.StoredProcedure);
        }

        /// <summary>Movimientos aplicados de un crédito (frmDetCredito).</summary>
        public DataTable CargarMovimientosCredito(string cnumoperac)
        {
            return ConsultarTabla("dbo.CA_CreditosDetMovAplic", new { cnumoperac }, CommandType.StoredProcedure);
        }

        /// <summary>Plan de pagos del crédito filtrado por estado: "T"=tránsito, "P"=pendiente, "A"=aplicado.</summary>
        public DataTable CargarPlanCredito(string cnumoperac, string statusPlan, string usaDevengado = "N")
        {
            return ConsultarTabla("dbo.USP_Sel_Cobros_ConsUsuPlanCred_Filter",
                new { prmCnumoperac = cnumoperac, prmCstatuspla = statusPlan, prmCusaDeveng = usaDevengado },
                CommandType.StoredProcedure);
        }

        /// <summary>Búsqueda de asociados (frmBuscarAsociados).</summary>
        public DataTable BuscarAsociados(string texto, string ordenBusqueda, string operador, int numRegistros)
        {
            return ConsultarTabla("dbo.CA_BuscarAsoc",
                new { texto, ordenBusq = ordenBusqueda, operador, numreg = numRegistros },
                CommandType.StoredProcedure);
        }

        /// <summary>Carnets de asociados pendientes de imprimir (la ruta UNC de fotos la consume el SP).</summary>
        public DataTable CargarCarnetsImprimir(string rutaFotos)
        {
            return ConsultarTabla("dbo.CA_CarnetsAsocImp", new { url = rutaFotos }, CommandType.StoredProcedure);
        }

        /// <summary>Marca un carnet como exportado/impreso.</summary>
        public void MarcarCarnetExportado(int nconsecarn)
        {
            Ejecutar("dbo.CA_CarnetsAsocImpExpor", new { nconsecarn }, CommandType.StoredProcedure);
        }

        /// <summary>Puntos contables (combo de Herramientas\frmDevoluciones).</summary>
        public DataTable ListarPuntos()
        {
            return ConsultarTabla("SELECT IdPunto, NombrePunto FROM CC_Puntos");
        }

        // ===== Información del asociado (frmInformacionAsoc) =====

        /// <summary>Productos/aportes del asociado (@mostrar filtra solo con saldo).</summary>
        public DataTable CargarAportes(string cidasociad, bool soloConSaldo)
        {
            return ConsultarTabla("dbo.CA_Aportes", new { cidasociad, mostrar = soloConSaldo }, CommandType.StoredProcedure);
        }

        /// <summary>Créditos del asociado (@mostrar filtra solo con saldo).</summary>
        public DataTable CargarCreditos(string cidasociad, bool soloConSaldo)
        {
            DataTable tabla = ConsultarTabla("dbo.CA_Creditos", new { cidasociad, mostrar = soloConSaldo }, CommandType.StoredProcedure);
            foreach (DataColumn col in tabla.Columns)
                col.ReadOnly = false; // el form escribe Transito/Pendientes en el grid
            return tabla;
        }

        public DataTable CargarAutorizadosCredito(string cidasociad)
        {
            return ConsultarTabla("dbo.CA_AutorizadosCreditoAsocSel", new { cidasociad }, CommandType.StoredProcedure);
        }

        /// <summary>Valida personas autorizadas (0/1/2/3 según existencia y estado).</summary>
        public int ValidarAutorizadoCredito(string cidasociad, string cidautoriz, bool insUpd)
        {
            return Escalar<int>("dbo.CA_AutorizadosCreditoAsocValidar",
                new { cidasociad, cidautoriz, insUpd }, CommandType.StoredProcedure);
        }

        public void InsertarAutorizadoCredito(string cidasociad, string cidautoriz, string cparentezc,
            string cnombreaut, string cdomicilio, string cnumtelefo, string crutaimage)
        {
            Ejecutar("dbo.CA_AutorizadosCreditoAsocInsert",
                new { cidasociad, cidautoriz, cparentezc, cnombreaut, cdomicilio, cnumtelefo, crutaimage },
                CommandType.StoredProcedure);
        }

        public void ActualizarAutorizadoCredito(string cidasociad, string cidautoriz, string cparentezc,
            bool bestaactiv, string cnombreaut, string cdomicilio, string cnumtelefo, string crutaimage, bool bloqDesbloq)
        {
            Ejecutar("dbo.CA_AutorizadosCreditoAsocUpdate",
                new { cidasociad, cidautoriz, cparentezc, bestaactiv, cnombreaut, cdomicilio, cnumtelefo, crutaimage, bloqDesbloq },
                CommandType.StoredProcedure);
        }

        /// <summary>Estado del carnet/PIN del asociado (código 0..8 que gobierna el panel del PIN).</summary>
        public int ValidarCarnetAsociado(string cidasociad, string pin)
        {
            return Escalar<int>("dbo.CA_CarnetsAsocValidar",
                new { cidasociad, ccodigopin = pin }, CommandType.StoredProcedure);
        }

        /// <summary>Crea el carnet/PIN del asociado. Devuelve 0 si se guardó; distinto de 0 si el PIN ya existe.</summary>
        public int InsertarCarnetAsociado(string cidasociad, string ccodigopin, string cnombreaso, string cnombinsti,
            string cnombdivis, System.DateTime ffechexped, System.DateTime ffechvalid, string crutaimage)
        {
            return System.Convert.ToInt32(Escalar<object>("dbo.CA_CarnetsAsocInsert",
                new { cidasociad, ccodigopin, cnombreaso, cnombinsti, cnombdivis, ffechexped, ffechvalid, crutaimage },
                CommandType.StoredProcedure));
        }

        /// <summary>Renueva/reporta/activa/desactiva el carnet del asociado según los flags.</summary>
        public void ActualizarCarnetAsociado(string cidasociad, string ccodigopin, string ccodpinNue, string cnombreaso,
            string cnombinsti, string cnombdivis, System.DateTime ffechvalid, bool breportado, bool breimprime, bool bdesactiva)
        {
            Ejecutar("dbo.CA_CarnetsAsocUpdate",
                new { cidasociad, ccodigopin, ccodpinNue, cnombreaso, cnombinsti, cnombdivis, ffechvalid, breportado, breimprime, bdesactiva },
                CommandType.StoredProcedure);
        }

        /// <summary>Observación/descripción de un asiento (frmObsProducto).</summary>
        public string ObtenerObservacionAsiento(string prmCnumasient, string prmCtipasient)
        {
            return Escalar<string>("dbo.USP_Sel_Carga_Desc_Asie_Filter",
                new { PrmCnumasient = prmCnumasient, PrmCtipasient = prmCtipasient },
                CommandType.StoredProcedure) ?? "";
        }

        // Parámetros OUTPUT del SP CA_CarnetsAsocSel, en el orden del SP.
        private static readonly KeyValuePair<string, int>[] _salidasCarnet =
        {
            new KeyValuePair<string, int>("ccodigopinOUT", 4), new KeyValuePair<string, int>("cnombreaso", 50),
            new KeyValuePair<string, int>("cnombinsti", 30), new KeyValuePair<string, int>("cnombdivis", 30),
            new KeyValuePair<string, int>("ffechexped", 15), new KeyValuePair<string, int>("ffechvalid", 15)
        };

        /// <summary>Datos del carnet del asociado (SP con 6 OUTPUT) como diccionario nombreParametro -> valor.</summary>
        public Dictionary<string, string> ConsultarCarnetAsociado(string cidasociad, string pin, bool estaActivo)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("cidasociad", cidasociad);
            p.Add("ccodigopin", pin);
            p.Add("bestaactiv", estaActivo);
            foreach (KeyValuePair<string, int> salida in _salidasCarnet)
                p.Add(salida.Key, "", DbType.String, ParameterDirection.InputOutput, salida.Value);

            using (DbConnection con = CrearConexion())
            {
                con.Open();
                con.Execute("dbo.CA_CarnetsAsocSel", p, commandType: CommandType.StoredProcedure);
            }

            Dictionary<string, string> resultado = new Dictionary<string, string>();
            foreach (KeyValuePair<string, int> salida in _salidasCarnet)
                resultado[salida.Key] = p.Get<string>(salida.Key) ?? "";
            return resultado;
        }

        // Parámetros OUTPUT del SP CA_HeaderAsoc, en el orden del SP.
        private static readonly KeyValuePair<string, int>[] _salidasHeaderAsociado =
        {
            new KeyValuePair<string, int>("cidasociadOut", 15), new KeyValuePair<string, int>("ccedulasoc", 15),
            new KeyValuePair<string, int>("cnombreaso", 50), new KeyValuePair<string, int>("dfechainga", 10),
            new KeyValuePair<string, int>("dfechasali", 10), new KeyValuePair<string, int>("cnombconda", 15),
            new KeyValuePair<string, int>("cnombinsti", 30), new KeyValuePair<string, int>("cnombdepto", 20),
            new KeyValuePair<string, int>("cnombdivis", 25), new KeyValuePair<string, int>("cnombtipop", 30),
            new KeyValuePair<string, int>("cteletraba", 30), new KeyValuePair<string, int>("ctelecelul", 30),
            new KeyValuePair<string, int>("cextentrab", 30), new KeyValuePair<string, int>("cteledomic", 30),
            new KeyValuePair<string, int>("cdireccaso", 30), new KeyValuePair<string, int>("dfechanaci", 10),
            new KeyValuePair<string, int>("nsalarioas", 10), new KeyValuePair<string, int>("nsalarione", 10),
            new KeyValuePair<string, int>("cmuestclav", 10), new KeyValuePair<string, int>("dfechaingc", 10),
            new KeyValuePair<string, int>("cconoccomo", 50), new KeyValuePair<string, int>("cemailasoc", 20),
            new KeyValuePair<string, int>("anio", 5), new KeyValuePair<string, int>("mes", 5),
            new KeyValuePair<string, int>("dia", 5), new KeyValuePair<string, int>("cnombrecom", 20),
            new KeyValuePair<string, int>("ccoddelega", 20), new KeyValuePair<string, int>("cnombredel", 20),
            new KeyValuePair<string, int>("cnombinstb", 20), new KeyValuePair<string, int>("cctabancas", 15)
        };

        /// <summary>Encabezado del asociado (SP CA_HeaderAsoc con 30 OUTPUT) como diccionario nombreParametro -> valor.</summary>
        public Dictionary<string, string> ConsultarHeaderAsociado(string cidasociad)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("cidasociad", cidasociad);
            foreach (KeyValuePair<string, int> salida in _salidasHeaderAsociado)
                p.Add(salida.Key, "", DbType.String, ParameterDirection.InputOutput, salida.Value);

            using (DbConnection con = CrearConexion())
            {
                con.Open();
                con.Execute("dbo.CA_HeaderAsoc", p, commandType: CommandType.StoredProcedure);
            }

            Dictionary<string, string> resultado = new Dictionary<string, string>();
            foreach (KeyValuePair<string, int> salida in _salidasHeaderAsociado)
                resultado[salida.Key] = p.Get<string>(salida.Key) ?? "";
            return resultado;
        }

        // ===== Menú del comedor (SAC\frmMenu; tablas CF_*) =====

        /// <summary>Platos del menú para un tiempo de comida (Desayuno/Almuerzo/Bocadillos). Editable en grilla.</summary>
        public DataTable CargarMenuComedor(string tiempoComida)
        {
            const string sql = @"SELECT CF_Menu.bestaactiv, CF_Menu.cnomcomida, CF_Menu.dfechacrea, CF_Menu.nconsemenu, CF_Menu.nnumdiasem, CF_Menu.nnumtiempo
FROM CF_Menu INNER JOIN CF_TiempoCom ON CF_Menu.nnumtiempo = CF_TiempoCom.nnumtiempo
WHERE CF_TiempoCom.ctiempocom = @ctiempocom";
            DataTable tabla = ConsultarTabla(sql, new { ctiempocom = tiempoComida });
            foreach (DataColumn col in tabla.Columns)
                col.ReadOnly = false; // la grilla edita estas columnas (gotcha DataTable.Load)
            return tabla;
        }

        /// <summary>Tiempos de comida para la columna combo de la grilla (sin la imagen varbinary).</summary>
        public DataTable ListarTiemposComida()
        {
            return ConsultarTabla("SELECT nnumtiempo, ctiempocom FROM CF_TiempoCom");
        }

        public DataTable ListarDiasSemana()
        {
            return ConsultarTabla("SELECT nnumdiasem, cnomdiasem FROM CF_DiasSem");
        }

        /// <summary>Imágenes Desayuno/Almuerzo/Bocadillos para el reporte RDLC.</summary>
        public DataTable ListarImagenesMenu()
        {
            return ConsultarTabla("dbo.CF_ImgenMenu", null, CommandType.StoredProcedure);
        }

        /// <summary>Menú consolidado del tiempo de comida para el reporte RDLC.</summary>
        public DataTable CargarMenuReporte(string tiempoComida)
        {
            return ConsultarTabla("dbo.CF_SelectMenu", new { ctiempocom = tiempoComida }, CommandType.StoredProcedure);
        }

        /// <summary>Imagen del tiempo de comida (NULL si no tiene).</summary>
        public byte[] ObtenerImagenTiempoComida(string tiempoComida)
        {
            return Escalar<byte[]>("dbo.CF_ImgTiempoCom", new { ctiempocom = tiempoComida }, CommandType.StoredProcedure);
        }

        public void ActualizarImagenTiempoComida(string tiempoComida, byte[] imagen)
        {
            Ejecutar("dbo.CF_TiempoCom_UPD", new { ctiempocom = tiempoComida, imagen }, CommandType.StoredProcedure);
        }

        /// <summary>Actualiza los platos del menú en UNA transacción (antes era fila por fila sin protección).</summary>
        public void ActualizarMenuComedor(IEnumerable<(int Consecutivo, string Comida, System.DateTime Fecha, bool Activo)> filas)
        {
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach ((int consecutivo, string comida, System.DateTime fecha, bool activo) in filas)
                        {
                            con.Execute("dbo.CF_Menu_UPD",
                                new { nconsemenu = consecutivo, cnomcomida = comida, dfechacrea = fecha, bestaactiv = activo },
                                trans, commandType: CommandType.StoredProcedure);
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        // Parámetros OUTPUT (nombre, tamaño) del SP USP_Sel_Cobros_ConsUsuCredAsoc_Filter, en el orden del SP.
        private static readonly KeyValuePair<string, int>[] _salidasDetalleCredito =
        {
            new KeyValuePair<string, int>("cnumoperac", 20), new KeyValuePair<string, int>("dfechaform", 24),
            new KeyValuePair<string, int>("nmontoapro", 12), new KeyValuePair<string, int>("nsaldocred", 12),
            new KeyValuePair<string, int>("nprincapro", 12), new KeyValuePair<string, int>("ncuotapres", 12),
            new KeyValuePair<string, int>("ntasainter", 5), new KeyValuePair<string, int>("ninteremor", 12),
            new KeyValuePair<string, int>("npagosefec", 6), new KeyValuePair<string, int>("dfeproxabo", 10),
            new KeyValuePair<string, int>("nfrecupago", 5), new KeyValuePair<string, int>("cformapago", 5),
            new KeyValuePair<string, int>("dfeculabon", 10), new KeyValuePair<string, int>("dfecalcint", 10),
            new KeyValuePair<string, int>("ctipotrans", 5), new KeyValuePair<string, int>("cnumdocume", 20),
            new KeyValuePair<string, int>("ccodigocat", 20), new KeyValuePair<string, int>("ccodigousu", 15),
            new KeyValuePair<string, int>("ccodigousu2", 15), new KeyValuePair<string, int>("ctipasient", 5),
            new KeyValuePair<string, int>("cnumasient", 15), new KeyValuePair<string, int>("cibloquear", 5),
            new KeyValuePair<string, int>("cnumsolici", 15), new KeyValuePair<string, int>("cdetalleli", 50),
            new KeyValuePair<string, int>("nporcdescu", 12), new KeyValuePair<string, int>("npergracia", 12),
            new KeyValuePair<string, int>("cdetastatu", 15), new KeyValuePair<string, int>("dfepagreal", 10),
            new KeyValuePair<string, int>("nnumcuotas", 6), new KeyValuePair<string, int>("naplcancre", 12),
            new KeyValuePair<string, int>("cbascancre", 5), new KeyValuePair<string, int>("pendientes", 12),
            new KeyValuePair<string, int>("transito", 12), new KeyValuePair<string, int>("ccuotacrec", 6),
            new KeyValuePair<string, int>("ccomentari", 100), new KeyValuePair<string, int>("cdetactivi", 20),
            new KeyValuePair<string, int>("dfecultinc", 24), new KeyValuePair<string, int>("cnumsesion", 20),
            new KeyValuePair<string, int>("dfeprimabo", 10)
        };

        /// <summary>
        /// Encabezado/detalle de un crédito del asociado. El SP devuelve 39 parámetros OUTPUT
        /// (todos nvarchar); se exponen como diccionario nombreParametro -> valor ("" si NULL).
        /// </summary>
        public Dictionary<string, string> ConsultarDetalleCredito(string cnumoperac, string cidasociad)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("prmCnumoperac", cnumoperac);
            p.Add("prmCidasociad", cidasociad);
            foreach (KeyValuePair<string, int> salida in _salidasDetalleCredito)
                p.Add(salida.Key, "", DbType.String, ParameterDirection.InputOutput, salida.Value);

            using (DbConnection con = CrearConexion())
            {
                con.Open();
                con.Execute("dbo.USP_Sel_Cobros_ConsUsuCredAsoc_Filter", p, commandType: CommandType.StoredProcedure);
            }

            Dictionary<string, string> resultado = new Dictionary<string, string>();
            foreach (KeyValuePair<string, int> salida in _salidasDetalleCredito)
                resultado[salida.Key] = p.Get<string>(salida.Key) ?? "";
            return resultado;
        }
    }
}
