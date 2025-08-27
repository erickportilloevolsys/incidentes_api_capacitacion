# Incidentes Backend

Este repositorio contiene la solución para la gestión de incidentes, desarrollada en .NET 8. Incluye los siguientes proyectos:

- **LogicaNegocio**: Contiene la lógica de negocio y modelos de las entidades.
- **Infraestructura**: Implementa la persistencia de datos utilizando Entity Framework Core.
- **Incidentes.Api**: API RESTful para exponer los servicios de gestión de incidentes.

## Estructura de Carpetas
- `src/LogicaNegocio`: Lógica de negocio, modelos y servicios.
- `src/Infraestructura`: Persistencia y acceso a datos.
- `src/Incidentes.Api`: Controladores y configuración de la API.

## Requisitos
- .NET 8 SDK
- SQL Server (o base de datos compatible)

## Ejecución
1. Restaurar paquetes NuGet.
2. Aplicar migraciones y actualizar la base de datos.
3. Ejecutar el proyecto `Incidentes.Api` para iniciar la API.
