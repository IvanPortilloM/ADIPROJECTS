# CONTEXTO — Refactor de acceso a datos (ADIGGM)

> Documento de handoff para continuar el refactor en una sesión nueva de Claude Code.
> Para retomar: pídele al agente **"Lee CONTEXTO-REFACTOR.md y continúa con la tarea inmediata"**.

## 0. Directiva de eficiencia (GASTAR POCOS TOKENS — prioridad)
- Responde **breve**, sin preámbulos ni repetir el plan; ve directo a la acción.
- Lee SOLO lo necesario: usa **Grep/Glob** para ubicar y **Read con offset/limit** en regiones puntuales. NO leas archivos completos ni los releas; NO re-leas un archivo que acabas de editar (el harness ya rastrea el estado).
- Ediciones **quirúrgicas** con Edit; NO reescribas archivos enteros ni pegues código grande en el chat (referencia `archivo:línea`).
- Build siempre con `/clp:ErrorsOnly` y `| Select-Object -Last 20` (no vuelques logs enormes). No repitas builds innecesarios.
- Trabaja **UN formulario/módulo por turno**: build verde → commit → y actualiza §6/§9/§13 de ESTE archivo. Así el contexto del chat se mantiene corto y el progreso queda fuera del chat.
- No abras chats largos: cuando el contexto crezca, deja todo committeado + este archivo actualizado y continúa en una sesión nueva.

## 1. Proyecto
- WinForms **.NET Framework 4.6.2**, proyecto **NO-SDK** (packages.config). C# 7+ (hay tuplas/ValueTuple).
- Raíz: `C:\Users\jportillo\Dropbox\Desarrollo ADI (DEV)\ADIPROJECTS` | Solución: `ADIPROJECTS.sln`
- Git: `origin = https://github.com/IvanPortilloM/ADIPROJECTS` (rama `master`).
- Proyectos: **ADIGGM** (app principal), **WSCorreos** (servicio Windows, referencia a ADIGGM), **CheckBoxComboBox** (lib), **PRESUPUESTO**.
- ⚠️ `.git` está DENTRO de Dropbox → `git gc`/repack fallan ("Permission denied"). Ya está `git config gc.auto 0`. Recomendación: mover el repo fuera de Dropbox.
- Despliegue: ClickOnce a `\\ADIGGM\Publish\ADIPROJECTS\`.

## 2. Objetivo
1. Centralizar TODA cadena de conexión en App.config (un solo lugar).
2. Reemplazar los DataSets tipados por **Dapper** (v2.1.66, ya instalado) con patrón Repositorio.

## 3. Compilar / verificar (`dotnet build` NO funciona; usar MSBuild)
```powershell
$msbuild = "C:\Program Files (x86)\Microsoft Visual Studio\18\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
& $msbuild "ADIGGM\ADIGGM.csproj" /t:Build /p:Configuration=Debug /p:Platform=AnyCPU /m /nologo /verbosity:minimal /clp:ErrorsOnly
```
- Validar build (exit 0) tras CADA cambio.
- csproj NO-SDK: CADA `.cs` nuevo DEBE agregarse a `<Compile Include="...">` en `ADIGGM\ADIGGM.csproj`.
- Arreglos habilitantes ya hechos: `CheckBoxComboBox.csproj` v4.0→v4.6.2; `<Reference Include="netstandard" />` en ADIGGM.csproj.
- NO se puede correr la app contra la BD real desde el agente: el USUARIO valida en ejecución (F5) cada form migrado.

## 4. Infraestructura ya creada
**`ADIGGM\CapaDatos\Conexion.cs`** = FUENTE ÚNICA. API: `Conexion.Cadena(nombre)`, `Conexion.CrearConexion(nombre)` [DbConnection agnóstico], `Conexion.CrearSql(nombre)` [SqlConnection]. Constantes: `Conexion.TRANSPORTE/.PERMISOS/.CA/.PRESUPUESTO/.COVIBASE/.COVIPRUEBAS/.SAC_MYSQL`. Compat: `Conexion.cn`, `Conexion.TransporteADI`.

**`ADIGGM\CapaDatos\RepositorioBase.cs`** (heredar con `: RepositorioBase`, ctor `: base(Conexion.XXX)`). Métodos protegidos:
- `Consultar<T>(sql,param) -> List<T>`; `PrimeroODefault<T>`; `Escalar<T>`; `Ejecutar(sql,param) -> int`
- `ConsultarTabla(sql,param) -> DataTable`; `CrearConexion() -> DbConnection` (transacciones manuales)
- `GuardarCambios(DataTable, insertSql, updateSql, deleteSql) -> int`: persiste por RowState (Added/Modified/Deleted) en transacción; **REEMPLAZA `TableAdapter.Update()`**. Los `@parámetros` deben llamarse IGUAL que las columnas; el PK identity NO va en el INSERT.

Repos (`ADIGGM\CapaDatos\`): RepositorioMotoristas, RepositorioPoliticas, RepositorioHistorialSalarios, RepositorioAsistencias, RepositorioReporteHoras, RepositorioTiposAsistencia, RepositorioFeriados, **RepositorioInventario**.
POCOs (`ADIGGM\CapaModelo\`): TipoAsistencia, DiaFeriado, MotoristaItem, HistorialSalario, TipoAsistenciaCombo, RegistroAsistenciaCab, TiempoTrabajado, ObservacionDia.
Dapper 2.1.66 en packages.config + csproj (DLL gitignored, se restaura con NuGet).

## 5. App.config — cadenas
Nombres canónicos (`ADIGGM\App.config <connectionStrings>`): `TransporteAdiggm`, `Permisos` (DB_Permisos), `CA`, `Presupuesto`, `Covibase`, `Covipruebas`, `SAC_MySql` (MySQL). Todas a `Data Source=ADIGGM` + `Encrypt=True;TrustServerCertificate=True`. Quedan entradas legacy `ADIGGM.Properties.Settings.*` que usan los DataSets tipados pendientes. `<appSettings>` con `TwilioAccountSid`/`TwilioAuthToken` VACÍOS.

## 6. Ya migrado (todo committeado y pusheado)
- **Conexión centralizada COMPLETA**: se eliminó `DbManager`; migradas cadenas inline de ~13 forms + `TranOrdenCompra` (tenía bug `.ToString()`) + WSCorreos. `ConfigurationManager.ConnectionStrings` solo vive en `Conexion.cs`.
- **Módulo HE migrado 100%** a Dapper (frmTiposAsistencia, frmFeriados, frmPoliticas, frmHistorialSalarios, frmCerrarPeriodo, frmCopiarAsistencia, frmReporteHorasExtras, frmAsistencias, frmEditarAsistencia).
- **Seguridad**: token Twilio PURGADO de todo el historial git (filter-repo + force-push).
- **DataSets — módulo INV EN CURSO**: `frmTipoOp` (9812322), `frmBodegas` (8832244) y `frmVisorExistencias` (8df4782) YA migrados. `RepositorioInventario` tiene: ListarTiposOperacion/GuardarTiposOperacion, ListarBodegas/GuardarBodegas, ListarVehiculosActivos, ListarCategoriasProductos, ListarProductosConTodos, ReporteExistencias (SP), ReporteProductosExistencia (SP). Patrón visor RDLC: BindingSource del Designer se conserva y en Load se le asigna el DataTable; maestro-detalle con DataSet plano + DataRelation (createConstraints:false por la fila "(TODOS)").

## 7. Patrón "Opción A" para DataSets tipados (mantenimiento: grid editable + TableAdapter.Update)
```csharp
// Repositorio (hereda RepositorioBase):
public DataTable ListarBodegas() => ConsultarTabla("SELECT IdBodega, NombreBodega, Activo FROM dbo.IN_Bodegas");
public int GuardarBodegas(DataTable t) => GuardarCambios(t,
   "INSERT INTO dbo.IN_Bodegas (NombreBodega, Activo) VALUES (@NombreBodega, @Activo)",   // PK identity NO va
   "UPDATE dbo.IN_Bodegas SET NombreBodega=@NombreBodega, Activo=@Activo WHERE IdBodega=@IdBodega",
   "DELETE FROM dbo.IN_Bodegas WHERE IdBodega=@IdBodega");
// Form .cs: campos `private DataTable _dt; private readonly RepositorioXxx _repo = new RepositorioXxx();`
//   Cargar(): _dt = _repo.ListarX(); bs.DataMember=""; bs.DataSource=_dt;   (bs = el BindingSource del Designer)
//   Guardar(): dgv.EndEdit(); bs.EndEdit(); _repo.GuardarX(_dt); recargar.
// .Designer.cs: quitar el DataSet tipado (Ds*) y el *TableAdapter (instanciación, BeginInit/EndInit, bloque de
//   config y campos); CONSERVAR el BindingSource y CONSERVAR las DataGridViewColumn (ver gotcha §11).
```
Pasos: (a) repo ListarX/GuardarX. (b) reescribir form .cs. (c) limpiar .Designer.cs. (d) `<Compile Include>` del repo. (e) build verde. (f) commit del módulo.
Forms NO-mantenimiento (visores/combos/transaccionales): `Consultar<T>`->List<POCO> a grid/combo; `ConsultarTabla`->DataTable para lógica que ya usa DataTable; SPs -> `Ejecutar`/`Consultar` con `commandType: CommandType.StoredProcedure`.

## 8. ⚠️ Gotcha crítico: VarGlobales (estado global)
`ADIGGM\Clases\VarGlobales.cs` tiene instancias ESTÁTICAS GLOBALES de TableAdapters "Consultas" (SPs) usadas en muchos forms (ej. `VarGlobales.consultasOC.OC_AutorizarOrden(...)`):
`consultasTrans`(DsTransporteAdiggm), `consultas`(DsCodeasAdiggm), `consultasOC`(DsOC), `consultasOCWeb`(DsOCWeb), `consultasFAC`(DsFAC), `consultasPR`(DsPresupuesto), `consultasCA`(DsCA), `consultasInv`(DsInventarioAdiggm).
Para retirar un DataSet por completo hay que reemplazar TAMBIÉN estas llamadas globales por métodos de repositorio (SP vía Ejecutar/Consultar con `CommandType.StoredProcedure`). Buscar: `grep "VarGlobales.consultas"`.
(VarGlobales también tiene Usuario/IdUsuario/IdPerfil/nombreSistema/rutas — dejar igual.)

## 9. Roadmap DataSets — formularios por DataSet (orden: menos→más; borrar el .xsd cuando TODOS migren)
- **DsInventarioAdiggm** (EN CURSO; frmTipoOp + frmBodegas + frmVisorExistencias HECHOS): faltan `frmInventario` (INV\Transacciones), `OC\TranConfirmarOrden` + `VarGlobales.consultasInv` → luego borrar `DsInventarioAdiggm.xsd`.
- **DsPermisos** (4, Seguridad): frmAsigPermisos, frmDetSubMenu, frmMenuSistema, frmSubMenu.
- **DsOCWeb** (2): VisOrdenesTrabajo + VarGlobales.consultasOCWeb (enredado con dsOC/dsTransporteAdiggm; migrar junto con OC).
- **DsCA** (9): Herramientas\frmDevoluciones, IA\frmBuscarAsociados, IA\frmInformacionAsoc, IA\frmCarnetImp, IA\frmDetCredito, IA\frmDetProducto, SAC\FrmSolCred, SAC\frmMenu + VarGlobales.consultasCA.
- **DsFAC** (11): FAC\FAC_CAI, FAC_Productos, FAC_TipoFacUsuarios, FAC_TipoFacturas, FAC_TipoMoneda, FAC_ReporteCierres, FAC_BusquedaViajes, FAC_Factura, FAC_VisorFacturas, SAC\frmClientesRTN + VarGlobales.consultasFAC.
- **DsCodeasAdiggm** (15): IA\frmInformacionAsoc, Mant\FrmAsigTpFacTpVeh/FrmCierreCliente/FrmCierresBuscar/FrmEstadosDeCuenta/FrmSyncTransCod/FrmTipoFac, PRESUPUESTO\frmPresupuestoSem, Reportes\RptMaestro, SAC\FrmAsocBuscar/FrmSolCred/frmVisorOrdenesSAC/frmOrdenes, Visores\FrmVisorPrestamos + VarGlobales.consultas.
- **DsPresupuesto** (25): todo PRESUPUESTO\* (frmAños/frmMeses/frmSemanas/frmCargos/frm_Genero/frmTipoMoneda/frmUndMedidas/frmTipoContratos/frmTipoMateriales/frmCuentasContables/frmDepartamentos/frmEmpleados/frmMateriales/frmCuentaCategoria/frmAsigCtasAMat/frmAsigCtasAMatPrev/frmAsigDeptosACtas/frmAsigDeptosAUsu/frmGenerarPresupuesto/frmPrestaciones/frmPresupuestoSem/frmSueldosYSalarios/frmReporteMaestro/frmVisorPresupuesto) + VarGlobales.consultasPR. (Muchos mantenimientos de catálogo simples → buen lote tras INV.)
- **DsOC** (29): OC\Man*(ManProductos/ManProveedores/ManResponsables/ManCatProductos/ManDepartamentos/ManTipoDocumento/ManTipoOC/ManParametrizacion/ManAsigCuentas), OC\Tran*(TranAbonar/TranConfirmarOrden/TranOrdenCompra), OC\Vis*(VisAbonos/VisCxP/VisCambioAceite/VisOCCodeas/VisOCCodeasDet/VisOCConfirmadas/VisOrdenesTrabajo/VisProveedores), OC\Reportes\*, Herramientas\frmDigitarEstadoCuentaBCO, INV\frmInventario, INV\frmVisorExistencias, SAC\frmOrdenes + VarGlobales.consultasOC.
- **DsTransporteAdiggm** (35, núcleo de transporte; dejar al final): casi todo Mantenimiento\* (FrmMotoristas/FrmVehiculos/FrmRutas/FrmTarifaRutas/FrmAsigTarifas/FrmClientes/FrmContratistas/FrmFincas/FrmZonas/FrmBloques/FrmLagunas/FrmCierres...), Transaccionales\FrmViajes(+Retro), Visores\FrmVisorViajes, Seguridad\FrmMantUsuarios/FrmCrearUsuarios/FrmEditUsers + VarGlobales.consultasTrans.

## 10. Pendiente (otras fases)
- **SEGURIDAD**: (a) el USUARIO debe ROTAR el token de Twilio (estuvo expuesto). (b) Mover a config la contraseña SMTP `serviciosadi@2020` hardcodeada en `ADIGGM\Visores\VisOrdenesTrabajo.cs` (NetworkCredential) y rotarla. (c) Cifrar `<connectionStrings>` (aspnet_regiis -pe) y/o dejar de usar el login `sa`.
- **LIMPIEZA**: borrar ~20 archivos "Copia en conflicto de ..." de Dropbox (no están en el csproj); quitar código muerto (línea comentada `MdiPrincipal.cs` ~341); consolidar 4 libs de Excel (ClosedXML/EPPlus/ExcelDataReader/Interop.Excel); migrar `System.Data.SqlClient` → `Microsoft.Data.SqlClient` (ya referenciado, sin usar; OJO: 4+ pone Encrypt=true por defecto).

## 11. Gotchas / lecciones
- ⚠️ **GRIDS Y EL DISEÑADOR DE VS**: si abres un form con grid en el DISEÑADOR de VS, este puede ELIMINAR las `DataGridViewColumn` (deja `AutoGenerateColumns=false` + 0 columnas → grid VACÍO en runtime, pero COMPILA). Tras tocar un `.Designer.cs` de un grid, VERIFICA que sigan el `dgv.Columns.AddRange(...)`, los bloques `// <col>` con `DataPropertyName`, y los campos de columna. Si se perdieron, restaura (de git: `git show HEAD:<ruta>`) o setea `AutoGenerateColumns=true`. (Pasó con frmTipoOp/frmBodegas y se reparó.) Las columnas usan `DataPropertyName` = nombre de columna del DataTable; el grid se habilita con `dgv.ReadOnly=false` (cascada a columnas).
- Antes de crear un POCO: `grep "class <Nombre>"`. Ya existen `PoliticaPago` y `RangoHora` en `ADIGGM\Clases\CalculadoraHoras.cs` (REUTILIZAR; PoliticaPago se extendió con PoliticaID/NombrePolitica). Para guardar horas se usa tupla `(TimeSpan,TimeSpan)`.
- NO usar regex greedy sin anclar en archivos con patrones repetidos (corrompió frmAsistencias; se restauró con git y se reescribió completo).
- `DataTable.Load` infiere columnas no-nulas; el PK identity se ignora en el INSERT y se obtiene al recargar.
- Reescribir historia git: `git filter-repo` NO está en PATH → `python <site-packages>\git_filter_repo.py` en un CLON temporal FUERA de Dropbox; force-push; luego en el repo Dropbox: `git -c transfer.unpackLimit=999999 fetch` + `git reset --hard origin/master`.
- Commit POR MÓDULO; terminar mensajes con `Co-Authored-By: Claude <noreply@anthropic.com>`. No usar `--no-verify`.
- Editar archivos con PowerShell: usar lectura/escritura UTF-8 explícita (no corromper ñ/á).

## 12. Validación pendiente del usuario
`frmTipoOp` (INV→"Tipo Operación") y `frmBodegas` (INV→"Bodegas"): que el listado muestre COLUMNAS; Nuevo+Guardar (INSERT); Editar+Guardar (UPDATE); Cancelar.
`frmVisorExistencias` (INV→Visores): ambos tipos de reporte cargan; filtros por categoría/producto (combo productos se filtra al cambiar categoría)/vehículo; checks habilitan/deshabilitan combos.

## 13. TAREA INMEDIATA
Continuar INV: `frmInventario` (INV\Transacciones; transaccional, usar §7 forms NO-mantenimiento), `OC\TranConfirmarOrden` y las llamadas `VarGlobales.consultasInv` → luego borrar `DsInventarioAdiggm.xsd` (y quitarlo del csproj). Build verde + commit por módulo. Pedir validación en ejecución al usuario. **Tras cada edición de un `.Designer.cs` con grid, verificar las columnas (gotcha §11).**
