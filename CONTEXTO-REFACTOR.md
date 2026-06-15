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
- **En CADA migración de form: análisis de errores de lógica** (transacciones, catches que tragan errores, éxito incondicional, DBNull, estado UI). Documentar hallazgos estilo §14; los GRAVES se reparan en la misma migración (autorizado por el usuario 2026-06-10); latentes/diseño se documentan y consultan.
- **Trucos de ahorro probados**: (a) XSD: extraer CommandText+params con UN script PowerShell ([xml] + SelectNodes por FillMethodName/Name), NO con múltiples Read; (b) limpieza de Designer: las líneas repetitivas (campos, ClearBeforeFill, dgv.DataSource) se quitan en bloque con PowerShell Replace, no con N Edits; (c) si ADIGGM.exe está corriendo, compilar con `/p:OutputPath=bin\Debug-verify\` y borrar la carpeta después; (d) commit con `| Select-Object -First 2` para no volcar salida; (e) los archivos `*.tmp.<pid>.<hash>` que aparezcan son residuos de edición: borrarlos, no commitearlos (cuidado con `git add -A`, preferir add selectivo).

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
**Respaldo por IP (996b640, para VPN sin DNS)**: appSettings `ServidorNombre`=ADIGGM / `ServidorIp`=192.168.2.77. `Conexion.Servidor` resuelve UNA vez por sesión (DNS del nombre → si falla, IP); `Cadena()` reescribe el host; `AjustarCadenasLegacy(Settings.Default)` (en Program.Main) cubre los DataSets tipados restantes; `AjustarRuta()` cubre rutas UNC (VarGlobales) y `urlReportes` se compone con `Conexion.Servidor`. Cadenas a otros hosts (MySQL adiggm.hn) NO se tocan. Al migrar forms NUEVOS no hay nada especial que hacer: todo pasa por Conexion.

**`ADIGGM\CapaDatos\RepositorioBase.cs`** (heredar con `: RepositorioBase`, ctor `: base(Conexion.XXX)`). Métodos protegidos:
- `Consultar<T>(sql,param) -> List<T>`; `PrimeroODefault<T>`; `Escalar<T>`; `Ejecutar(sql,param) -> int`
- `ConsultarTabla(sql,param) -> DataTable`; `CrearConexion() -> DbConnection` (transacciones manuales)
- `GuardarCambios(DataTable, insertSql, updateSql, deleteSql) -> int`: persiste por RowState (Added/Modified/Deleted) en transacción; **REEMPLAZA `TableAdapter.Update()`**. Los `@parámetros` deben llamarse IGUAL que las columnas; el PK identity NO va en el INSERT.

Repos (`ADIGGM\CapaDatos\`): RepositorioMotoristas, RepositorioPoliticas, RepositorioHistorialSalarios, RepositorioAsistencias, RepositorioReporteHoras, RepositorioTiposAsistencia, RepositorioFeriados, RepositorioInventario, RepositorioPermisos (Menu/SubMenu/DetSubMenu/permisos transaccionales), RepositorioUsuarios (TR_Usuarios p/combos, BD Transporte).
POCOs (`ADIGGM\CapaModelo\`): TipoAsistencia, DiaFeriado, MotoristaItem, HistorialSalario, TipoAsistenciaCombo, RegistroAsistenciaCab, TiempoTrabajado, ObservacionDia.
Dapper 2.1.66 en packages.config + csproj (DLL gitignored, se restaura con NuGet).

## 5. App.config — cadenas
Nombres canónicos (`ADIGGM\App.config <connectionStrings>`): `TransporteAdiggm`, `Permisos` (DB_Permisos), `CA`, `Presupuesto`, `Covibase`, `Covipruebas`, `SAC_MySql` (MySQL). Todas a `Data Source=ADIGGM` + `Encrypt=True;TrustServerCertificate=True`. Quedan entradas legacy `ADIGGM.Properties.Settings.*` que usan los DataSets tipados pendientes. `<appSettings>` con `TwilioAccountSid`/`TwilioAuthToken` VACÍOS.

## 6. Ya migrado (todo committeado y pusheado)
- **Conexión centralizada COMPLETA**: se eliminó `DbManager`; migradas cadenas inline de ~13 forms + `TranOrdenCompra` (tenía bug `.ToString()`) + WSCorreos. `ConfigurationManager.ConnectionStrings` solo vive en `Conexion.cs`.
- **Módulo HE migrado 100%** a Dapper (frmTiposAsistencia, frmFeriados, frmPoliticas, frmHistorialSalarios, frmCerrarPeriodo, frmCopiarAsistencia, frmReporteHorasExtras, frmAsistencias, frmEditarAsistencia).
- **Seguridad**: token Twilio PURGADO de todo el historial git (filter-repo + force-push).
- **DataSets — DsInventarioAdiggm ELIMINADO (c2831bf)**: frmTipoOp, frmBodegas, frmVisorExistencias, frmInventario migrados; combo bodegas de TranConfirmarOrden vía repo; `consultasInv` quitado de VarGlobales; .xsd/.cs/.xsc/.xss borrados y fuera del csproj. Primer DataSet retirado por completo. `RepositorioInventario` tiene: ListarTiposOperacion/GuardarTiposOperacion, ListarBodegas/GuardarBodegas, ListarVehiculosActivos, ListarCategoriasProductos, ListarProductosConTodos, ReporteExistencias (SP), ReporteProductosExistencia (SP). Patrón visor RDLC: BindingSource del Designer se conserva y en Load se le asigna el DataTable; maestro-detalle con DataSet plano + DataRelation (createConstraints:false por la fila "(TODOS)").

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
- **DsInventarioAdiggm**: ✅ ELIMINADO (c2831bf).
- **DsPermisos**: ✅ ELIMINADO (178c74b). frmMenuSistema (4e3c9bb), frmSubMenu (d567100), frmDetSubMenu (81bfa66), frmAsigPermisos + fixes §14.1-4 (d7bf391); fix XML nietos §14.5 (dd8a95b).
- **DsOCWeb** (2): VisOrdenesTrabajo + VarGlobales.consultasOCWeb (enredado con dsOC/dsTransporteAdiggm; migrar junto con OC).
- **DsCA**: ✅ ELIMINADO (92c92b3). frmDetProducto, frmDetCredito, frmCarnetImp, frmBuscarAsociados, SAC\frmMenu, frmDevoluciones, frmInformacionAsoc, FrmSolCred (0fc38a3), frmTarjetas y frmObsProducto migrados; consultasCA quitado de VarGlobales. FrmSolCred además dejó de usar DsCodeasAdiggm/consultas (RepositorioCodeas creció: asociados, solicitudes, estado financiero, amortizaciones, fechas de corte, inserts SAC_*).
- **DsFAC** (11, EN CURSO — conexión TransporteAdiggm, `RepositorioFAC` creado 9aa7b5f): ✅ FAC_TipoMoneda (9aa7b5f), ✅ FAC_CAI (e91b4a1), ✅ FAC_TipoFacturas (6cf66a7), ✅ FAC_Productos (4788aca, grid con 2 columnas combo), ✅ FAC_TipoFacUsuarios (68af2ca, combo + 2 grids por SP + 1er uso de consultasFAC reemplazado), ✅ FAC_ReporteCierres (8175c5d, combo de fincas por SP; ReportViewer intacto), ✅ SAC\frmClientesRTN (f674ef5, mant. PK string + búsqueda LIKE, 2 grids comparten BindingSource), ✅ FAC_BusquedaViajes (2d50319, 5 combos + grid visor por SP), ✅ FAC_VisorFacturas (7a3b8b9, maestro-detalle 2 grids por SP + anular), ✅ FAC_ActualizarDatos (f8b2698, SP con 3 params OUTPUT vía DynamicParameters). Pendiente: **FAC_Factura** (alta, el más complejo y ÚLTIMO consumidor de consultasFAC). Al migrarlo: retirar `consultasFAC` de VarGlobales y BORRAR DsFAC.xsd. (El XSD tiene otros adapters de FAC_TipoFacturas/FAC_Productos con filtros y fila "Todos" — los usan los forms transaccionales, cubrir al migrarlos.)
- **DsCodeasAdiggm** (15): IA\frmInformacionAsoc, Mant\FrmAsigTpFacTpVeh/FrmCierreCliente/FrmCierresBuscar/FrmEstadosDeCuenta/FrmSyncTransCod/FrmTipoFac, PRESUPUESTO\frmPresupuestoSem, Reportes\RptMaestro, SAC\FrmAsocBuscar/FrmSolCred/frmVisorOrdenesSAC/frmOrdenes, Visores\FrmVisorPrestamos + VarGlobales.consultas.
- **DsPresupuesto** (25): todo PRESUPUESTO\* (frmAños/frmMeses/frmSemanas/frmCargos/frm_Genero/frmTipoMoneda/frmUndMedidas/frmTipoContratos/frmTipoMateriales/frmCuentasContables/frmDepartamentos/frmEmpleados/frmMateriales/frmCuentaCategoria/frmAsigCtasAMat/frmAsigCtasAMatPrev/frmAsigDeptosACtas/frmAsigDeptosAUsu/frmGenerarPresupuesto/frmPrestaciones/frmPresupuestoSem/frmSueldosYSalarios/frmReporteMaestro/frmVisorPresupuesto) + VarGlobales.consultasPR. (Muchos mantenimientos de catálogo simples → buen lote tras INV.)
- **DsOC** (29): OC\Man*(ManProductos/ManProveedores/ManResponsables/ManCatProductos/ManDepartamentos/ManTipoDocumento/ManTipoOC/ManParametrizacion/ManAsigCuentas), OC\Tran*(TranAbonar/TranConfirmarOrden/TranOrdenCompra), OC\Vis*(VisAbonos/VisCxP/VisCambioAceite/VisOCCodeas/VisOCCodeasDet/VisOCConfirmadas/VisOrdenesTrabajo/VisProveedores), OC\Reportes\*, Herramientas\frmDigitarEstadoCuentaBCO, INV\frmInventario, INV\frmVisorExistencias, SAC\frmOrdenes + VarGlobales.consultasOC.
- **DsTransporteAdiggm** (35, núcleo de transporte; dejar al final): casi todo Mantenimiento\* (FrmMotoristas/FrmVehiculos/FrmRutas/FrmTarifaRutas/FrmAsigTarifas/FrmClientes/FrmContratistas/FrmFincas/FrmZonas/FrmBloques/FrmLagunas/FrmCierres...), Transaccionales\FrmViajes(+Retro), Visores\FrmVisorViajes, Seguridad\FrmMantUsuarios/FrmCrearUsuarios/FrmEditUsers + VarGlobales.consultasTrans.

## 10. Pendiente (otras fases)
- **SEGURIDAD**:
  - ✅ **Credenciales externalizadas (7e147f2, 2026-06-15)**: TODAS las credenciales hardcodeadas movidas a `appSettings` y leídas por `ADIGGM\CapaDatos\AppConfig.cs`. El `App.config` versionado tiene las claves VACÍAS + `<appSettings file="secrets.config">`; los valores REALES viven solo en `ADIGGM\secrets.config` (**gitignored**, se copia a la salida por el csproj con `Condition=Exists`). Plantilla: `secrets.config.example`. Claves: `ReportServerUsuario/Clave/Dominio` (SSRS, en FAC_ReporteCierres/FAC_VerReporte/ReporteMaestro/VisualizarReporte/TrazabilidadVehiculo), `SmtpUsuario/Clave` (serviciosadiggm@, en MdiPrincipal/VisOrdenesTrabajo/TranOrdenCompra), `SmtpEdoCtaUsuario/Clave` (jlanza@, en FrmEstadosDeCuenta), `TwilioAccountSid/AuthToken`. `CustomReportCredentials.cs` ya recibía por parámetro y no se instancia (código muerto).
  - ⚠️ **PENDIENTE — ROTAR (usuario)**: los valores reales SIGUEN en el historial git (SSRS `Administrator/camaron+2016`, SMTP `serviciosadi@2020` y `JuniorADI@19`). Externalizar NO los borra del pasado: hay que CAMBIARLOS en el dominio/SSRS/Office365. Además el token de Twilio. Al desplegar (ClickOnce): incluir `secrets.config` junto al `.exe`.
  - (c) Cifrar `<connectionStrings>` (aspnet_regiis -pe) y/o dejar de usar el login `sa` (siguen en App.config; sería el siguiente paso de esta fase).
- **LIMPIEZA**: borrar ~20 archivos "Copia en conflicto de ..." de Dropbox (no están en el csproj); quitar código muerto (línea comentada `MdiPrincipal.cs` ~341); consolidar 4 libs de Excel (ClosedXML/EPPlus/ExcelDataReader/Interop.Excel); migrar `System.Data.SqlClient` → `Microsoft.Data.SqlClient` (ya referenciado, sin usar; OJO: 4+ pone Encrypt=true por defecto).

## 11. Gotchas / lecciones
- ⚠️ **GRIDS Y EL DISEÑADOR DE VS** (causa raíz hallada 2026-06-10): si el `.Designer.cs` deja `dgv.DataSource = <BindingSource>` y el BindingSource ya NO tiene DataSet de diseño (migrado), al abrir el form en el diseñador VS no puede resolver el esquema y ELIMINA las `DataGridViewColumn` EN DISCO (deja `AutoGenerateColumns=false` + 0 columnas → grid VACÍO en runtime, pero COMPILA; también toca el .resx). RECURRENTE hasta quitar el binding de diseño. **Patrón obligatorio al migrar forms con grid: QUITAR `dgv.DataSource = bs` del Designer y asignarlo en código en CargarX() después de `bs.DataSource = _dt`** (hecho en frmTipoOp/frmBodegas, commit 3774396). Tras tocar un `.Designer.cs` de grid, verifica `dgv.Columns.AddRange(...)`, bloques `// <col>` con `DataPropertyName` y campos de columna; si se perdieron, restaura de git (`git show HEAD:<ruta>`). Las columnas usan `DataPropertyName` = nombre de columna del DataTable; el grid se habilita con `dgv.ReadOnly=false` (cascada a columnas).
- ⚠️ **Bindings de diseño huérfanos** (regresión hallada 2026-06-12 en FrmSolCred, fix 2304c3a): al quitar el DataSet de diseño de un BindingSource, los `control.DataBindings.Add(..., bindingSource, "columna", ...)` que el Designer tenga contra ese BindingSource quedan sin esquema y lanzan ArgumentException ("No se puede enlazar la propiedad o la columna X... dataMember") al ABRIR el form. Al migrar: `grep "DataBindings.Add" <Form>.Designer.cs`; los huérfanos se quitan del Designer y se recrean en runtime DESPUÉS de asignar el DataTable al BindingSource (con `DataBindings.Clear()` antes para no duplicar en recargas).
- Antes de crear un POCO: `grep "class <Nombre>"`. Ya existen `PoliticaPago` y `RangoHora` en `ADIGGM\Clases\CalculadoraHoras.cs` (REUTILIZAR; PoliticaPago se extendió con PoliticaID/NombrePolitica). Para guardar horas se usa tupla `(TimeSpan,TimeSpan)`.
- NO usar regex greedy sin anclar en archivos con patrones repetidos (corrompió frmAsistencias; se restauró con git y se reescribió completo).
- `DataTable.Load` infiere columnas no-nulas; el PK identity se ignora en el INSERT y se obtiene al recargar.
- ⚠️ `DataTable.Load` también marca `DataColumn.ReadOnly=true` en columnas CALCULADAS (expresiones/CASE de SPs o SELECTs). Si esa columna se edita en un grid (ej. flag Habilitado de usp_CargarPermisos), el binding lanza "columna enlazada a un campo de solo lectura..." y los `Cells[x].Value=` fallan. Fix: en el repositorio, tras ConsultarTabla, `tabla.Columns["X"].ReadOnly = false` (hecho en CargarPermisosUsuario, commit a7f46ba). Revisar esto en CUALQUIER grid editable que se cargue vía Dapper.
- Reescribir historia git: `git filter-repo` NO está en PATH → `python <site-packages>\git_filter_repo.py` en un CLON temporal FUERA de Dropbox; force-push; luego en el repo Dropbox: `git -c transfer.unpackLimit=999999 fetch` + `git reset --hard origin/master`.
- Commit POR MÓDULO; terminar mensajes con `Co-Authored-By: Claude <noreply@anthropic.com>`. No usar `--no-verify`.
- Editar archivos con PowerShell: usar lectura/escritura UTF-8 explícita (no corromper ñ/á).

## 12. Validación pendiente del usuario
`frmTipoOp` (INV→"Tipo Operación") y `frmBodegas` (INV→"Bodegas"): que el listado muestre COLUMNAS; Nuevo+Guardar (INSERT); Editar+Guardar (UPDATE); Cancelar.
`frmTipoOp`/`frmBodegas`/`frmVisorExistencias`/`frmInventario`: VALIDADOS OK 2026-06-10.
`OC→TranConfirmarOrden`: que el combo Bodega cargue (ahora vía repo); el resto del form no cambió.
`Seguridad→Menú Sistema` (frmMenuSistema): listado con columnas; Nuevo+Guardar; Editar+Guardar; Cancelar.
`Seguridad→SubMenú` (frmSubMenu): combo Menú Padre filtra el grid; Nuevo hereda el IdMenu del padre seleccionado; Guardar/Cancelar.
`Seguridad→DetSubMenú` (frmDetSubMenu): cadena Menú→SubMenú→grid; Nuevo hereda el IdSubMenu; Guardar/Cancelar.
`Seguridad` (los 4 forms) + menú del MDI: VALIDADOS OK 2026-06-10 (incl. fix Habilitado a7f46ba).
`IA→frmDetProducto`: VALIDADO OK 2026-06-11.
`IA→frmDetCredito` (se abre desde el detalle del asociado): encabezado del crédito completo (fechas/montos), los 4 tabs cargan (Mov. Aplicados / Tránsito / Pendientes / Aplicados), y % saldo / % plazo / pagos restantes correctos.
**Respaldo por IP (VPN)**: VALIDADO OK 2026-06-11 (probado por el usuario con VPN).
`IA→Carnets` (frmCarnetImp): listado con fotos carga; marcar/desmarcar; Exportar a Excel (probar CANCELAR el diálogo: ya no debe quedar Excel.exe en el Administrador de tareas); "Imprimir carnets" marca los seleccionados y recarga.
`IA→Buscar Asociados` (frmBuscarAsociados): búsqueda con filtros/orden funciona; Enter en el grid o Aceptar abre la información del asociado; Aceptar sin resultados ya no truena.
`SAC→Menú` (frmMenu): los 3 tabs cargan grid+imagen+reporte; Editar→cambiar platos/fecha/activo→Guardar persiste (incl. el último cambio sin salir de la celda); cambiar foto y Guardar; Exportar reporte: la opción PNG genera PNG y BMP genera BMP.
`Herramientas→Devoluciones` (frmDevoluciones): combo Caja carga; Verificar muestra originales+corregidos con colores; Corregir con cuentas inválidas AVISA (antes no hacía nada); Corregir válido actualiza (todo-o-nada).
`IA→Información del Asociado` (frmInformacionAsoc, CENTRAL — probar a fondo): encabezado+foto+tiempo afiliado; grids Productos/Créditos con Tránsito/Pendientes y totales; filtros con saldo/todos; detalle de producto y de crédito; panel PIN (validar/crear/renovar/reportar/activar/desactivar — frmTarjetas guarda vía repo ahora); personas autorizadas (Nuevo/Editar/Guardar/Cancelar/bloquear); Estado de Cuenta PDF; Obs de producto (frmObsProducto).
`FAC→Tipo Moneda` (FAC_TipoMoneda): listado con columnas (Id oculto, TipoMoneda, Simbolo, ValorLempiras N2); Nuevo+Guardar (INSERT); Editar+Guardar (UPDATE); Cancelar recarga.
`FAC→CAI` (FAC_CAI): listado con columnas (Cai, FragmentoSAR, fechas, números, check Activo); Nuevo+Guardar; Editar+Guardar; Cancelar; validación de celdas vacías sigue avisando.
`FAC→Tipo Facturas` (FAC_TipoFacturas): listado con columnas (Cod, TipoFactura, checks Activo/EsTransporte); Nuevo+Guardar; Editar+Guardar; Cancelar.
`FAC→Productos` (FAC_Productos): listado con columnas; las DOS columnas combo (Tipo=FAC_TipoEx, Tipo Factura=TR_TipoFacturas) muestran el texto correcto y se pueden elegir al editar; Nuevo+Guardar; Editar+Guardar (verificar que el combo persiste el Id correcto); Cancelar.
`FAC→Tipo Fac Usuarios` (FAC_TipoFacUsuarios): el combo Tipo Factura carga; al elegir uno se llenan los dos grids (no-asignados / asignados); búsqueda con Enter en cada caja filtra su grid; marcar usuarios en "no asignados" + Agregar los mueve a "asignados"; marcar en "asignados" + Eliminar los devuelve; ambos grids se refrescan.
`FAC→Reporte de Cierres` (FAC_ReporteCierres): el combo Cliente/Finca carga; elegir cliente + fechas Desde/Hasta + Visualizar genera el reporte de SSRS (ServerReport) correctamente.
`SAC→Clientes RTN` (frmClientesRTN): pestaña "Ingresar RTN" lista los clientes (RTN/Empresa/Dirección/Contacto/Teléfono); Nuevo+Guardar (INSERT con RTN como PK); Editar+Guardar; Cancelar; pestaña de búsqueda filtra por RTN o Empresa (Enter o botón Buscar). Probar que NO se rompe al renombrar un RTN existente (no persiste, es esperado).
`FAC→Búsqueda de Viajes` (FAC_BusquedaViajes, se abre desde FAC_Factura con un IdCliente): cargan los 5 combos (Tipo Factura, Producto—depende del tipo, Calendarización/Cierre, Cliente—preseleccionado y deshabilitado, Proforma—depende del cierre); Visualizar llena el grid de boletas y calcula Cantidad/ISV/Sub-Total/Total; Aceptar valida selección y pasa los datos a FAC_Factura.
`FAC→Actualizar Datos` (FAC_ActualizarDatos, se abre desde el menú contextual del visor): al abrir, los 3 campos (N° Orden, N° SAG, N° Proforma) cargan con los valores actuales de la factura (Opcion=2/lectura por OUTPUT); editar + Guardar persiste (Opcion=1) y muestra "Datos actualizados!".
`FAC→Visor de Facturas` (FAC_VisorFacturas): combos Tipo Factura y Cliente con "Todos"; Visualizar/Enter/fechas filtran el grid maestro; al seleccionar una factura carga su detalle (servicios) y muestra las Observaciones en el textbox; clic derecho sobre una factura NO anulada muestra el menú (Anular/Ver/Actualizar; "Ver con descripción" solo si es Factura Transporte); Anular pide confirmación y refresca; Nuevo abre FAC_Factura y al cerrar refresca.
`SAC→Solicitud de Crédito` (FrmSolCred, CENTRAL — probar a fondo): **el form ya ABRE (fix 2304c3a: bindings de diseño huérfanos); verificar que años/meses/días se llenan al buscar asociado**; buscar asociado por identidad (grids Aportes/Créditos con Tránsito/Pendientes — **en modo EDITAR los montos T/P ya no se inflan acumulándose entre filas**); totales y posición financiera; tipos de solicitud (préstamo/refinanciamiento/retiro/neteo); fechas de corte y formalización; Generar (guarda asociado+solicitud+amortización+estado financiero y abre PDF); Imprimir (juego completo de reportes a impresora); Estado de cuenta.

## 13. TAREA INMEDIATA
Continuar **DsFAC** (§9). `RepositorioFAC : RepositorioBase(Conexion.TRANSPORTE)` ya existe; FAC_TipoMoneda, FAC_CAI, FAC_TipoFacturas y FAC_Productos hechos (patrón Opción A limpio, sin hallazgos graves). **Patrón de columna combo en grid migrado** (FAC_Productos): conservar la BindingSource del combo, quitar del Designer su `.DataSource=...BindingSource` (y el DataSet) y asignar en Load `combo.DataSource = bindingSource` tras poblar la BindingSource vía repo; conservar `DataPropertyName/DisplayMember/ValueMember`. **Patrón SP→grid + combo** (FAC_TipoFacUsuarios): grids/combo conservan su BindingSource; se quita del Designer `dgv.DataSource`/`combo.DataSource` y el DataSet; en código se asigna `bs.DataSource = repo.SP(...)` (CommandType.StoredProcedure) y luego `control.DataSource = bs`; los SP de acción (INS/UPD) van por `Ejecutar(..., StoredProcedure)`, reemplazando `VarGlobales.consultasFAC`. Queda **1 form**: **FAC_Factura** (alta de facturas, el más complejo y ÚLTIMO consumidor de `consultasFAC`). Usa: `ObtenerTipoFactura`, `FAC_ObtenerISV`, `FAC_ObtenerCAI(ref CAI, ref Correlativo)` [OUTPUT→ `DynamicParameters` direction InputOutput, como FAC_ActualizarDatos f8b2698], `FAC_FacturaInsert` (devuelve IdFAC), `FAC_FacturaDetInsert` (por fila del grid), `FAC_EsExenta`, `FAC_ObtenerPagaISV`; abre FAC_BusquedaViajes (ya migrado). **§0 análisis de lógica**: el alta inserta cabecera + N detalles SIN transacción global (revisar si conviene transaccionalizar con `CrearConexion()`+BeginTransaction, decidir con el usuario). Tras migrarlo: `grep consultasFAC` (debe quedar SOLO la decl. en VarGlobales L33) → retirarla y BORRAR DsFAC.xsd (.xsd/.xsc/.xss/.Designer.cs + quitar del csproj). Credenciales: ✅ externalizadas (§10), rotación pendiente del usuario. UN form por turno; **análisis de errores de lógica en cada form (§0)**, los GRAVES se reparan en la migración; build verde + commit + actualizar §6/§9/§12/§13. **Gotcha §11 en todo Designer con grid** (en FAC_TipoMoneda se quitó `dgv.DataSource` del Designer y se asigna en CargarTiposMoneda()).
PENDIENTE A EVALUAR (§14.7): transaccionalizar el flujo Generar de FrmSolCred (InsertarAsociado→InsertarSolicitud→TablaAmortizacion→EstadoFinanciero×N van sin transacción, igual que el original; los SPs parecen tener semántica upsert propia — decidir con el usuario y la BD de prueba).

## 14. Revisión de lógica de ASIGNAR PERMISOS (auditoría 2026-06-10; fixes 1-5 APLICADOS en d7bf391 y dd8a95b; queda el 6 como deuda de diseño)
1. **GRAVE — guardado sin transacción** (`frmAsigPermisos.btnGuardar`): hace `DELETE FROM Permiso WHERE IdUsuario=...` y luego inserta fila por fila con `usp_ActualizarPermisos`; si algo falla a medio camino el usuario queda con permisos parciales o SIN permisos. Fix: envolver DELETE+INSERTs en UNA transacción (repo con `CrearConexion()`+BeginTransaction) y rollback ante error.
2. **GRAVE — éxito mentiroso + catch por fila**: el catch interno del foreach traga errores y continúa, y al final SIEMPRE muestra "Permisos actualizados exitosamente". Fix: con la transacción del punto 1, un solo try: o todo o nada, y mensaje acorde.
3. **RIESGO — `Convert.ToBoolean(DBNull)`**: la columna `Habilitado` de usp_CargarPermisos es nullable (xsd L370 minOccurs=0); si el SP devolviera NULL, `Convert.ToBoolean(row.Cells["habilitado"].Value)` lanza InvalidCastException DESPUÉS del DELETE (pérdida total). Fix: tratar DBNull como false.
4. **MENOR — botón marcar/desmarcar desincronizado**: `selectAllOff` y el ícono no se resetean al cambiar usuario/recargar (`cargarDgv`); el primer click tras cambiar de usuario puede desmarcar en vez de marcar. Fix: resetear flag+ícono en cargarDgv().
5. **LATENTE — parseo XML mal anidado** (`CD_Usuario.ObtenerPermisos` L79-80): los nietos se leen de `menu...Elements("SubMenu").Elements("DetalleSubMenuNieto")` (la UNIÓN de todos los submenús hermanos) en vez de `submenu.Elements("DetalleSubMenuNieto")`. HOY no altera la visibilidad del MDI (enciende por nombre con búsqueda global, la unión repetida da lo mismo), pero cualquier consumo futuro por submenú saldrá mal. Fix de 2 líneas cuando se toque CD_Usuario; NO urgente.
6. **FRAGILIDAD (diseño, no tocar por ahora)**: el MDI aplica permisos buscando ítems por TEXTO del menú (`busca(item, nombre)`); renombrar un ítem en BD o en el Designer rompe el permiso en silencio. El catch de ObtenerPermisos también devuelve lista vacía ante CUALQUIER error de BD (usuario "sin permisos" sin aviso).
7. **DEUDA — FrmSolCred.Generar sin transacción** (decisión pendiente): la cadena InsertarAsociado→InsertarSolicitud→TablaAmortizacion→InsertarEstadoFinanciero×N replica el original sin transacción global. Los SPs reciben IdSolicitud (semántica upsert aparente), por lo que transaccionalizar a ciegas podría chocar con su lógica interna. Evaluar con el usuario contra la BD.
8. **Bugs reparados en FrmSolCred (0fc38a3)**: acumuladores T/P fuera del loop en modo editar (montos inflados); EXEC por concatenación con cadena legacy ×3; Clipboard.SetText con vacío.
