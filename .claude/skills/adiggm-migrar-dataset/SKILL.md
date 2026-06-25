---
name: adiggm-migrar-dataset
description: >
  Procedimiento PROBADO para migrar un formulario del proyecto ADIGGM desde un
  DataSet tipado (DsOC, DsTransporteAdiggm, DsCodeasAdiggm, etc.) + TableAdapters
  a un repositorio Dapper (RepositorioXxx : RepositorioBase). Úsala SIEMPRE que la
  tarea sea: migrar/achicar/retirar un DataSet tipado o un .xsd; reemplazar
  TableAdapter.Fill/Update o VarGlobales.consultasXxx por métodos de repositorio;
  mover columnas de un DataGridView del .Designer.cs al código (helper GridColumnas);
  o continuar la tarea §13.a de CONTEXTO-REFACTOR.md. Trae los patrones (Opción A,
  visor, maestro-combo+DataRelation, columna combo, SP escalar/OUTPUT), scripts
  PowerShell (extraer SQL del XSD, volcar columnas, limpiar el Designer) y los
  gotchas críticos (§8 VarGlobales, §11 grids, §14.10 edición). NO la uses para
  features nuevas ni para tocar el módulo PRESUPUESTO (diferido).
---

# Migrar un formulario de DataSet tipado → RepositorioXxx + Dapper (ADIGGM)

Refactor incremental del proyecto ADIGGM: cada DataSet tipado de WinForms se reemplaza,
**un formulario por turno**, por un repositorio Dapper. Esta skill codifica el flujo ya
validado en decenas de forms para que sea rápido, consistente y barato en tokens.

## Antes de empezar (contexto que NO se re-deriva)
- App **WinForms .NET Framework 4.6.2**, NO-SDK (cada `.cs` nuevo va al `<Compile Include>` del csproj).
- Fuente única de conexión: `ADIGGM\CapaDatos\Conexion.cs` (`Conexion.TRANSPORTE`, etc.).
- Base de repos: `ADIGGM\CapaDatos\RepositorioBase.cs` — `Consultar<T>`, `PrimeroODefault<T>`,
  `Escalar<T>`, `Ejecutar`, `ConsultarTabla(sql,param[,CommandType])`, `GuardarCambios(dt,ins,upd,del)`.
- Helper de columnas: `ADIGGM\Clases\GridColumnas.cs` — `Texto/Check/Combo` (readOnly por defecto) + `Edicion(dgv,bool)`.
- **REGLA de repo (usuario): el repositorio se elige por la BD/dominio REAL del dato, NO por el
  DataSet de origen** (`TR_*`→RepositorioTransporte, `COD_/SAC/covibase`→RepositorioCodeas,
  `FAC_*`→RepositorioFAC, `IN_*`→RepositorioInventario, `OC_/CP_/OCWeb`→RepositorioOC). Un form
  puede repartir métodos entre repos. Verifica el dominio antes de elegir.
- El progreso/roadmap vive en `CONTEXTO-REFACTOR.md` (NO es parte de esta skill; actualízalo al final).

## Flujo (un form por turno)

### 1. Analizar el form
- Localiza los 3 archivos (`.cs`, `.Designer.cs`, `.resx`).
- Mapea el uso de datos: `grep -nE "TableAdapter|ds<Nombre>|VarGlobales\.consultas|\.Fill\(|\.Update\(|\.FillBy|new ReportDataSource|\.Cells\["` en el `.cs`.
- Clasifica cada acceso para elegir patrón (ver `references/patrones.md`):
  - grilla de mantenimiento editable (Fill + Update) → **Opción A**
  - grilla de solo lectura / búsqueda → **visor**
  - combo maestro que filtra una grilla → **maestro-combo + DataRelation**
  - combo dentro de la grilla → **columna combo**
  - SP que devuelve escalar / tiene parámetros OUTPUT → **SP escalar/OUTPUT**
  - tablas que alimentan un RDLC → DataTables de repo pasadas a `ReportDataSource`

### 2. Extraer el SQL del XSD (no leer el .xsd entero)
```powershell
& ".claude\skills\adiggm-migrar-dataset\scripts\extraer_sql_xsd.ps1" -Xsd "ADIGGM\DataSets\Ds<Nombre>.xsd" -Tabla "<NombreTabla>"
```
Devuelve, por TableAdapter: el SELECT principal, cada `FillBy*` (con tipo Text/SP y params), y los
INSERT/UPDATE/DELETE. La PK identity NO va en el INSERT; los `@parámetros` de `GuardarCambios`
deben llamarse IGUAL que las columnas. Confirma la conexión del XSD (`<Connection ...>`) para elegir
`Conexion.XXX`.

### 3. Agregar métodos al repositorio correcto
Sigue los esqueletos de `references/patrones.md`. **Reutiliza** métodos existentes si el SELECT/SP
coincide (revísalo: `grep "public .*(" CapaDatos\Repositorio<Dominio>.cs`). Si creas un repo nuevo,
agrégalo al `<Compile Include>` del csproj.

### 4. Reescribir el `.cs` del form
- Campos: `private readonly Repositorio<Dominio> _repo = new ...(); private DataTable _dt;`
- Llamar `ConfigurarColumnas();` en el constructor, tras `InitializeComponent()`.
- Reemplazar `Fill`/`Update`/`consultasXxx.SP(...)` por los métodos del repo.
- Mantenimientos: **recargar tras guardar** (el identity se obtiene al recargar) y togglear edición
  con `GridColumnas.Edicion(dgv,bool)` — NUNCA `dgv.ReadOnly=false` directo (ver §14.10).

### 5. Columnas del grid EN CÓDIGO (§11 / §13.b — obligatorio en TODO grid migrado)
```powershell
& ".claude\skills\adiggm-migrar-dataset\scripts\volcar_columnas_grid.ps1" -Designer "<ruta>.Designer.cs" -Grid "<dgvNombre>"
```
Emite las líneas `GridColumnas.Texto/Check(...)` listas para pegar en `ConfigurarColumnas()`
(preserva Name/DataPropertyName/HeaderText/Visible/Format/Width/AutoSizeMode). Asigna
`dgv.DataSource` en código (no en el Designer). Las columnas combo reciben su `DataSource` en el Load.

### 6. Limpiar el `.Designer.cs`
```powershell
& ".claude\skills\adiggm-migrar-dataset\scripts\limpiar_designer.ps1" -Designer "<ruta>.Designer.cs" -Grid "<dgvNombre>" -DataSet "ds<Nombre>" -Cols "col1,col2,..." [-BindingSource "xBindingSource"]
```
Borra el DataSet tipado + TableAdapters + creación/config/AddRange/campos de columnas + cellStyles
huérfanos + el `dgv.DataSource` de diseño. CONSERVA el/los BindingSource (sólo le quita su DataMember
de diseño si pasas `-BindingSource`) y los cellStyle a nivel de GRID. **Verifica el balance de llaves
al final y avisa de residuos.** Revisa la salida antes de continuar.

### 7. Build → commit → doc
- Build (ver `references/gotchas.md` para el comando MSBuild + workaround `app.publish`). Exit 0.
- **Análisis de errores de lógica** (§0): transacciones, catches que tragan, éxito incondicional,
  DBNull, estado UI. Los GRAVES se reparan en la misma migración; los latentes se documentan.
- `git add` SELECTIVO de los archivos del form (NUNCA `git add -A`), commit por módulo
  (mensaje terminado en `Co-Authored-By: Claude <noreply@anthropic.com>`).
- Actualiza §6/§9/§12/§13 de `CONTEXTO-REFACTOR.md` y pushea.

## Gotchas que rompen si se ignoran
Léelos en `references/gotchas.md` antes de tocar un Designer: **§8** (VarGlobales.consultas globales),
**§11** (el diseñador borra columnas / bindings huérfanos), **§14.10** (cascade de edición), encoding
UTF-8+BOM, y el comando de build.

## Referencias
- `references/patrones.md` — esqueletos de código de los 5 patrones + reporte RDLC.
- `references/gotchas.md` — §8/§11/§14.10, build, encoding, limpieza de copias-conflicto.
