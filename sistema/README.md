# Sistema

Esta carpeta contiene los archivos versionados para preparar y desarrollar la aplicación.

## Estructura
- `codigo/`: solución de Visual Studio, proyecto C# y código fuente.
- `base-datos/`: scripts SQL para crear la base de datos.
- `recursos/`: imágenes, iconos y otros recursos de la interfaz.

## Archivos disponibles
- `codigo/SistemaAgendamiento.sln`: solución para Visual Studio.
- `codigo/SistemaAgendamiento/SistemaAgendamiento.csproj`: proyecto Windows Forms para .NET Framework 4.8.
- `codigo/SistemaAgendamiento/Program.cs`: punto de entrada.
- `codigo/SistemaAgendamiento/Forms/FrmMenu.cs`: menú inicial; sus botones están deshabilitados.
- `codigo/SistemaAgendamiento/Datos/ConexionBD.cs`: helper de conexión ADO.NET.
- `codigo/SistemaAgendamiento/App.config`: cadena de conexión de ejemplo/local.
- `base-datos/01_Crear_Base_Datos.sql`: script de creación de la base y sus cuatro tablas.

## Preparación
1. Abrir la solución en Visual Studio 2022.
2. Ejecutar el script SQL en SQL Server Management Studio.
3. Adaptar `Data Source` en `App.config` a la instancia local.
4. Compilar y ejecutar desde Visual Studio.

La ejecución debe comprobarse en cada entorno. La presencia del script y de la clase de conexión no demuestra por sí sola que la base de datos esté creada ni que la persistencia de los módulos funcione.

## Estado de implementación
La solución contiene un menú inicial y un helper de conexión. Los formularios CRUD, las consultas de negocio, la agenda y la validación de solapamientos siguen pendientes.

**Decisión pendiente del modelo:** el esquema actual no relaciona SERVICIO con CITA. Si el requisito exige guardar el servicio elegido para cada cita, el equipo debe acordar una modificación del modelo y del script SQL antes de implementar esa operación.

No guardar aquí carpetas generadas como `.vs`, `bin` u `obj`.
