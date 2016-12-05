$ErrorActionPreference = "Stop"
$mainFolder = Resolve-Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)

Remove-Item $mainFolder\*.nupkg
& "$mainFolder\.paket\paket.exe" pack output "$mainFolder"

