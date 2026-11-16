# Checklist de preparación del repositorio y entrega

Este checklist organiza los elementos que el equipo debe revisar según la consigna y los criterios de organización compartidos para el proyecto. No reemplaza la rúbrica oficial ni asigna puntajes; antes de entregar, contrastar cada punto con la versión vigente de las instrucciones del docente.

## 1. Repositorio y organización

| Elemento | Estado | Observación |
|---|---|---|
| README principal con propósito, problema, usuarios, equipo, tecnologías, estado e instrucciones | Preparado | Actualizar conforme cambie el sistema. |
| `.gitignore` | Presente | Excluye archivos generados y secretos comunes. |
| `.editorconfig` | Presente | Reglas básicas de formato. |
| `documentacion/` | Preparada | Requisitos, arquitectura, informe, planificación y cuestionario. |
| `equipo/` | Preparada | Integrantes y responsabilidades consolidados. |
| `entregables/` | Preparada | Reservada para versiones finales. |
| `presentacion/` | Presente | Revisar y exportar la versión final solicitada. |
| `pruebas/` | Preparada | Plan presente; faltan resultados ejecutados. |
| `scripts/` | Reservada | No hay automatizaciones auxiliares todavía. |
| `sistema/` | Presente | Solución C# y script SQL versionados. |
| `.github/ISSUE_TEMPLATE/` | Preparada | Plantillas de error y tarea. |
| `.github/workflows/` | Preparada | Flujo de compilación automatizada. |
| `CONTRIBUTING.md`, `CHANGELOG.md`, `SECURITY.md` | Presentes | Revisar cuando cambie el flujo del equipo. |
| `LICENSE` | Pendiente de decisión | El archivo explica que el equipo aún no aprobó una licencia; no concede permisos. |

## 2. Documentación del proyecto

- [ ] Confirmar requisitos y alcance con el docente.
- [ ] Confirmar si una cita puede contener varios servicios.
- [ ] Confirmar el alcance de la tabla FACTURA y si habrá módulo de factura interna.
- [ ] Incorporar evidencia primaria y anonimizada de entrevistas/observación.
- [ ] Mantener arquitectura y modelo de datos alineados con el script SQL.
- [ ] Actualizar cronograma con fechas reales y responsables.
- [ ] Completar manual de usuario/técnico si lo solicita la consigna.
- [ ] Revisar que la presentación describa el estado real, no funciones futuras como terminadas.

## 3. Aplicación y base de datos

- [ ] Abrir y compilar la solución en Visual Studio 2022 con .NET Framework 4.8.
- [ ] Ejecutar el script SQL en una instancia de prueba.
- [ ] Confirmar que se crean las seis tablas: CLIENTE, PROFESIONAL, SERVICIO, CITA, DETALLE_CITA y FACTURA.
- [ ] Verificar la conexión desde la versión actual de la aplicación.
- [ ] Implementar y probar los módulos de clientes, profesionales y servicios.
- [ ] Implementar y probar agenda, modificación, cancelación y regla de solapamiento.
- [ ] Confirmar que las consultas usan parámetros.
- [ ] Revisar manejo de errores y configuración local.

## 4. Pruebas y evidencias

- [ ] Ejecutar todos los casos de `pruebas/casos-prueba/PLAN_DE_PRUEBAS.md`.
- [ ] Registrar fecha, commit, responsable, resultado observado y estado.
- [ ] Adjuntar capturas actuales en `pruebas/evidencias/`.
- [ ] No incluir credenciales ni datos personales reales.
- [ ] Repetir la evidencia de conexión y actualizar la captura de SQL para las seis tablas.
- [ ] Corregir fallos y repetir pruebas de regresión.

## 5. Control de versiones y entrega

- [ ] Usar ramas para cambios y Pull Requests revisados.
- [ ] Mantener commits descriptivos.
- [ ] Revisar el diff antes de integrar a `main`.
- [ ] Confirmar que no se subieron `.vs`, `bin`, `obj`, secretos o archivos temporales.
- [ ] Verificar enlaces y pasos de instalación desde una copia limpia del repositorio.
- [ ] Preparar los archivos finales en `entregables/` solo cuando estén revisados.
- [ ] Subir al Moodle la presentación y los demás archivos que el docente solicite, además de mantener actualizado GitHub.

## 6. Estado de la entrega

La estructura documental y de colaboración está preparada en el repositorio. La aplicación sigue siendo un esqueleto inicial: los módulos funcionales, la validación de citas y la ejecución completa de pruebas continúan pendientes. La entrega no debe considerarse terminada hasta completar y evidenciar esos puntos.
