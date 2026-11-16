# Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus  
**Institución:** Universidad Privada Franz Tamayo — Facultad de Ingeniería  
**Sede:** Cochabamba, Bolivia  
**Asignatura:** Programación II (P2)  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

## 1. Descripción

El proyecto propone una aplicación de escritorio para apoyar la gestión de clientes, profesionales, servicios y citas en barberías y salones de belleza. Busca centralizar la agenda y ayudar a prevenir reservas superpuestas para un mismo profesional.

La propuesta parte del problema descrito en el documento inicial del equipo: la gestión mediante agendas físicas y mensajería puede dificultar la consulta de disponibilidad y la organización de turnos. La validación con usuarios debe respaldarse con entrevistas u observaciones documentadas.

## 2. Objetivo y usuarios

**Objetivo general:** desarrollar una aplicación de escritorio que permita administrar los datos principales del establecimiento y gestionar citas con validación de disponibilidad.

- **Administración/recepción:** registra y consulta clientes, profesionales, servicios y citas.
- **Profesionales:** necesitan consultar su agenda.
- **Clientes:** solicitan reservas a través del personal; el MVP no contempla una aplicación pública web o móvil.

## 3. Alcance funcional

El MVP propuesto contempla:
- Registro y consulta de clientes.
- Registro y consulta de profesionales.
- Registro y consulta de servicios con duración y precio.
- Registro y consulta de citas.
- Modificación y cancelación de citas.
- Validación para evitar solapamientos del mismo profesional.
- Persistencia de datos en SQL Server.

Reservas públicas, notificaciones automáticas, pagos en línea, facturación fiscal, inventario, múltiples sucursales y reportes avanzados quedan fuera del MVP inicial, salvo que el docente indique lo contrario. El script SQL sí contiene una tabla `FACTURA` para un registro interno; el equipo debe confirmar si tendrá operaciones visibles en la primera versión.

Los requisitos detallados y sus criterios verificables están en [REQUISITOS_Y_ALCANCE.md](documentacion/requisitos/REQUISITOS_Y_ALCANCE.md).

## 4. Tecnologías

| Tecnología | Uso |
|---|---|
| C# | Lenguaje de la aplicación |
| Windows Forms | Interfaz gráfica de escritorio |
| .NET Framework 4.8 | Plataforma objetivo del proyecto |
| SQL Server | Base de datos relacional |
| ADO.NET / System.Data.SqlClient | Acceso a datos |
| Visual Studio 2022 | Entorno de desarrollo |
| Git y GitHub | Control de versiones y colaboración |

## 5. Estado real del repositorio

Este estado describe los archivos que están versionados; no equivale a certificar una ejecución en todos los equipos.

| Componente | Estado comprobable en el repositorio |
|---|---|
| Solución y proyecto C# | Existen `.sln` y `.csproj` para .NET Framework 4.8. |
| Inicio de la aplicación | `Program.cs` configura Windows Forms y abre `Forms.FrmMenu`. |
| Menú principal | Existe una ventana inicial con botones de Clientes, Profesionales, Servicios y Citas; actualmente están deshabilitados. |
| Acceso a datos | Existe `Datos/ConexionBD.cs` con creación y prueba de conexión ADO.NET. |
| Configuración | Existe `App.config`; cada integrante debe revisar el servidor SQL local. |
| Base de datos | Existe un script SQL que define seis tablas e índices. Su presencia no demuestra que se haya ejecutado en cada entorno. |
| Módulos funcionales | Los CRUD, la agenda, la lógica de negocio y la validación de solapamientos todavía no están implementados en el código revisado. |
| Pruebas | Hay un plan de casos; los casos deben ejecutarse y registrar resultados antes de marcarlos como aprobados. |

La guía del cuestionario conserva capturas aportadas por el equipo sobre una prueba previa de conexión. Como el menú actual no contiene el botón de prueba que aparece en una de las capturas, se debe repetir y documentar la comprobación sobre la versión actual. La captura de SQL también debe actualizarse para reflejar las seis tablas del script vigente.

## 6. Estructura del repositorio

```text
/
├── .github/                 # Plantillas de incidencias y CI
├── README.md                # Entrada principal del proyecto
├── CONTRIBUTING.md          # Reglas para colaborar
├── CHANGELOG.md             # Historial de cambios
├── SECURITY.md              # Reporte responsable de problemas
├── LICENSE                  # Estado de licencia del proyecto
├── documentacion/
│   ├── requisitos/          # Requisitos y alcance del MVP
│   ├── diagramas/           # Arquitectura y modelo de datos
│   ├── informe/             # Problema, objetivos y validación
│   ├── PLANIFICACION_Y_CRONOGRAMA.md
│   └── GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md
├── equipo/                  # Integrantes y responsabilidades
├── entregables/             # Versiones finales para la asignatura
├── presentacion/            # Material de exposición
├── pruebas/
│   ├── casos-prueba/        # Plan y registro de pruebas
│   └── evidencias/          # Capturas y respaldos
├── scripts/                 # Automatizaciones auxiliares
└── sistema/
    ├── base-datos/          # Scripts SQL
    ├── codigo/              # Solución y código C#
    └── recursos/            # Recursos visuales
```

## 7. Equipo

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Coordinación técnica, base de datos, backend y acceso ADO.NET |
| Leonor Alejandra Almanza Arroyo | Interfaz, formularios Windows Forms, navegación y validaciones visuales |
| Jairo Damian Rodríguez Huanca | Control de calidad, casos de prueba, evidencias y documentación |
| Todo el equipo | Alcance, integración, revisión y presentación |

Ver [equipo/README.md](equipo/README.md).

## 8. Requisitos previos

- Windows 10 o superior.
- Visual Studio 2022 con soporte para desarrollo de escritorio .NET.
- .NET Framework 4.8 Developer Pack/Targeting Pack.
- SQL Server instalado y en ejecución.
- SQL Server Management Studio (SSMS) o una herramienta compatible para ejecutar el script.

## 9. Preparación local

1. Clonar el repositorio.
2. Abrir `sistema/codigo/SistemaAgendamiento.sln` en Visual Studio.
3. Abrir `sistema/base-datos/01_Crear_Base_Datos.sql` en SSMS y ejecutarlo en la instancia local de SQL Server.
4. Revisar `sistema/codigo/SistemaAgendamiento/App.config` y ajustar `Data Source` al nombre de la instancia local. No añadir contraseñas ni credenciales personales al repositorio.
5. Compilar la solución y ejecutar desde Visual Studio.

La ejecución local de estos pasos debe confirmarse en cada equipo. El proyecto está en etapa inicial: abrir el menú no significa que los módulos de gestión estén terminados.

## 10. Documentación y pruebas

- [Índice de documentación](documentacion/README.md)
- [Requisitos y alcance](documentacion/requisitos/REQUISITOS_Y_ALCANCE.md)
- [Arquitectura y modelo de datos](documentacion/diagramas/ARQUITECTURA_Y_DATOS.md)
- [Planificación y cronograma](documentacion/PLANIFICACION_Y_CRONOGRAMA.md)
- [Informe del problema y validación](documentacion/informe/PROBLEMA_OBJETIVOS_Y_VALIDACION.md)
- [Cuestionario de madurez — 52 preguntas](documentacion/GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md)
- [Plan de pruebas](pruebas/casos-prueba/PLAN_DE_PRUEBAS.md)
- [Presentación](presentacion/Presentacion_Proyecto.md)

No se debe declarar una función o prueba como terminada sin comprobarla en la aplicación y registrar evidencia.

## 11. Colaboración y mantenimiento

Consultar [CONTRIBUTING.md](CONTRIBUTING.md), [CHANGELOG.md](CHANGELOG.md) y [SECURITY.md](SECURITY.md). La licencia todavía está pendiente de aprobación del equipo; ver [LICENSE](LICENSE). El [checklist de entrega](documentacion/CHECKLIST_ENTREGA.md) reúne los pendientes de revisión.

Los cambios deben ser pequeños, descriptivos y revisados antes de integrarse en `main`. No subir carpetas generadas (`.vs`, `bin`, `obj`), credenciales, datos personales reales ni archivos temporales.
