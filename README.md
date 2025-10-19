# Proyecto ASP.NET

Aplicación web moderna construida con ASP.NET Core Razor Pages, Entity Framework Core y SQL Server LocalDB. El proyecto sirve como laboratorio para practicar CRUD, autenticación con Identity y despliegue automatizado hacia Azure mediante GitHub Actions.

## Requisitos

- .NET SDK 9
- SQL Server Express LocalDB
- Visual Studio Code

## Ejecución local

```bash
dotnet ef database update
dotnet run
```

Accede a `https://localhost:7247/Products` para gestionar productos (requiere autenticación con Identity).
