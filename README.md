# PR2-2026 — Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus  
**Universidad:** Universidad Privada Franz Tamayo  
**Sede:** Cochabamba, Bolivia  
**Asignatura:** Programación II — P2  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

## 1. Descripción del proyecto

El proyecto busca mejorar la organización de citas en barberías y salones de belleza. La gestión manual puede provocar confusión de horarios, reservas superpuestas, pérdida de tiempo al consultar disponibilidad y dificultad para mantener registros ordenados.

Se propone desarrollar una aplicación de escritorio que permita centralizar la información de clientes, profesionales, servicios y citas.

## 2. Objetivo

Desarrollar un sistema de escritorio que facilite el registro y la administración de clientes, profesionales, servicios y citas, incluyendo una validación para evitar que un mismo profesional tenga citas superpuestas.

## 3. Usuarios del sistema

- **Administradores y recepción:** registran clientes, profesionales, servicios y gestionan las citas.
- **Barberos y estilistas:** consultan su agenda.
- **Clientes:** solicitan y reciben sus reservas a través del personal del establecimiento.

## 4. Tecnologías previstas

| Tecnología | Uso |
|---|---|
| C# con .NET Framework | Desarrollo de la aplicación |
| Windows Forms | Interfaz gráfica |
| SQL Server | Almacenamiento de datos |
| ADO.NET (`System.Data.SqlClient`) | Acceso a la base de datos |
| Visual Studio 2022 | Entorno de desarrollo |
| Git y GitHub | Control de versiones y trabajo colaborativo |

## 5. Estado del proyecto

Según el avance documentado por el equipo, la base de datos `SistemaAgendamiento` y la prueba de conexión desde Windows Forms se encuentran realizadas. Los formularios de mantenimiento, la validación de solapamiento de citas y las pruebas deben completarse y documentarse.

**Importante:** el repositorio todavía debe incorporar el proyecto de Visual Studio (`.sln`, `.csproj` y archivos de código) y el script SQL de creación de la base de datos. Hasta que esos archivos estén subidos, una persona que clone únicamente este repositorio no podrá ejecutar la aplicación.

## 6. Estructura del repositorio

```text
/
├── .editorconfig
├── .gitignore
├── README.md
├── documentacion/
│   ├── diagramas/
│   ├── informe/
│   ├── requisitos/
│   ├── GANTT.md
│   ├── GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md
│   └── PLAN_DE_DESARROLLO_Y_RIESGOS.md
├── entregables/
├── equipo/
├── presentacion/
├── pruebas/
│   ├── casos-prueba/
│   └── evidencias/
└── sistema/
    ├── base-datos/
    ├── codigo/
    └── recursos/
```

### ¿Qué debe guardarse en cada carpeta?

| Carpeta | Contenido |
|---|---|
| `documentacion/requisitos` | Requisitos funcionales, no funcionales y alcance |
| `documentacion/diagramas` | Diagramas de casos de uso, clases, actividades y modelo de datos |
| `documentacion/informe` | Informe técnico y documentos finales |
| `equipo` | Integrantes y responsabilidades |
| `presentacion` | Material para exposiciones |
| `sistema/codigo` | Solución de Visual Studio, proyectos y código fuente |
| `sistema/base-datos` | Scripts SQL para crear y preparar la base de datos |
| `sistema/recursos` | Imágenes, iconos y otros recursos de la aplicación |
| `pruebas/casos-prueba` | Plan y resultados de pruebas |
| `pruebas/evidencias` | Capturas de pantalla y evidencias de ejecución |
| `entregables` | Versiones finales solicitadas para la entrega |

## 7. Equipo y responsabilidades

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Diseño de base de datos, conexión ADO.NET y acceso a datos |
| Leonor Alejandra Almanza Arroyo | Diseño de formularios, interfaz de usuario y validaciones visuales |
| Jairo Damian Rodríguez Huanca | Casos de prueba, evidencias y documentación |
| Todo el equipo | Definición del alcance, integración y revisión |

## 8. Requisitos para ejecutar

- Windows 10 o superior.
- Visual Studio 2022 con la carga de trabajo de desarrollo de escritorio con .NET.
- SQL Server instalado y en funcionamiento.
- Versión de .NET Framework compatible con el proyecto.

## 9. Preparación y ejecución

Cuando el equipo incorpore la solución y el script SQL al repositorio:

1. Clonar el repositorio.
2. Abrir la solución `.sln` ubicada en `sistema/codigo`.
3. Crear la base de datos utilizando el script ubicado en `sistema/base-datos`.
4. Revisar la cadena de conexión en la clase `ConexionBD`.
5. Compilar y ejecutar desde Visual Studio.

No se debe publicar una cadena de conexión con contraseñas ni otros datos privados. Cada integrante debe configurar sus datos locales.

## 10. Trabajo colaborativo

- Realizar cambios pequeños y guardar avances con mensajes de commit descriptivos.
- No subir carpetas generadas por Visual Studio como `.vs`, `bin` y `obj`.
- No subir contraseñas, credenciales ni cadenas de conexión privadas.
- Antes de modificar archivos compartidos, revisar los cambios recientes del equipo.
- Mantener actualizados el README, la documentación y las evidencias.
