# PR2-2026 — Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus
**Universidad:** Universidad Privada Franz Tamayo
**Sede:** Cochabamba, Bolivia
**Asignatura:** Programación II — P2
**Docente:** Ing. Diego Patrick Cárdenas Sejas

---

##  1. Descripción del problema

El proyecto aborda las dificultades que presentan las barberías y salones al organizar sus citas de forma manual: confusión de horarios, reservas superpuestas, pérdida de tiempo al consultar disponibilidad y dificultad para mantener registros ordenados. Se realizó una observación inicial en negocios del rubro que confirma que la gestión manual de agendas es una necesidad real y frecuente.

##  2. Propósito

Desarrollar una aplicación de escritorio que centralice clientes, profesionales, servicios y citas, con una validación de disponibilidad que impida guardar citas superpuestas para un mismo profesional.

##  3. Usuarios

- **Administradores y personal de recepción:** registrar clientes, gestionar profesionales, servicios y reservar/modificar/cancelar citas.
- **Barberos y estilistas:** consultar su agenda diaria.
- **Clientes:** reciben una reserva registrada por el personal.

##  4. Estado actual del proyecto

> ** En desarrollo — Conexión base de datos ↔ aplicación: FUNCIONANDO**

###  Logros alcanzados:
-  Base de datos `SistemaAgendamiento` creada en SQL Server
-  Tablas definidas: `Cliente`, `Profesional`, `Servicio`, `Cita`
-  Clase `ConexionBD` implementada con cadena de conexión
-  Prueba de conexión exitosa desde Windows Forms hacia SQL Server
-  Entorno de desarrollo configurado y funcional en todos los equipos

###  En progreso:
-  Formularios de mantenimiento de datos
-  Lógica de validación de solapamiento de citas
-  Casos de prueba completos

##  5. Tecnologías utilizadas

| Tecnología | Versión/Entorno | Uso |
|---|---|---|
| C# | .NET Framework | Lógica de la aplicación |
| Windows Forms | Visual Studio | Interfaz de escritorio |
| SQL Server | Local | Motor de base de datos |
| ADO.NET (`System.Data.SqlClient`) | — | Conexión con la base de datos |
| Visual Studio 2022 | Community/Pro | Entorno de desarrollo |
| GitHub | — | Control de versiones y respaldo |

##  6. Estructura de la base de datos

**Tablas creadas:**
- `Cliente` — Datos personales de los clientes
- `Profesional` — Información del personal del salón
- `Servicio` — Catálogo de servicios ofrecidos con precio y duración
- `Cita` — Registro de reservas con fecha, hora, cliente, profesional y servicio

##  7. Equipo y responsabilidades

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Diseño de base de datos, clase de conexión ADO.NET y acceso a datos |
| Leonor Alejandra Almanza Arroyo | Diseño de formularios, interfaz de usuario y validaciones visuales |
| Jairo Damian Rodríguez Huanca | Casos de prueba, evidencias de ejecución y documentación del proyecto |
| Todo el equipo | Definición de alcance, integración de módulos y revisión general |

##  8. Cómo ejecutar el proyecto

### Requisitos previos:
1. Windows 10 o superior
2. Visual Studio 2022 con carga de trabajo "Desarrollo de escritorio con .NET"
3. SQL Server instalado y corriendo localmente
4. .NET Framework instalado

### Pasos de configuración:
1. Clonar o descargar el repositorio
2. Abrir `SistemaAgendamiento.sln` con Visual Studio
3. Verificar/actualizar la cadena de conexión en `ConexionBD.cs` según tu instancia de SQL Server:
   ```csharp
   private string cadenaConexion = @"Data Source=NOMBRE_SERVIDOR;Initial Catalog=SistemaAgendamiento;Integrated Security=True";
