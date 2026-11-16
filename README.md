# Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus  
**Institución:** Universidad Privada Franz Tamayo — Facultad de Ingeniería  
**Sede:** Cochabamba, Bolivia  
**Asignatura:** Programación II (P2)  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

## 1. Descripción y problema

El proyecto propone una aplicación de escritorio para apoyar la organización de clientes, profesionales, servicios y citas en barberías y salones de belleza. La gestión manual mediante agendas y mensajería puede dificultar la consulta de disponibilidad y provocar confusión o reservas superpuestas.

## 2. Objetivo y usuarios

**Objetivo general:** desarrollar un sistema de escritorio que centralice la información principal del establecimiento y facilite la administración de citas, incluyendo la validación de disponibilidad de los profesionales.

- **Administración/recepción:** registra clientes, profesionales, servicios y citas.
- **Barberos y estilistas:** necesitan consultar su agenda.
- **Clientes:** solicitan reservas mediante el personal del establecimiento. El MVP no contempla una aplicación pública web o móvil.

## 3. Alcance funcional propuesto

El MVP contempla mantenimiento de clientes, profesionales y servicios; registro y consulta de citas; modificación y cancelación; validación para evitar solapamientos; y persistencia en SQL Server.

Las reservas públicas, notificaciones automáticas, pagos en línea, facturación fiscal, inventario, múltiples sucursales y reportes avanzados se consideran fuera del MVP inicial, salvo indicación distinta del docente.

**Decisión técnica pendiente:** el esquema SQL actual contiene cuatro tablas y no relaciona SERVICIO con CITA. El equipo debe acordar cómo representar esa relación antes de implementar esa función. Seguimiento: [Issue #13](https://github.com/ekaitzyale/PR2-2026-SISTEMADEAGENDAMIENTOENBARBERIASYSALONESDEBELLEZA/issues/13).

## 4. Tecnologías y entorno

| Tecnología | Uso |
|---|---|
| C# | Lenguaje de programación |
| .NET Framework 4.8 | Plataforma del proyecto |
| Windows Forms | Interfaz de escritorio |
| SQL Server | Base de datos relacional |
| ADO.NET / System.Data.SqlClient | Acceso a datos |
| Visual Studio 2022 | Entorno de desarrollo |
| Git y GitHub | Control de versiones y colaboración |

## 5. Estado real del repositorio

Este estado describe los archivos versionados; no certifica que la aplicación se haya ejecutado en todos los equipos.

| Componente | Estado comprobable |
|---|---|
| Solución y proyecto | Existen `.sln` y `.csproj` para .NET Framework 4.8. |
| Inicio | `Program.cs` configura Windows Forms y abre `Forms.FrmMenu`. |
| Interfaz | Existe un menú inicial con botones de Clientes, Profesionales, Servicios y Citas; actualmente están deshabilitados. |
| Acceso a datos | Existe `Datos/ConexionBD.cs` con creación y prueba de conexión ADO.NET. |
| Configuración | Existe `App.config`; cada integrante debe adaptar `Data Source` a su instancia local. |
| Base de datos | El script SQL versionado crea cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA, además de índices. |
| Funcionalidades | Los módulos CRUD, la agenda y la validación de solapamientos todavía no están implementados en el código revisado. |
| Relación servicio-cita | No existe en el esquema actual; debe resolverse antes de persistir el servicio elegido en una cita. |
| Pruebas | Hay casos diseñados; los resultados deben ejecutarse y registrarse antes de marcarlos como aprobados. |

La guía del cuestionario conserva capturas aportadas por el equipo sobre una prueba anterior de conexión. El menú actualmente versionado no contiene el botón “Probar” que aparece en la captura; por ello se debe repetir la comprobación sobre la versión actual. La captura de SQL muestra cuatro tablas y coincide con el esquema vigente, pero también debe actualizarse si el equipo cambia el modelo.

## 6. Estructura del repositorio

Se conserva `documentacion/` como carpeta principal de documentación para evitar duplicar documentos y romper rutas existentes.

| Ruta | Contenido |
|---|---|
| `.github/` | CODEOWNERS, plantillas de incidencias y Pull Requests; flujo de CI |
| `documentacion/` | Visión, requisitos, arquitectura, modelo de datos, planificación, informe y cuestionario |
| `equipo/` | Integrantes y responsabilidades |
| `sistema/codigo/` | Solución de Visual Studio y código C# |
| `sistema/base-datos/` | Scripts SQL |
| `sistema/recursos/` | Recursos de la aplicación |
| `pruebas/` | Casos de prueba y evidencias |
| `presentacion/` | Material de exposición |
| `entregables/` | Archivos finales solicitados |
| `scripts/` | Automatizaciones auxiliares, si se incorporan |

## 7. Equipo

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Coordinación técnica, base de datos y acceso a datos |
| Leonor Alejandra Almanza Arroyo | Formularios, interfaz y validaciones visuales |
| Jairo Damian Rodríguez Huanca | Pruebas, evidencias y documentación |
| Todo el equipo | Integración, revisión y decisiones de alcance |

Ver [equipo/README.md](equipo/README.md) y [acuerdos de trabajo](documentacion/equipo/acuerdos-de-trabajo.md).

## 8. Requisitos previos

- Windows 10 o superior.
- Visual Studio 2022 con desarrollo de escritorio de .NET.
- .NET Framework 4.8 Developer Pack/Targeting Pack.
- SQL Server instalado y en ejecución.
- SQL Server Management Studio (SSMS) o herramienta compatible.
- Git.

## 9. Instalación, configuración y ejecución

1. Clonar el repositorio.
2. Abrir `sistema/codigo/SistemaAgendamiento.sln` en Visual Studio.
3. Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SSMS.
4. Revisar `sistema/codigo/SistemaAgendamiento/App.config` y adaptar `Data Source` al nombre de la instancia local.
5. Compilar y ejecutar desde Visual Studio.

La cadena incluida usa autenticación integrada como configuración de ejemplo. Cada integrante debe adaptarla a su entorno. No subir contraseñas ni credenciales privadas.

Abrir el menú no significa que los módulos de gestión estén terminados. La aplicación está en etapa inicial.

## 10. Documentación y pruebas

- [Índice de documentación](documentacion/README.md)
- [Visión y alcance](documentacion/vision-y-alcance.md)
- [Requisitos y alcance del MVP](documentacion/requisitos/REQUISITOS_Y_ALCANCE.md)
- [Arquitectura y modelo de datos](documentacion/diagramas/ARQUITECTURA_Y_DATOS.md)
- [Planificación y cronograma](documentacion/PLANIFICACION_Y_CRONOGRAMA.md)
- [Informe del problema y validación](documentacion/informe/PROBLEMA_OBJETIVOS_Y_VALIDACION.md)
- [Cuestionario de madurez — 52 preguntas](documentacion/GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md)
- [Checklist de entrega](documentacion/CHECKLIST_ENTREGA.md)
- [Plan de pruebas](pruebas/casos-prueba/PLAN_DE_PRUEBAS.md)
- [Presentación](presentacion/Presentacion_Proyecto.md)

No declarar una función o prueba como terminada sin ejecutarla y registrar evidencia.

## 11. Colaboración y seguridad

Consultar [CONTRIBUTING.md](CONTRIBUTING.md), [CHANGELOG.md](CHANGELOG.md) y [SECURITY.md](SECURITY.md). Los cambios deben ser pequeños, descriptivos y revisados antes de integrarse en `main`. No subir `.vs`, `bin`, `obj`, credenciales, datos personales reales ni archivos temporales.
