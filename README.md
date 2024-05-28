### Tecnologias y Paquetes NuGet en uso

.NET 7.0 - MySQL

Project 'Dominio' has the following package references
   [net7.0]:
   Top-level Package                    Requested   Resolved

> FluentValidation.AspNetCore        11.3.0      11.3.0
> itext7.pdfhtml                     5.0.1       5.0.1
> Microsoft.EntityFrameworkCore      7.0.10      7.0.10

Project 'Persistencia' has the following package references
   [net7.0]:
   Top-level Package                       Requested   Resolved

> Microsoft.EntityFrameworkCore         7.0.10      7.0.10
> Pomelo.EntityFrameworkCore.MySql      7.0.0       7.0.0


## Documentacion - Preparacion para usar el proyecto

1. Abrir el proyecto y configurar el connectionString en appsetting.json 
    con las credenciales de la instancia local de su cliente MySQl


2. ejecutar los comandos
```
dotnet build
dotnet ef migrations add MigrationTest --project ./Persistencia/ --startup-project ./API/ --output-dir ./Data/Migrations
```
3. Crear los registros de los roles basicos necesarios en la base de datos. 

```
INSERT INTO pruebaudes.roles (Descripcion) VALUES
('Administrador'),
('Gerente'),
('Empleado');
```

4. Ejecute el comando para testear los endpoints en Swagger
```
    dotnet watch --project .\API\
```