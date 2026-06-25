# Vuelca las columnas de un DataGridView del .Designer.cs como llamadas GridColumnas.*
# listas para pegar en ConfigurarColumnas(). Preserva orden, Name, DataPropertyName,
# HeaderText, Visible, Format (de su cellStyle), Width y AutoSizeMode.
# Uso: volcar_columnas_grid.ps1 -Designer "ADIGGM\OC\Mantenimiento\ManTipoDocumento.Designer.cs" -Grid "dgvTipoDocumentos"
# OJO: las columnas CheckBox salen como GridColumnas.Check (resto Texto). Si el grid es de
# mantenimiento EDITABLE, agrega readOnly:false a mano sólo en las columnas que el usuario edita
# (o deja el default true y togglea con GridColumnas.Edicion). Revisa la salida.
param(
  [Parameter(Mandatory = $true)][string]$Designer,
  [Parameter(Mandatory = $true)][string]$Grid
)
if (-not (Test-Path $Designer)) { Write-Output "ERROR: no existe $Designer"; exit 1 }
$text = [System.IO.File]::ReadAllText($Designer)
$addRange = [regex]::Escape("this.$Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {")
$m = [regex]::Match($text, $addRange + "(?<body>.*?)\}\);", 'Singleline')
if (-not $m.Success) { Write-Output "ERROR: no se encontró '$Grid.Columns.AddRange' en $Designer"; exit 1 }
$cols = [regex]::Matches($m.Groups['body'].Value, 'this\.(\w+)') | ForEach-Object { $_.Groups[1].Value }
Write-Output "// $Grid : $($cols.Count) columnas"

$decls = @{}
foreach ($d in [regex]::Matches($text, 'this\.(\w+) = new System\.Windows\.Forms\.(DataGridView\w+Column)\(\)')) { $decls[$d.Groups[1].Value] = $d.Groups[2].Value }

foreach ($c in $cols) {
  $dp = [regex]::Match($text, [regex]::Escape("this.$c.DataPropertyName = ") + '"([^"]*)";').Groups[1].Value
  $h = [regex]::Match($text, [regex]::Escape("this.$c.HeaderText = ") + '"([^"]*)";').Groups[1].Value
  $visM = [regex]::Match($text, [regex]::Escape("this.$c.Visible = ") + '([^;]+);')
  $vis = -not ($visM.Success -and $visM.Groups[1].Value -eq 'false')
  $w = [regex]::Match($text, [regex]::Escape("this.$c.Width = ") + '([0-9]+);')
  $asM = [regex]::Match($text, [regex]::Escape("this.$c.AutoSizeMode = ") + 'System\.Windows\.Forms\.DataGridViewAutoSizeColumnMode\.(\w+);')
  $csN = [regex]::Match($text, [regex]::Escape("this.$c.DefaultCellStyle = ") + '(\w+);').Groups[1].Value
  $fmt = ''
  if ($csN) { $fmt = [regex]::Match($text, [regex]::Escape("$csN.Format = ") + '"([^"]*)";').Groups[1].Value }
  $isCheck = $decls[$c] -like '*CheckBox*'
  $head = if ($isCheck) { 'GridColumnas.Check(' } else { 'GridColumnas.Texto(' }
  $args = "`"$c`", `"$dp`", `"$h`""
  if (-not $isCheck -and $fmt) { $args += ", format: `"$fmt`"" }
  if (-not $vis) { $args += ", visible: false" }
  if ($w.Success) { $args += ", width: " + $w.Groups[1].Value }
  if ($asM.Success) { $args += ", autoSize: DataGridViewAutoSizeColumnMode." + $asM.Groups[1].Value }
  Write-Output ("            $Grid.Columns.Add($head$args));")
}

# cellStyles de GRID (NO de columna) que hay que CONSERVAR en el Designer
$gridCS = [regex]::Matches($text, "this\.$Grid\.(\w*CellStyle\w*) = (dataGridViewCellStyle\d+);") | ForEach-Object { $_.Groups[2].Value } | Sort-Object -Unique
Write-Output ("// cellStyles de GRID a conservar: " + (($gridCS) -join ', '))
$ro = [regex]::Match($text, "this\.$Grid\.ReadOnly = (\w+);")
Write-Output ("// " + $Grid + ".ReadOnly de diseño = " + $(if ($ro.Success) { $ro.Groups[1].Value } else { '(no seteado => false/editable)' }))
