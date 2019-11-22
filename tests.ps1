$ErrorActionPreference = "Stop"
$mainFolder = Resolve-Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)

& dotnet test $mainFolder/NLanguageTag.Tests/NLanguageTag.Tests.csproj -v d
