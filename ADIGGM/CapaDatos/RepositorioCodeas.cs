using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de las consultas que vivían en el DataSet tipado DsCodeasAdiggm
    /// (conexión TransporteAdiggm; varias consultas cruzan a covibase con nombre calificado).
    /// Se completa de forma incremental al migrar cada formulario.
    /// </summary>
    public class RepositorioCodeas : RepositorioBase
    {
        public RepositorioCodeas() : base(Conexion.TRANSPORTE) { }

        // ===== Sincronización Transporte -> CODEAS (Mant\FrmSyncTransCod) =====

        /// <summary>Asiento contable propuesto para sincronizar un cierre a CODEAS (SP PR_SyncTransCod).</summary>
        public DataTable ListarSyncTransCod(int idCierre, int idCliente, int idTipoFactura, string numDoc, string numDocABV, string detalle)
        {
            return ConsultarTabla("dbo.PR_SyncTransCod",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoFactura = idTipoFactura, NumDoc = numDoc, NumDocABV = numDocABV, Detalle = detalle },
                CommandType.StoredProcedure);
        }

        /// <summary>Tipos de asiento de CODEAS (SP COD_SlcTipoAsiento) para el combo.</summary>
        public DataTable ListarTipoAsiento()
        {
            return ConsultarTabla("dbo.COD_SlcTipoAsiento", null, CommandType.StoredProcedure);
        }

        // (VerificarCuentaContable ya existe abajo — covibase.dbo.cocatalogo — se reutiliza.)

        /// <summary>Guarda la sincronización del cierre hacia CODEAS (SP PR_SyncTransCodGuardar).</summary>
        public int GuardarSyncTransCod(int idCierre, int idCliente, int idTipoFactura, string numDoc, string numDocABV,
            string detalle, string numAsiento, DateTime fechaAsiento, string usuario)
        {
            return Ejecutar("dbo.PR_SyncTransCodGuardar",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoFactura = idTipoFactura, NumDoc = numDoc, NumDocABV = numDocABV,
                      Detalle = detalle, cnumasient = numAsiento, dfechaasie = fechaAsiento, cusuariosi = usuario },
                CommandType.StoredProcedure);
        }

        // ===== Estado de cuenta del asociado (reporte rptASMaestra) =====

        public DataTable CargarASMaestras(string identidad)
        {
            return ConsultarTabla("dbo.COD_SlcASMaestras", new { Identidad = identidad }, CommandType.StoredProcedure);
        }

        public DataTable CargarEstadoCuenta(string identidad)
        {
            return ConsultarTabla("dbo.COD_SlcEstadoCuenta", new { Identidad = identidad }, CommandType.StoredProcedure);
        }

        public DataTable CargarEstadoCuentaDet(string cidasociad)
        {
            return ConsultarTabla("dbo.COD_SlcEstadoCuentaDet", new { cidasociad }, CommandType.StoredProcedure);
        }

        /// <summary>Búsqueda de asociados por nombre/identificación para el diálogo de selección
        /// (SP COD_ASMaestras, @Asociado = texto de búsqueda; cadena vacía = todos). SAC\FrmAsocBuscar.</summary>
        public DataTable BuscarAsociados(string asociado)
        {
            return ConsultarTabla("dbo.COD_ASMaestras", new { Asociado = asociado }, CommandType.StoredProcedure);
        }

        // ===== Envío de estados de cuenta (Mantenimiento\FrmEstadosDeCuenta) =====

        /// <summary>Divisiones para el combo maestro (filtra la lista de correos por IdDivision).</summary>
        public DataTable ListarDivisiones()
        {
            return ConsultarTabla("SELECT IdDivision, NombreDiv, Activo FROM dbo.COD_Divisiones");
        }

        /// <summary>Lista de correos de asociados (grid hijo del combo de divisiones).</summary>
        public DataTable ListarListaCorreos()
        {
            return ConsultarTabla("SELECT IdAsociado, Identidad, Nombres, Correo, IdDivision, Activo FROM dbo.COD_ListaCorreos");
        }

        /// <summary>Persiste altas/cambios/bajas de la lista de correos (IdAsociado = identity, no va en INSERT).</summary>
        public int GuardarListaCorreos(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.COD_ListaCorreos (Identidad, Nombres, Correo, IdDivision, Activo) VALUES (@Identidad, @Nombres, @Correo, @IdDivision, @Activo)",
                "UPDATE dbo.COD_ListaCorreos SET Identidad=@Identidad, Nombres=@Nombres, Correo=@Correo, IdDivision=@IdDivision, Activo=@Activo WHERE IdAsociado=@IdAsociado",
                "DELETE FROM dbo.COD_ListaCorreos WHERE IdAsociado=@IdAsociado",
                "dbo.COD_ListaCorreos", "IdAsociado");
        }

        // ===== Solicitudes de crédito (SAC\FrmSolCred) =====

        /// <summary>Aportes/productos del asociado en Codeas (SP COD_SlcAportes).</summary>
        public DataTable CargarAportesAsociado(string identidad)
        {
            return ConsultarTabla("dbo.COD_SlcAportes", new { Identidad = identidad }, CommandType.StoredProcedure);
        }

        /// <summary>Créditos del asociado en Codeas (SP COD_SlcCreditos). Editable: el form escribe Transito/Pendientes.</summary>
        public DataTable CargarCreditosAsociado(string identidad)
        {
            DataTable tabla = ConsultarTabla("dbo.COD_SlcCreditos", new { Identidad = identidad }, CommandType.StoredProcedure);
            foreach (DataColumn col in tabla.Columns)
                col.ReadOnly = false;
            return tabla;
        }

        public DataTable CargarAsociadoPorCodigo(string codigoAsociado)
        {
            const string sql = "SELECT AreaTrabajo, CodigoAsociado, Domicilio, EstadoCivil, IdAsociado, Identidad, NombreCompleto, Telefono, TipoEmpleado FROM SAC_Asociados WHERE CodigoAsociado = @CodigoAsociado";
            return ConsultarTabla(sql, new { CodigoAsociado = codigoAsociado });
        }

        public DataTable CargarAsociadoPorId(int idAsociado)
        {
            const string sql = "SELECT AreaTrabajo, CodigoAsociado, Domicilio, EstadoCivil, IdAsociado, Identidad, NombreCompleto, Telefono, TipoEmpleado FROM SAC_Asociados WHERE IdAsociado = @IdAsociado";
            return ConsultarTabla(sql, new { IdAsociado = idAsociado });
        }

        public DataTable CargarSolicitud(int idSolicitud)
        {
            const string sql = @"SELECT IdSolicitud, IdAsociado, Aporte, Credito, FechaSolicitud, CantSolicitada, CantSolicitadaLTR, CantConsumo, CantAprobada, Cuota, CuotaLTR, Periodo, PeriodoSug, Tasa, Capitalizacion, Motivo, Anios, Meses, Dias, Aprobado, Anulado, FechaAprobacion, Dependencia, TipoSolicitud, dfecformal, dfecpripag, nfrecupago, Usuario
FROM SAC_Solicitudes WHERE IdSolicitud = @IdSolicitud";
            return ConsultarTabla(sql, new { IdSolicitud = idSolicitud });
        }

        /// <summary>Estado financiero guardado de una solicitud (todas las líneas).</summary>
        public DataTable CargarEstadoFinanciero(int idSolicitud)
        {
            const string sql = @"SELECT IdEstadoFinanciero, IdSolicitud, Operacion, Principal, Saldo, Cuota, Tasa, Pagos, N_Cuotas, Descripci, Grupo, Des_Grupo, Fecha_Mov, CodGestion, DetGestion, ColorGestion, Ccomentari, Seleccionado
FROM SAC_EstadoFinanciero WHERE IdSolicitud = @IdSolicitud";
            return ConsultarTabla(sql, new { IdSolicitud = idSolicitud });
        }

        /// <summary>Líneas patrimoniales (aportes) del estado financiero guardado. Editable en grilla.</summary>
        public DataTable CargarEstadoFinancieroAportes(int idSolicitud)
        {
            const string sql = @"SELECT IdEstadoFinanciero, IdSolicitud, Operacion, Principal, Saldo, Cuota, Tasa, Pagos, N_Cuotas, Descripci, Grupo, Des_Grupo, Fecha_Mov, CodGestion, DetGestion, ColorGestion, Ccomentari, Seleccionado
FROM SAC_EstadoFinanciero WHERE Des_Grupo = 'PATRIMONIALES' AND IdSolicitud = @IdSolicitud";
            return ConsultarTabla(sql, new { IdSolicitud = idSolicitud });
        }

        /// <summary>Líneas de crédito del estado financiero guardado. Editable: el form escribe Transito1/Pendientes1.</summary>
        public DataTable CargarEstadoFinancieroCreditos(int idSolicitud)
        {
            const string sql = @"SELECT IdEstadoFinanciero, IdSolicitud, Operacion, Principal, Saldo, Cuota, Tasa, Pagos, N_Cuotas, Descripci, Grupo, Des_Grupo, Fecha_Mov, CodGestion, DetGestion, ColorGestion, Ccomentari, Seleccionado
FROM SAC_EstadoFinanciero WHERE Des_Grupo = 'CREDITOS' AND IdSolicitud = @IdSolicitud";
            DataTable tabla = ConsultarTabla(sql, new { IdSolicitud = idSolicitud });
            foreach (DataColumn col in tabla.Columns)
                col.ReadOnly = false;
            return tabla;
        }

        public DataTable CargarAmortizaciones(int idSolicitud)
        {
            const string sql = "SELECT Capital, IdAmortizacion, IdSolicitud, Interes, NumCuota, Pago, Saldo, dfechapago FROM SAC_Amortizaciones WHERE IdSolicitud = @IdSolicitud";
            return ConsultarTabla(sql, new { IdSolicitud = idSolicitud });
        }

        // ===== Visor de préstamos (Visores\FrmVisorPrestamos) =====

        /// <summary>Solicitudes filtradas del visor (SP SAC_SolicitudesVisor). Los flags Por* eligen el
        /// criterio (código / rango de fechas / rango de N° solicitud) dentro del SP.</summary>
        public DataTable BuscarSolicitudesVisor(string codigo, DateTime fechaDesde, DateTime fechaHasta,
            int solicitudDesde, int solicitudHasta, bool porCodigo, bool porFecha, bool porNSol, string dependencia)
        {
            return ConsultarTabla("dbo.SAC_SolicitudesVisor", new
            {
                Codigo = codigo, FechaDesde = fechaDesde, FechaHasta = fechaHasta,
                SolicitudDesde = solicitudDesde, solicitudHasta = solicitudHasta,
                PorCodigo = porCodigo, PorFecha = porFecha, PorNSol = porNSol, Dependencia = dependencia
            }, CommandType.StoredProcedure);
        }

        /// <summary>Reporte de solicitudes para exportar a Excel (SP PR_R_Solicitudes, mismos filtros).</summary>
        public DataTable ReporteSolicitudes(string codigo, DateTime fechaDesde, DateTime fechaHasta,
            int solicitudDesde, int solicitudHasta, bool porCodigo, bool porFecha, bool porNSol, string dependencia)
        {
            return ConsultarTabla("dbo.PR_R_Solicitudes", new
            {
                Codigo = codigo, FechaDesde = fechaDesde, FechaHasta = fechaHasta,
                SolicitudDesde = solicitudDesde, solicitudHasta = solicitudHasta,
                PorCodigo = porCodigo, PorFecha = porFecha, PorNSol = porNSol, Dependencia = dependencia
            }, CommandType.StoredProcedure);
        }

        /// <summary>Aprueba (aprobar=1) o reversa (0) una solicitud (SP SAC_SolicitudesAprobar).</summary>
        public int AprobarSolicitud(int idSolicitud, int aprobar)
        {
            return Ejecutar("dbo.SAC_SolicitudesAprobar", new { IdSolicitud = idSolicitud, Aprobar = aprobar }, CommandType.StoredProcedure);
        }

        /// <summary>Anula (anular=1) o reversa (0) una solicitud (SP SAC_SolicitudesAnular).</summary>
        public int AnularSolicitud(int idSolicitud, int anular)
        {
            return Ejecutar("dbo.SAC_SolicitudesAnular", new { IdSolicitud = idSolicitud, Anular = anular }, CommandType.StoredProcedure);
        }

        // ===== Visor de órdenes SAC (SAC\Visores\frmVisorOrdenesSAC) =====

        /// <summary>Órdenes SAC del visor, filtradas por texto (el SP SAC_BuscarAsoc decide el campo de
        /// búsqueda con @ordenBusq y la comparación con @operador).</summary>
        public DataTable BuscarOrdenesSac(string texto, string ordenBusqueda, string operador)
        {
            return ConsultarTabla("dbo.SAC_BuscarAsoc",
                new { texto, ordenBusq = ordenBusqueda, operador },
                CommandType.StoredProcedure);
        }

        public DataTable ListarFechasCorteActivas()
        {
            const string sql = @"SELECT ncodfecort, dfechforma, dfecpripag, cperiodpag, bestaactiv
FROM SAC_FechasCorte WHERE bestaactiv = 1 ORDER BY dfechforma DESC";
            return ConsultarTabla(sql);
        }

        /// <summary>0 = no existe; 1 = existe en SAC; 2 = existe solo en Codeas.</summary>
        public int ExisteAsociado(string codAsociado)
        {
            return Escalar<int>("dbo.SAC_AsocExiste", new { CodAsociado = codAsociado }, CommandType.StoredProcedure);
        }

        /// <summary>Inserta/actualiza el asociado y devuelve su IdAsociado.</summary>
        public int InsertarAsociado(string codigoAsociado, string identidad, string nombreCompleto, string areaTrabajo,
            string domicilio, string estadoCivil, string tipoEmpleado, string telefono)
        {
            return Convert.ToInt32(Escalar<object>("dbo.SAC_AsociadosInsert", new
            {
                CodigoAsociado = codigoAsociado,
                Identidad = identidad,
                NombreCompleto = nombreCompleto,
                AreaTrabajo = areaTrabajo,
                Domicilio = domicilio,
                EstadoCivil = estadoCivil,
                TipoEmpleado = tipoEmpleado,
                Telefono = telefono
            }, CommandType.StoredProcedure));
        }

        /// <summary>Inserta/actualiza la solicitud (SP SAC_SolicitudesInsert_v2) y devuelve su IdSolicitud.</summary>
        public int InsertarSolicitud(int idAsociado, int idSolicitud, decimal aporte, decimal credito,
            DateTime fechaSolicitud, decimal cantSolicitada, string cantSolicitadaLtr, decimal cantConsumo,
            decimal cantAprobada, decimal cuota, string cuotaLtr, int periodo, int periodoSug, decimal tasa,
            int capitalizacion, string motivo, int anios, int meses, int dias, string dependencia,
            string tipoSolicitud, DateTime fechaFormalizacion, DateTime fechaPrimerPago, int frecuenciaPago, string usuario)
        {
            return Convert.ToInt32(Escalar<object>("dbo.SAC_SolicitudesInsert_v2", new
            {
                IdAsociado = idAsociado,
                IdSolicitud = idSolicitud,
                Aporte = aporte,
                Credito = credito,
                FechaSolicitud = fechaSolicitud,
                CantSolicitada = cantSolicitada,
                CantSolicitadaLTR = cantSolicitadaLtr,
                CantConsumo = cantConsumo,
                CantAprobada = cantAprobada,
                Cuota = cuota,
                CuotaLTR = cuotaLtr,
                Periodo = periodo,
                PeriodoSug = periodoSug,
                Tasa = tasa,
                Capitalizacion = capitalizacion,
                Motivo = motivo,
                Anios = anios,
                Meses = meses,
                Dias = dias,
                Dependencia = dependencia,
                TipoSolicitud = tipoSolicitud,
                dfecformal = fechaFormalizacion,
                dfecpripag = fechaPrimerPago,
                nfrecupago = frecuenciaPago,
                Usuario = usuario
            }, CommandType.StoredProcedure));
        }

        public void GenerarTablaAmortizacion(double prestamo, int periodos, int capitalizacion, double tasa, int idSolicitud)
        {
            Ejecutar("dbo.SAC_TablaAmortizacion", new
            {
                Prestamo = prestamo,
                Periodos = periodos,
                Capitalizacion = capitalizacion,
                Tasa = tasa,
                IdSolicitud = idSolicitud
            }, CommandType.StoredProcedure);
        }

        public void InsertarEstadoFinanciero(int idSolicitud, string operacion, decimal principal, decimal saldo,
            decimal cuota, int tasa, int pagos, int numCuotas, string descripcion, string grupo, string desGrupo,
            DateTime fechaMov, string codGestion, string detGestion, int colorGestion, string comentario, bool seleccionado)
        {
            Ejecutar("dbo.SAC_EstadoFinancieroInsert", new
            {
                IdSolicitud = idSolicitud,
                Operacion = operacion,
                Principal = principal,
                Saldo = saldo,
                Cuota = cuota,
                Tasa = tasa,
                Pagos = pagos,
                N_Cuotas = numCuotas,
                Descripci = descripcion,
                Grupo = grupo,
                Des_Grupo = desGrupo,
                Fecha_Mov = fechaMov,
                CodGestion = codGestion,
                DetGestion = detGestion,
                ColorGestion = colorGestion,
                Ccomentari = comentario,
                Seleccionado = seleccionado
            }, CommandType.StoredProcedure);
        }

        public decimal TotalCreditosAsociado(string identidad)
        {
            return Convert.ToDecimal(Escalar<object>("dbo.COD_SlcTotalCreditos",
                new { Identidad = identidad }, CommandType.StoredProcedure));
        }

        /// <summary>Encabezado de una fecha de corte (SP con 5 OUTPUT) como diccionario nombreParametro -> valor.</summary>
        public Dictionary<string, string> ConsultarFechaCorte(int ncodfecort)
        {
            string[] salidas = { "ncodfecortOUT", "dfechforma", "dfecpripag", "cperiodpag", "bestaactiv" };

            DynamicParameters p = new DynamicParameters();
            p.Add("ncodfecort", ncodfecort);
            foreach (string salida in salidas)
                p.Add(salida, "", DbType.String, ParameterDirection.InputOutput, 50);

            using (DbConnection con = CrearConexion())
            {
                con.Open();
                con.Execute("dbo.SAC_FechasCorteHeader", p, commandType: CommandType.StoredProcedure);
            }

            Dictionary<string, string> resultado = new Dictionary<string, string>();
            foreach (string salida in salidas)
                resultado[salida] = p.Get<string>(salida) ?? "";
            return resultado;
        }

        /// <summary>1 si la cuenta contable existe como auxiliar en el catálogo de covibase; 0 si no.</summary>
        public int VerificarCuentaContable(string cuentaContable)
        {
            const string sql = @"SELECT COUNT(ccuentacon) AS Existe
FROM covibase.dbo.cocatalogo
WHERE ccuentacon = @ccuentacon AND cauxiliarc = 'S'";
            return Escalar<int>(sql, new { ccuentacon = cuentaContable });
        }
    }
}
