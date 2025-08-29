# Incidentes Backend

Este repositorio contiene la soluci�n para la gesti�n de incidentes, desarrollada en .NET 8. Incluye los siguientes proyectos:

- **LogicaNegocio**: Contiene la l�gica de negocio y modelos de las entidades.
- **Infraestructura**: Implementa la persistencia de datos utilizando Entity Framework Core.
- **Incidentes.Api**: API RESTful para exponer los servicios de gesti�n de incidentes.

## Estructura de Carpetas
- `src/LogicaNegocio`: L�gica de negocio, modelos y servicios.
- `src/Infraestructura`: Persistencia y acceso a datos.
- `src/Incidentes.Api`: Controladores y configuraci�n de la API.

## Requisitos
- .NET 8 SDK
- SQL Server (o base de datos compatible)

## Ejecuci�n
1. Restaurar paquetes NuGet.
2. Aplicar migraciones y actualizar la base de datos.
3. Ejecutar el proyecto `Incidentes.Api` para iniciar la API.
