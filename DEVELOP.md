# Development
Generate source code by saved language-subtag-registry
```
dotnet run --project ./SourceCodeRenderer/SourceCodeRenderer.csproj -- -i ./DataSources -o ./NLanguageTag/Generated
```

Update language-subtag-registry and generate source code
```
dotnet run --project ./SourceCodeRenderer/SourceCodeRenderer.csproj -- -un -i ./DataSources -o ./NLanguageTag/Generated
```

Restore dependencies
```
dotnet restore
```

Build
```
dotnet build -c:Release
```

Run test
```
dotnet test -c:Release
```

Pack
```
dotnet pack -c Release -o ./Release
```