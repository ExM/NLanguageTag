$ErrorActionPreference = "Stop"
$mainFolder = Resolve-Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)
$nugetExe = "$mainFolder\packages\NuGet.CommandLine.2.8.5\tools\nuget.exe"

Remove-Item $mainFolder\*.nupkg
& "$nugetExe" pack $mainFolder/LanguageTag/LanguageTag.csproj -Build -Properties Configuration=Release