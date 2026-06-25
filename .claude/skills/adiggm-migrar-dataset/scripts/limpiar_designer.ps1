# Limpia un .Designer.cs tras migrar el form a Dapper: borra el DataSet tipado, los
# TableAdapters, las columnas del grid (creación/config/AddRange/campos/comentarios), el
# dgv.DataSource de diseño y los cellStyle que queden HUÉRFANOS (sin asignación). CONSERVA
# el BindingSource (sólo le quita su DataMember de diseño si pasas -BindingSource) y los
# cellStyle de GRID (siguen asignados). Verifica el balance de llaves y reporta residuos.
#
# Uso:
#   limpiar_designer.ps1 -Designer "<ruta>.Designer.cs" -Grid "dgvX" -DataSet "dsOC" `
#       -Cols "col1,col2,col3" [-BindingSource "xBindingSource"] [-WhatIf]
#
# Notas:
# - -Cols son los NOMBRES DE CAMPO de las columnas (los que devuelve volcar_columnas_grid /
#   aparecen en el AddRange), case-sensitive. Las auto-generadas suelen ser
#   "<algo>DataGridViewTextBoxColumn" con d MINÚSCULA — cópialas exactas.
# - Hace copia .bak antes de escribir. Con -WhatIf sólo reporta, no escribe.
param(
  [Parameter(Mandatory = $true)][string]$Designer,
  [Parameter(Mandatory = $true)][string]$Grid,
  [Parameter(Mandatory = $true)][string]$DataSet,
  [Parameter(Mandatory = $true)][string]$Cols,
  [string]$BindingSource = "",
  [switch]$WhatIf
)
if (-not (Test-Path $Designer)) { Write-Output "ERROR: no existe $Designer"; exit 1 }
$bytes = [System.IO.File]::ReadAllBytes($Designer)
$bom = ($bytes.Length -ge 3 -and $bytes[0] -eq 0xEF -and $bytes[1] -eq 0xBB -and $bytes[2] -eq 0xBF)
$lines = [System.IO.File]::ReadAllLines($Designer)
$colSet = @{}; foreach ($c in ($Cols -split ',')) { $cc = $c.Trim(); if ($cc) { $colSet[$cc] = $true } }
$del = New-Object 'System.Collections.Generic.HashSet[int]'
$reConfig = '^\s*this\.(\w+)\.'
$reCreate = '^\s*this\.(\w+) = new System\.Windows\.Forms\.DataGridView\w+Column\(\);'
$reField  = '^\s*private System\.Windows\.Forms\.DataGridView\w+Column (\w+);'
$reCmt    = '^\s*//\s*(\S.*?)\s*$'
$reBare   = '^\s*//\s*$'
$reAddRange = "this\.$([regex]::Escape($Grid))\.Columns\.AddRange\(new"
$reGridDS = "^\s*this\.$([regex]::Escape($Grid))\.DataSource\s*="
$reBsDm = if ($BindingSource) { "^\s*this\.$([regex]::Escape($BindingSource))\.DataMember\s*=" } else { $null }

# --- Pasada 1: columnas, DataSet, TableAdapters, grid.DataSource, comentarios ---
$inAdd = $false
for ($i = 0; $i -lt $lines.Count; $i++) {
  $ln = $lines[$i]
  if ($inAdd) { [void]$del.Add($i); if ($ln -match '\}\);') { $inAdd = $false }; continue }
  if ($ln -match $reAddRange) { [void]$del.Add($i); if ($ln -notmatch '\}\);') { $inAdd = $true }; continue }
  if ($ln -match [regex]::Escape($DataSet) -or $ln -match 'TableAdapter') { [void]$del.Add($i); continue }
  if ($ln -match $reGridDS) { [void]$del.Add($i); continue }
  if ($reBsDm -and $ln -match $reBsDm) { [void]$del.Add($i); continue }
  $mm = [regex]::Match($ln, $reConfig); if ($mm.Success -and $colSet.ContainsKey($mm.Groups[1].Value)) { [void]$del.Add($i); continue }
  $mm = [regex]::Match($ln, $reCreate); if ($mm.Success -and $colSet.ContainsKey($mm.Groups[1].Value)) { [void]$del.Add($i); continue }
  $mm = [regex]::Match($ln, $reField); if ($mm.Success -and $colSet.ContainsKey($mm.Groups[1].Value)) { [void]$del.Add($i); continue }
  $mm = [regex]::Match($ln, $reCmt); if ($mm.Success -and $colSet.ContainsKey($mm.Groups[1].Value)) {
    [void]$del.Add($i)
    if ($i - 1 -ge 0 -and $lines[$i - 1] -match $reBare) { [void]$del.Add($i - 1) }
    if ($i + 1 -lt $lines.Count -and $lines[$i + 1] -match $reBare) { [void]$del.Add($i + 1) }
    continue
  }
}
# limpiar // huérfanos junto a comentarios borrados que nombran el DataSet/TableAdapter
for ($i = 0; $i -lt $lines.Count; $i++) {
  if ($del.Contains($i) -and $lines[$i] -match $reCmt -and ($lines[$i] -match [regex]::Escape($DataSet) -or $lines[$i] -match 'TableAdapter')) {
    if ($i - 1 -ge 0 -and $lines[$i - 1] -match $reBare) { [void]$del.Add($i - 1) }
    if ($i + 1 -lt $lines.Count -and $lines[$i + 1] -match $reBare) { [void]$del.Add($i + 1) }
  }
}

# --- Pasada 2: cellStyles HUÉRFANOS (declarados pero sin ninguna asignación que sobreviva) ---
# Un cellStyle es de COLUMNA (a borrar) si su única asignación '= dataGridViewCellStyleN;'
# estaba en una línea ya borrada. Si sigue asignado en una línea viva (p.ej. grid.DefaultCellStyle),
# es de GRID y se conserva.
$assignedAlive = @{}
for ($i = 0; $i -lt $lines.Count; $i++) {
  if ($del.Contains($i)) { continue }
  foreach ($a in [regex]::Matches($lines[$i], '=\s*(dataGridViewCellStyle\d+)\s*;')) { $assignedAlive[$a.Groups[1].Value] = $true }
}
for ($i = 0; $i -lt $lines.Count; $i++) {
  if ($del.Contains($i)) { continue }
  $cs = [regex]::Match($lines[$i], '^\s*(?:System\.Windows\.Forms\.DataGridViewCellStyle )?(dataGridViewCellStyle\d+)\b')
  if ($cs.Success -and -not $assignedAlive.ContainsKey($cs.Groups[1].Value)) { [void]$del.Add($i) }
}

$kept = for ($i = 0; $i -lt $lines.Count; $i++) { if (-not $del.Contains($i)) { $lines[$i] } }
$t = ($kept -join "`n")
$open = ([regex]::Matches($t, '\{')).Count; $close = ([regex]::Matches($t, '\}')).Count
Write-Output ("borradas=$($del.Count)  antes=$($lines.Count)  despues=$($kept.Count)")
Write-Output ("llaves: abre=$open cierra=$close  " + $(if ($open -eq $close) { 'OK' } else { '*** DESBALANCE ***' }))
Write-Output ("residual ${DataSet}=" + ([regex]::Matches($t, [regex]::Escape($DataSet))).Count + "  TableAdapter=" + ([regex]::Matches($t, 'TableAdapter')).Count + "  AddRange=" + ([regex]::Matches($t, 'Columns\.AddRange')).Count + "  colFieldDecls=" + ([regex]::Matches($t, 'private System\.Windows\.Forms\.DataGridView\w+Column ')).Count)
if ($BindingSource) { Write-Output ("BindingSource '$BindingSource' conservado: " + ([regex]::Matches($t, [regex]::Escape($BindingSource))).Count + " refs") }

if ($WhatIf) { Write-Output "(-WhatIf: no se escribió nada)"; exit 0 }
if ($open -ne $close) { Write-Output "*** NO se escribió: llaves desbalanceadas. Revisa -Cols (case-sensitive) y corre con -WhatIf. ***"; exit 1 }
Copy-Item -Path $Designer -Destination ($Designer + ".bak") -Force
$enc = New-Object System.Text.UTF8Encoding($bom)
[System.IO.File]::WriteAllText($Designer, $t.Replace("`n", "`r`n") + "`r`n", $enc)
Write-Output "OK escrito (copia previa en $Designer.bak). Si quedó colFieldDecls>0 hay campos de columna HUÉRFANOS (declarados pero nunca usados): bórralos a mano."
