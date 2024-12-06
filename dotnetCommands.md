## create global json file
- dotnet new globaljson --sdk-version "desire .Net version example: 9.0.100-preview.2.24157.14" --force

## create solution
- dotnet new sln --name "projectName example: MasterNet"

## create webapi project
- dotnet new webapi -o "Desire path for project example: src/MasterNet.WebApi" --name "name for project example: MasterNet.WebApi"

## add project to solution
- sln add "path to the project to add example: .\src\MasterNet.WebApi\MasterNet.WebApi.csproj"

## adding another project or libreria
- dotnet new classlib -o "desire path example: src/MasterNet.Domain"

## adding dependency/reference from a project to another
- dotnet add "class that require the dependency, example: src/MasterNet.Persistence/MasterNet.Persistence.csproj"
    reference "target class, example: src/MasterNet.Domain/MasterNet.Domain.csproj"
## migrations with dotnet-ef
- dotnet ef migrations add "desire name example: MigracionInicial"
