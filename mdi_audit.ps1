$root = "C:\Users\jportillo\Dropbox\Desarrollo ADI (DEV)\ADIPROJECTS\ADIGGM"
$files = Get-ChildItem -Path $root -Recurse -Filter *.cs | Where-Object { $_.FullName -notlike '*\bin\*' -and $_.FullName -notlike '*\obj\*' }
$forms = New-Object System.Collections.Generic.HashSet[string]
foreach ($f in $files) {
  $t = [System.IO.File]::ReadAllText($f.FullName)
  foreach ($m in [regex]::Matches($t, 'public partial class ([A-Za-z0-9_]+)\s*:\s*([A-Za-z0-9_.]+)')) {
    $base = $m.Groups[2].Value.Split('.')[-1]
    if ($base -eq 'FrmPrincipal' -or $base -eq 'FrmMantenimiento' -or $base -eq 'Form') { [void]$forms.Add($m.Groups[1].Value) }
  }
}
[void]$forms.Remove('FrmPrincipal'); [void]$forms.Remove('FrmMantenimiento')
$mdi = [System.IO.File]::ReadAllText("$root\Formularios Base\MdiPrincipal.cs")
$mdiOpen = @{}
foreach ($m in [regex]::Matches($mdi, 'new\s+([A-Za-z0-9_.]+)\s*[\(\{]')) {
  $n = $m.Groups[1].Value.Split('.')[-1]
  if ($forms.Contains($n)) { if ($mdiOpen.ContainsKey($n)) { $mdiOpen[$n]++ } else { $mdiOpen[$n] = 1 } }
}
$openedElsewhere = New-Object System.Collections.Generic.HashSet[string]
foreach ($f in $files) {
  if ($f.Name -like '*.Designer.cs') { continue }
  if ($f.Name -eq 'MdiPrincipal.cs') { continue }
  $t = [System.IO.File]::ReadAllText($f.FullName)
  foreach ($m in [regex]::Matches($t, 'new\s+([A-Za-z0-9_.]+)\s*[\(\{]')) {
    $n = $m.Groups[1].Value.Split('.')[-1]
    if ($forms.Contains($n)) { [void]$openedElsewhere.Add($n) }
  }
}
Write-Output ("TOTAL forms: " + $forms.Count + " | abiertos por MDI: " + $mdiOpen.Count)
Write-Output ""
Write-Output "=== REPETIDOS en el MDI (>1 manejador) ==="
$rep = $mdiOpen.GetEnumerator() | Where-Object { $_.Value -gt 1 } | Sort-Object Value -Descending
if ($rep) { $rep | ForEach-Object { Write-Output ("  " + $_.Key + "  x" + $_.Value) } } else { Write-Output "  (ninguno)" }
Write-Output ""
Write-Output "=== NO en MDI pero SE ABREN desde otro form (hijos/dialogos, OK) ==="
Write-Output (($forms | Where-Object { -not $mdiOpen.ContainsKey($_) -and $openedElsewhere.Contains($_) } | Sort-Object) -join ', ')
Write-Output ""
Write-Output "=== NO se abren en NINGUN lado (huerfanos / posible muerto) ==="
Write-Output (($forms | Where-Object { -not $mdiOpen.ContainsKey($_) -and -not $openedElsewhere.Contains($_) } | Sort-Object) -join ', ')
