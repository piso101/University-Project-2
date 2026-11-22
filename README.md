# StoMaToLogiczne

A Windows Forms dental-clinic appointment project built with .NET Framework 4.8.

## Requirements

- Visual Studio with .NET Framework 4.8 developer tools
- SQL Server LocalDB
- NuGet package restore for the solution

Open `ProjektProgramowanie2Dentysta.sln` in Visual Studio and restore NuGet packages before building.

## Database configuration

The projects use a local-only SQL Server connection by default:

```text
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoMaToLogiczne;Integrated Security=True
```

Update the connection string in each project's `App.config` to use your own database. Do not commit credentials or connection strings containing secrets. The required database and schema must be available locally before running the application.
