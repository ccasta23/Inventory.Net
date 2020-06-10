# Proyecto para gestión de inventario

En este proyecto se trabajó en el framework .Net Core V 3.1 usando blazor.

## Puesta en funcionamiento del Proyecto

Para poner en funcionamiento este proyecto en su entorno local siga las siguientes instrucciones.

### Prerequisitos

- Tener instalado .Net Core. [Documentación Oficial](https://dotnet.microsoft.com/download)
- Tener instalado el IDE Visual Studio 2019. [Descarga del sitio oficial](https://dotnet.microsoft.com/download)
- Tener acceso a una base de datos SQLServer o instalarla directamente en su entorno. [Descarga Oficial](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)

### Configuración inicial

Luego de clonar el repositorio en su entorno local, seguir los siguientes pasos.

1. Abrir el Proyecto en Visual Studio Code 2019
2. Configurar su conexión a la base de datos. Debe ir al proyecto DataAccess, archivo InventoryContext.cs y modificar la línea `options.UseSqlServer("Server=SERVER-NAME;Database=InventoryDb;User Id=USER;Password=PASSWORD");` con los valores que correspondan a su conexión de base de datos.
3. Ejecutar la migración, para esto debe abrir la Consola del Administrador de paquetes y ejecutar el comando `update-database -s DataAccess`.
4. Correr el proyecto y probar su funcionalidad (Control + F5). 
