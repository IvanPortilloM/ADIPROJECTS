# Extrae el SQL de un TableAdapter de un DataSet tipado (.xsd) sin leer el archivo entero.
# Uso: extraer_sql_xsd.ps1 -Xsd "ADIGGM\DataSets\DsOC.xsd" -Tabla "CP_TipoDocumentos"
# Devuelve: conexión del adapter, cada FillMethod (Fill/FillByX) con tipo+params+CommandText,
# y los comandos INSERT/UPDATE/DELETE. Útil para armar Listar/Guardar y los SP del repo.
#
# MODO LISTADO (sin -Tabla): inventaría TODO el XSD — cada TableAdapter con sus FillMethods, y
# cada consulta/SP suelta (DbSource con Name=, sin FillMethodName: las funciones tipo
# OC_AsigCuentasOpciones que consumen los VarGlobales.consultas*). Úsalo ANTES de migrar un form
# grande (Tran*/Vis*) para dimensionar qué adapters/SPs toca.
param(
  [Parameter(Mandatory = $true)][string]$Xsd,
  [string]$Tabla = ""
)
if (-not (Test-Path $Xsd)) { Write-Output "ERROR: no existe $Xsd"; exit 1 }
$txt = [System.IO.File]::ReadAllText($Xsd)

if (-not $Tabla) {
  # ---- MODO LISTADO ----
  foreach ($ta in [regex]::Matches($txt, '<TableAdapter[^>]*\sName="(?<n>[^"]*)"[^>]*>(?<b>.*?)</TableAdapter>', 'Singleline')) {
    $fills = @(); $sueltas = @()
    foreach ($s in [regex]::Matches($ta.Groups['b'].Value, '<DbSource\b[^>]*>', 'Singleline')) {
      $tag = $s.Value
      $fm = [regex]::Match($tag, 'FillMethodName="([^"]*)"').Groups[1].Value
      if ($fm) { $fills += $fm; continue }
      $nm = [regex]::Match($tag, '\sName="([^"]*)"').Groups[1].Value
      if ($nm) {
        $tipo = [regex]::Match($tag, 'DbObjectType="([^"]*)"').Groups[1].Value
        $qt = [regex]::Match($tag, 'QueryType="([^"]*)"').Groups[1].Value
        $sueltas += "$nm [$tipo/$qt]"
      }
    }
    Write-Output ("TableAdapter " + $ta.Groups['n'].Value + "  Fills=[" + ($fills -join ', ') + "]")
    foreach ($q in $sueltas) { Write-Output ("    query: " + $q) }
  }
  # Consultas/SP "sueltas" del DataSet (las funciones globales que consumen los
  # VarGlobales.consultas*): viven en el <Sources> de nivel superior, DESPUÉS de </Tables>.
  $glob = [regex]::Match($txt, '</Tables>\s*<Sources>(?<g>.*?)</Sources>', 'Singleline')
  if ($glob.Success) {
    Write-Output ""
    Write-Output "=== Consultas/SP sueltas (VarGlobales.consultas*) ==="
    foreach ($s in [regex]::Matches($glob.Groups['g'].Value, '<DbSource\b[^>]*\sName="(?<n>[^"]*)"[^>]*>')) {
      $tag = $s.Value
      $tipo = [regex]::Match($tag, 'DbObjectType="([^"]*)"').Groups[1].Value
      $qt = [regex]::Match($tag, 'QueryType="([^"]*)"').Groups[1].Value
      Write-Output ("  " + $s.Groups['n'].Value + " [" + $tipo + "/" + $qt + "]")
    }
  }
  exit 0
}
$m = [regex]::Match($txt, '<TableAdapter[^>]*\sName="' + [regex]::Escape($Tabla) + '"[^>]*>(?<b>.*?)</TableAdapter>', 'Singleline')
if (-not $m.Success) { Write-Output "ERROR: no se encontró el TableAdapter Name=`"$Tabla`" en $Xsd"; exit 1 }
$b = $m.Groups['b'].Value

$conn = [regex]::Match($b, 'ConnectionRef="([^"]*)"').Groups[1].Value
if (-not $conn) { $conn = [regex]::Match($txt, '<Connection [^>]*Name="([^"]*)"').Groups[1].Value }
Write-Output "############### $Tabla  (ConnectionRef=$conn) ###############"

# FillMethods (Fill / FillByXxx): se toma el <SelectCommand> del DbSource (en estos XSD el
# DeleteCommand suele ir primero, así que NO basta con el primer <CommandText> del bloque).
foreach ($s in [regex]::Matches($b, '<DbSource[^>]*\sFillMethodName="(?<fm>[^"]*)"[^>]*>(?<sb>.*?)</DbSource>', 'Singleline')) {
  $sel = [regex]::Match($s.Groups['sb'].Value, '<SelectCommand>(?<sc>.*?)</SelectCommand>', 'Singleline')
  $scope = if ($sel.Success) { $sel.Groups['sc'].Value } else { $s.Groups['sb'].Value }
  $ct = [regex]::Match($scope, '<CommandText>(?<q>.*?)</CommandText>', 'Singleline')
  if (-not $ct.Success) { continue }
  $q = [System.Net.WebUtility]::HtmlDecode($ct.Groups['q'].Value).Trim()
  $ps = ([regex]::Matches($scope, 'ParameterName="(?<p>[^"]+)"') | ForEach-Object { $_.Groups['p'].Value }) -join ', '
  $tp = [regex]::Match($scope, '<DbCommand CommandType="(?<t>[^"]+)"').Groups['t'].Value
  Write-Output ("--- FillMethod: " + $s.Groups['fm'].Value + "  [" + $tp + "]  params=[" + $ps + "] ---")
  Write-Output $q
  Write-Output ""
}

# INSERT / UPDATE / DELETE (DbCommands de acción del adapter de mantenimiento)
foreach ($c in [regex]::Matches($b, '<DbCommand[^>]*>(?<cb>.*?)</DbCommand>', 'Singleline')) {
  $ct = [regex]::Match($c.Groups['cb'].Value, '<CommandText>(?<q>.*?)</CommandText>', 'Singleline')
  if (-not $ct.Success) { continue }
  $q = [System.Net.WebUtility]::HtmlDecode($ct.Groups['q'].Value).Trim()
  $mm = [regex]::Match($q, '^\s*(INSERT|UPDATE|DELETE)\b', 'IgnoreCase')
  if ($mm.Success) {
    Write-Output ("=== " + $mm.Groups[1].Value.ToUpper() + " ===")
    Write-Output $q
    Write-Output ""
  }
}
