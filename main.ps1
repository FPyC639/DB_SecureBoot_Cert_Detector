Set-Location -Path $PSScriptRoot
$array = (Get-SecureBootUEFI -Name db).bytes
$count = $array.Count
$chunks = @()
$startIndex = 0
$baseSize = 1547
$cssize = [Math]::Floor($count/$baseSize)

# Loop to create chunks
for ($i = 0; $i -lt $cssize; $i++) {
    $chunkSize = $baseSize
    if ($i -lt $remainder) {
        $chunkSize += 1  # Add 1 to handle the remainder
    }
    $chunks += ,@($array[$startIndex..($startIndex + $chunkSize - 1)])
    $startIndex += $chunkSize
}
$startIndex = 0
foreach($a in $chunks){
    $startIndex += 1
    $a | Out-File "Output$startIndex.dat"
}