# PR2-2026 — Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza

**Equipo:** Virus  
**Universidad:** Universidad Privada Franz Tamayo  
**Sede:** Cochabamba, Bolivia  
**Asignatura:** Programación II — P2  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

## 1. Descripción del problema

El proyecto aborda las dificultades que pueden presentarse cuando las barberías y salones organizan sus citas mediante cuadernos y mensajes: confusión de horarios, posibles reservas superpuestas, pérdida de tiempo al consultar disponibilidad y dificultad para mantener registros ordenados. La validación de estas necesidades con usuarios reales está pendiente de documentarse.

## 2. Propósito

Desarrollar una aplicación de escritorio que centralice clientes, profesionales, servicios y citas, con una validación de disponibilidad que impida guardar citas superpuestas para un mismo profesional.

## 3. Usuarios

- **Administradores y personal:** organizar registros y gestionar la agenda.
- **Barberos y estilistas:** consultar las citas asignadas.
- **Clientes:** recibir una reserva registrada por el personal en el MVP propuesto.

## 4. Objetivo general

Desarrollar una aplicación de escritorio para gestionar clientes, profesionales, servicios y citas, incorporando una validación que impida registrar citas superpuestas para un mismo profesional.

## 5. Tecnologías previstas

| Tecnología | Uso |
|---|---|
| C# | Lógica de la aplicación |
| Windows Forms | Interfaz de escritorio |
| SQL Server | Base de datos relacional |
| ADO.NET | Conexión entre aplicación y base de datos |
| Visual Studio | Entorno de desarrollo |
| GitHub | Control de versiones y documentación compartida |

Las versiones concretas deben acordarse y documentarse antes de la implementación.

## 6. Equipo y responsabilidades

| Integrante | Responsabilidad principal |
|---|---|
| Ekaitz Yale Yauli | Backend, base de datos y conexión ADO.NET |
| Leonor Alejandra Almanza Arroyo | Formularios, interfaz y flujo de usuario |
| Jairo Damian Rodríguez Huanca | Pruebas, evidencias y documentación |
| Todo el equipo | Alcance, integración, revisión y demostración |

## 7. Documentación del proyecto

### Para comprender y evaluar la madurez

- [Guía de las 52 preguntas del cuestionario de madurez](documentacion/GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md)
- [Problema, objetivos, valor e investigación pendiente](documentacion/informe/PROBLEMA_OBJETIVOS_Y_VALIDACION.md)
- [Alcance y MVP propuesto](documentacion/requisitos/ALCANCE_MVP.md)
- [Requisitos funcionales y criterios de aceptación](documentacion/requisitos/REQUISITOS_Y_CRITERIOS.md)
- [Arquitectura técnica y modelo de datos inicial](documentacion/diagramas/ARQUITECTURA_Y_DATOS.md)
- [Plan de desarrollo y riesgos](documentacion/PLAN_DE_DESARROLLO_Y_RIESGOS.md)
- [Diagrama de Gantt tentativo](documentacion/GANTT.md)
- [Plan de pruebas y casos verificables](pruebas/casos-prueba/PLAN_DE_PRUEBAS.md)
- [Presentación del proyecto](presentacion/Presentacion_Proyecto.md)

## 8. Estructura actual

```text
README.md
documentacion/
  GUIA_CUESTIONARIO_MADUREZ_52_PREGUNTAS.md
  GANTT.md
  PLAN_DE_DESARROLLO_Y_RIESGOS.md
  informe/
    PROBLEMA_OBJETIVOS_Y_VALIDACION.md
  requisitos/
    ALCANCE_MVP.md
    REQUISITOS_Y_CRITERIOS.md
  diagramas/
    ARQUITECTURA_Y_DATOS.md
equipo/
presentacion/
  Presentacion_Proyecto.md
pruebas/
  casos-prueba/
    PLAN_DE_PRUEBAS.md
  evidencias/
sistema/
  base-datos/
  codigo/
  recursos/
entregables/
```

## 9. Estado real del repositorio

La documentación inicial está preparada para responder las 52 preguntas del cuestionario y orientar el desarrollo. Sin embargo, la guía distingue entre decisiones propuestas y evidencias pendientes.

**Al revisar el repositorio, todavía no aparecen el código fuente de la aplicación ni scripts SQL.** Las carpetas correspondientes existen, pero están vacías salvo sus archivos de marcador. Por ello, el proyecto no debe presentarse como una aplicación ya implementada ni como un conjunto de pruebas ya ejecutadas.

## 10. Próximos pasos prioritarios

1. Revisar y aprobar el MVP propuesto entre los tres integrantes y confirmar con el docente que el alcance es aceptable.
2. Validar el problema con usuarios potenciales y guardar un resumen real sin datos personales.
3. Acordar reglas de negocio y versiones de las herramientas.
4. Crear el modelo SQL y probar la conexión ADO.NET con datos ficticios.
5. Implementar las funciones del MVP e ir ejecutando los casos de prueba.
6. Añadir código, scripts, instrucciones de ejecución y evidencias reales al repositorio.

## 11. Equipo

- Ekaitz Yale Yauli — Backend y base de datos.
- Leonor Alejandra Almanza Arroyo — Interfaz y experiencia de usuario.
- Jairo Damian Rodríguez Huanca — Pruebas y documentación.

**Nota:** el MVP y las fechas del plan son propuestas iniciales y deben confirmarse con el equipo y el docente. La documentación no sustituye el desarrollo ni la evidencia de pruebas ejecutadas.
