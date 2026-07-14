# Gotchas que rompen el build o el runtime si se ignoran

## §8 — VarGlobales.consultas* (TableAdapters globales de SPs)
`ADIGGM\Clases\VarGlobales.cs` tiene instancias estáticas globales por DataSet
(`consultasTrans`, `consultasOC`, `consultasFAC`, etc.). Un form puede llamar
`VarGlobales.consultasXxx.SP(...)`. Para RETIRAR un DataSet por completo hay que reemplazar
TAMBIÉN esas llamadas globales por métodos de repositorio (SP vía `Ejecutar`/`Escalar`/`ConsultarTabla`
con `CommandType.StoredProcedure`). Busca: `grep -rn "VarGlobales.consultasXxx"`. Cuando NINGÚN form
use ya `consultasXxx`, **elimina el campo de VarGlobales**. El `.xsd` sólo se borra cuando ningún
form instancia el DataSet tipado (`grep -rl "new ADIGGM.DataSets.DsXxx()"`).

## §11 — el diseñador de VS borra columnas / bindings huérfanos
- Si el `.Designer.cs` deja `dgv.DataSource = <BindingSource>` y ese BindingSource ya no tiene
  DataSet de diseño, al abrir el form en el diseñador **VS borra las DataGridViewColumn EN DISCO**
  (deja `AutoGenerateColumns=false` + 0 columnas → grid vacío en runtime). Por eso TODO grid migrado
  define sus columnas EN CÓDIGO (`ConfigurarColumnas()` con `GridColumnas`, llamado tras
  `InitializeComponent`) y el `dgv.DataSource` se asigna en código, no en el Designer.
- **Bindings de diseño huérfanos**: los `control.DataBindings.Add(..., bindingSource, "col", ...)`
  contra un BindingSource sin esquema lanzan `ArgumentException` al ABRIR el form. Al migrar,
  `grep "DataBindings.Add" <Form>.Designer.cs`; quítalos del Designer y recréalos en runtime tras
  asignar el DataTable (con `DataBindings.Clear()` antes para no duplicar).
- `DataTable.Load` marca `ReadOnly=true` en columnas calculadas (CASE/expresiones de SPs) y en el PK
  identity. Si una de esas se edita en grid, falla el binding → en el repo, tras `ConsultarTabla`,
  `tabla.Columns["X"].ReadOnly = false`.
- **§11b (hallado 2026-07-10, ManAsigCuentas) — MaxLength inferido de columnas literales/calculadas**:
  si un SELECT trae una columna string LITERAL (p.ej. `'' AS Cuenta` para "aún sin valor") o
  calculada, `DataTable.Load` infiere su `MaxLength` de esa expresión concreta (con `''` sale ~0) y
  lo aplica al DataTable. Si esa columna es EDITABLE en el grid, escribir CUALQUIER texto más largo
  lanza `ArgumentException: ... infringe el límite de MaxLength` al hacer `EndEdit()` (se ve como un
  cuadro de error del DataGridView, no una excepción .NET normal). Mismo arreglo que el ReadOnly:
  tras `ConsultarTabla`, `tabla.Columns["X"].MaxLength = -1;` (ilimitado). Revisar TODA columna
  string editable que venga de un literal o expresión, no solo las de GROUP BY del gotcha anterior.

## §14.10 — toggle de edición en grids con columnas-en-código
Con las columnas creadas en código con `ReadOnly=true`, el cascade de `dgv.ReadOnly=false` NO reactiva
las columnas al primer clic de "Editar". **Usa SIEMPRE `Clases.GridColumnas.Edicion(dgv, true/false)`**
(fija `dgv.ReadOnly` y el `ReadOnly` de cada columna a la vez; respeta columnas enlazadas a un
DataColumn de solo lectura), NUNCA `dgv.ReadOnly=false` directo en btnNuevo/btnEditar.

## Build (dotnet build NO funciona; usar MSBuild)
```powershell
$msbuild = "C:\Program Files (x86)\Microsoft Visual Studio\18\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
& $msbuild "ADIGGM\ADIGGM.csproj" /t:Build /p:Configuration=Debug /p:Platform=AnyCPU /m /nologo /verbosity:minimal /clp:ErrorsOnly
```
Si ADIGGM.exe está corriendo o falla por `app.publish` bloqueado (Dropbox), compila a salida aparte
y borra después:
```powershell
& $msbuild "ADIGGM\ADIGGM.csproj" /t:Build /p:Configuration=Debug /p:Platform=AnyCPU "/p:OutputPath=bin\Debug-verify\" /m /nologo /verbosity:minimal /clp:ErrorsOnly
# luego: Remove-Item -Recurse -Force "ADIGGM\bin\Debug-verify"
```
csproj NO-SDK: cada `.cs` NUEVO (un repo nuevo) DEBE agregarse a `<Compile Include="...">`.

## Ejecutar los scripts de la skill
La política de ejecución del equipo BLOQUEA los `.ps1` ("la ejecución de scripts está deshabilitada").
Invócalos SIEMPRE así (falla el primer intento si lo omites):
```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File ".claude\skills\adiggm-migrar-dataset\scripts\<script>.ps1" -Param ...
```

## Columnas con nombres acentuados/Unicode (ej. `Selección`, `Selección2`)
NO las pases por argumentos de shell a `limpiar_designer.ps1` (riesgo de encoding/case al cruzar
bash→powershell). Pásale al script solo las columnas ASCII y quita las acentuadas A MANO con Edit
(3 lugares: la línea `this.Selección = new ...`, el bloque de config `// Selección` + propiedades,
y el campo `private ... Selección;`; su entrada en el `AddRange` ya la borra el script al barrer el
bloque completo). Verifica al final: `grep -c "{" == grep -c "}"` y 0 restos del nombre.

## Encoding y edición de Designers con PowerShell
Lee/escribe UTF-8 y **preserva el BOM** (no corromper ñ/á). Los scripts de esta skill detectan el BOM
del archivo original y lo conservan. Tras borrar columnas, verifica el balance de llaves (`{` vs `}`)
y que no queden `Columns.AddRange` ni campos `private ...Column` huérfanos.

## git e higiene
- `git add` SELECTIVO de los archivos del form (NUNCA `git add -A`): el working tree suele tener
  cambios del usuario (menú MDI, tarifas) o `*.resx` que VS recodifica (no commitear).
- Commit por módulo, mensaje terminado en `Co-Authored-By: Claude <noreply@anthropic.com>`. No `--no-verify`.
- Archivos "Copia en conflicto de ..." de Dropbox: basura; bórralos (git rm si están trackeados) — no
  están en el csproj y rompen el orden mental, pero NO compilan (no estan en <Compile>).
- Tras correr `limpiar_designer.ps1` queda un `.Designer.cs.bak`: bórralo antes de commitear.

## Validación
El agente NO corre la app contra la BD real: el USUARIO valida en ejecución (F5) cada form migrado.
Anota qué probar en §12 de CONTEXTO-REFACTOR.md (listado con columnas, Nuevo/Editar/Guardar/Cancelar,
combos que filtran, etc.).
