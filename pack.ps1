$ErrorActionPreference = "Stop"
$mainFolder = Resolve-Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)
$paketExe = "$mainFolder\.paket\paket.exe"

Remove-Item $mainFolder\Release -recurse -force -ErrorAction 0
& "$paketExe" pack $mainFolder\Release
if ($lastexitcode -ne 0) { throw "Error in packet" }
