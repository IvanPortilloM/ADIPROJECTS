# Patrones de migración (esqueletos probados)

Elige el patrón por cómo usa los datos el form. Casi todo form cae en uno o combina varios.

## 1. Opción A — mantenimiento con grilla editable (Fill + Update)
El caso más común de los `Man*`/catálogos. La PK identity NO va en el INSERT; los `@param`
de `GuardarCambios` se llaman IGUAL que las columnas.

```csharp
// Repositorio:
public DataTable ListarX() => ConsultarTabla("SELECT Id, Campo1, Campo2, Activo FROM dbo.TABLA");
public int GuardarX(DataTable t) => GuardarCambios(t,
    "INSERT INTO dbo.TABLA (Campo1, Campo2, Activo) VALUES (@Campo1, @Campo2, @Activo)",
    "UPDATE dbo.TABLA SET Campo1=@Campo1, Campo2=@Campo2, Activo=@Activo WHERE Id=@Id",
    "DELETE FROM dbo.TABLA WHERE Id=@Id");

// Form:
private readonly RepositorioX _repo = new RepositorioX();
private DataTable _dt;
// ctor: InitializeComponent(); ConfigurarColumnas();
private void Cargar() { _dt = _repo.ListarX(); xBindingSource.DataSource = _dt; }
// Load -> Cargar();
// btnNuevo:   AllowUserToAddRows=true; GridColumnas.Edicion(dgv,true); ...
// btnEditar:  GridColumnas.Edicion(dgv,true);
// btnGuardar: int fila=dgv.CurrentRow.Index; dgv.EndEdit(); _repo.GuardarX(_dt);
//             Cargar();  // recarga => el identity nuevo se obtiene aquí
//             if(fila<dgv.RowCount) dgv.CurrentCell=dgv.Rows[fila].Cells[1];
//             GridColumnas.Edicion(dgv,false);
// btnCancelar: Cargar(); GridColumnas.Edicion(dgv,false);
```
Mejora sobre el original: `GuardarCambios` es TRANSACCIONAL (vs `TableAdapter.Update` fila-a-fila).

## 2. Visor / búsqueda — grilla de solo lectura
Grid `ReadOnly=true`. Sin edición → columnas con readOnly por defecto (true). El SELECT/SP puede
llevar parámetros de filtro.

```csharp
public DataTable BuscarX(string texto) =>
    ConsultarTabla("dbo.SP_Buscar", new { texto }, CommandType.StoredProcedure);
// Form: _dt = _repo.BuscarX(txt.Text); xBindingSource.DataSource = _dt;
```

## 3. Maestro-combo + grilla hija por DataRelation (patrón frmSubMenu)
Un combo (maestro) filtra una grilla (hija) por una FK. Replica la relación del DataSet tipado con
un DataSet EN MEMORIA. Las filas nuevas heredan el FK del combo.

```csharp
private DataSet _ds; private DataTable _hijo;
private void Cargar() {
    _ds = new DataSet();
    DataTable padre = _repo.ListarPadre(); padre.TableName = "PADRE";
    _hijo = _repo.ListarHijo();           _hijo.TableName = "HIJO";
    _ds.Tables.Add(padre); _ds.Tables.Add(_hijo);
    _ds.Relations.Add("FK_HIJO_PADRE", padre.Columns["IdPadre"], _hijo.Columns["IdPadre"], false); // createConstraints:false
    padreBindingSource.DataSource = _ds; padreBindingSource.DataMember = "PADRE";
    fkBindingSource.DataSource = padreBindingSource; fkBindingSource.DataMember = "FK_HIJO_PADRE";
    combo.DataSource = padreBindingSource; combo.DisplayMember="..."; combo.ValueMember="IdPadre";
    dgv.DataSource = fkBindingSource;
}
```
⚠️ NO dejes el cableado de la relación en el Designer: en `InitializeComponent` la relación aún no
existe → `ArgumentException "DataMember '...' no se encontró en DataSource"`. Quita del Designer el
`DataMember`/`DataSource` de los BindingSource de la relación y del combo, y arma todo en `Cargar()`.

## 4. Columna combo dentro de la grilla
```csharp
dgv.Columns.Add(GridColumnas.Combo("colId","IdReferencia","Encabezado",
    displayMember:"Texto", valueMember:"Id", readOnly:false));
// En el Load, tras poblar su BindingSource: ((DataGridViewComboBoxColumn)dgv.Columns["colId"]).DataSource = _repo.ListarRef();
```

## 4b. Columna de imagen (firmas/logos/fotos)
Si una columna es `DataGridViewImageColumn` (p.ej. una firma byte[]), usa `GridColumnas.Imagen`:
```csharp
dgv.Columns.Add(GridColumnas.Imagen("Firma","Firma","Firma", DataGridViewImageCellLayout.Stretch));
```
El alta/cambio de imagen suele ir por un `CellDoubleClick` gateado con `dgv.ReadOnly==false`
(que `GridColumnas.Edicion` maneja). `volcar_columnas_grid.ps1` ya emite `Imagen` para estas columnas.

## 5. SP escalar / con parámetros OUTPUT
```csharp
// escalar (ej. verificar/insertar que devuelve 1/0): replica el ExecuteScalar del TableAdapter
public int AccionX(int id) => Escalar<int>("dbo.SP_Accion", new { Id = id }, CommandType.StoredProcedure);

// OUTPUT:
var p = new DynamicParameters();
p.Add("@Entrada", valor);
p.Add("@Salida", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 50);
Ejecutar("dbo.SP", p, CommandType.StoredProcedure);
var salida = p.Get<string>("@Salida");
```

## Reportes RDLC
Reemplaza `dsTipado.TABLA` (que el TableAdapter llenaba) por DataTables del repo, pasados al
`ReportDataSource` por NOMBRE (el nombre del dataset del RDLC, no el de la tabla):
```csharp
rdlc.DataSources.Clear();
rdlc.DataSources.Add(new ReportDataSource("DsX", _repo.CargarX(id)));   // por asociado/filtro
```
Quita los `TableAdapter.FillBy*(...)` posteriores (ya no hacen falta).

## Elegir el repositorio (regla del usuario)
Por la BD/dominio REAL del dato, no por el DataSet: `TR_*`→Transporte, `COD_/SAC/covibase`→Codeas,
`FAC_*`→FAC, `IN_*`→Inventario, `OC_/CP_/OCWeb`→OC. Si un form cruza dominios, reparte los métodos
entre repos. Reutiliza métodos existentes si el SELECT/SP coincide.
