# PR2-2026 — Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus  
**Universidad:** Universidad Privada Franz Tamayo  
**Sede:** Cochabamba, Bolivia  
**Asignatura:** Programación II  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

## 1. Descripción y problema

El proyecto consiste en una aplicación de escritorio para apoyar la organización de clientes, profesionales, servicios y citas en barberías y salones de belleza. La gestión manual puede provocar confusión de horarios, reservas superpuestas y pérdida de información.

## 2. Objetivo

Desarrollar un sistema que centralice la información principal del establecimiento y facilite la administración de citas, incluyendo la validación de disponibilidad de los profesionales.

## 3. Usuarios

- **Administradores y recepción:** registran clientes, profesionales, servicios y gestionan citas.
- **Barberos y estilistas:** consultan su agenda.
- **Clientes:** solicitan reservas mediante el personal del establecimiento.

## 4. Equipo y responsabilidades

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Coordinación técnica, base de datos y acceso a datos |
| Leonor Alejandra Almanza Arroyo | Formularios, interfaz y validaciones visuales |
| Jairo Damian Rodríguez Huanca | Pruebas, evidencias y documentación |
| Todo el equipo | Integración, revisión y decisiones de alcance |

## 5. Tecnologías y entorno

| Tecnología | Uso |
|---|---|
| C# | Lenguaje de programación |
| .NET Framework 4.8 | Plataforma del proyecto publicado |
| Windows Forms | Interfaz de escritorio |
| SQL Server | Base de datos relacional |
| ADO.NET / System.Data.SqlClient | Acceso a datos |
| Visual Studio 2022 | Entorno de desarrollo |
| Git y GitHub | Control de versiones |

## 6. Estado y funcionalidades

El alcance de datos actual contiene cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA. El repositorio incluye la solución inicial de Windows Forms, el menú, la clase de conexión ADO.NET y el script de creación de la base de datos. Los módulos de mantenimiento, la integración completa, la validación de solapamientos y las pruebas deben considerarse terminados únicamente cuando se encuentren implementados, ejecutados y documentados.

## 7. Estructura del repositorio

Se conserva la carpeta documentacion/ como equivalente funcional de docs/ para evitar duplicar documentos y romper rutas existentes.

| Ruta | Contenido |
|---|---|
| .editorconfig, .gitignore | Convenciones y exclusiones |
| documentacion/ | Visión, requisitos, arquitectura, modelo de datos, planificación y diagramas |
| equipo/ | Integrantes y responsabilidades |
| sistema/codigo/ | Solución de Visual Studio y código C# |
| sistema/base-datos/ | Scripts SQL |
| sistema/recursos/ | Recursos de la aplicación |
| pruebas/ | Casos de prueba y evidencias |
| presentacion/ | Material para exposición |
| entregables/ | Archivos finales solicitados |
| .github/ | Plantillas de incidencias y pull requests |

## 8. Requisitos previos

- Windows 10 o superior.
- Visual Studio 2022 con desarrollo de escritorio de .NET.
- .NET Framework 4.8.
- SQL Server y SQL Server Management Studio (SSMS).
- Git.

## 9. Instalación, configuración y ejecución

1. Clonar este repositorio.
2. Abrir sistema/codigo/SistemaAgendamiento.sln en Visual Studio.
3. Ejecutar sistema/base-datos/01_Crear_Base_Datos.sql en SSMS.
4. Revisar sistema/codigo/SistemaAgendamiento/App.config y adaptar Data Source al nombre de la instancia local de SQL Server.
5. Compilar la solución y ejecutar desde Visual Studio.

La cadena incluida usa autenticación integrada como configuración de ejemplo. Cada integrante debe adaptarla a su entorno. No se deben subir contraseñas ni credenciales privadas.

## 10. Documentación

- [Visión y alcance](documentacion/vision-y-alcance.md)
- [Requisitos y criterios](documentacion/requisitos/REQUISITOS_Y_CRITERIOS.md)
- [Alcance del MVP](documentacion/requisitos/ALCANCE_MVP.md)
- [Arquitectura y modelo de datos](documentacion/diagramas/ARQUITECTURA_Y_DATOS.md)
- [Modelo de datos](documentacion/modelo-de-datos.md)
- [Planificación](documentacion/planificacion.md)
- [Plan de desarrollo y riesgos](documentacion/PLAN_DE_DESARROLLO_Y_RIESGOS.md)
- [Cronograma Gantt](documentacion/GANTT.md)
- [Integrantes y roles](documentacion/equipo/integrantes-y-roles.md)
- [Acuerdos de trabajo](documentacion/equipo/acuerdos-de-trabajo.md)
- [Plan de pruebas](pruebas/casos-prueba/PLAN_DE_PRUEBAS.md)

## 11. Trabajo colaborativo y seguridad

- Realizar commits pequeños y descriptivos.
- Revisar los cambios antes de integrarlos a main.
- No subir .vs/, bin/, obj/, archivos temporales ni credenciales.
- Usar datos ficticios en las pruebas.
- Mantener documentación, diagramas y README sincronizados con la implementación real.