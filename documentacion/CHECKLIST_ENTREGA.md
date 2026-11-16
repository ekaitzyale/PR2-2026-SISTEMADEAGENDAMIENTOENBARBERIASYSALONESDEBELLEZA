# Checklist de preparación del repositorio y entrega

Este checklist organiza los elementos que el equipo debe revisar según la consigna y los criterios de organización compartidos. No reemplaza la rúbrica oficial ni asigna puntajes; antes de entregar, contrastar cada punto con las instrucciones vigentes del docente.

## 1. Repositorio y organización

| Elemento | Estado | Observación |
|---|---|---|
| README principal | Preparado | Incluye problema, objetivo, usuarios, equipo, tecnologías, estado e instrucciones. |
| `.gitignore` y `.editorconfig` | Presentes | Excluyen archivos generados y definen formato. |
| `documentacion/` | Preparada | Visión, requisitos, arquitectura, modelo de datos, planificación, informe y cuestionario. |
| `equipo/` | Preparada | Integrantes y responsabilidades consolidados. |
| `entregables/` | Preparada | Reservada para versiones finales. |
| `presentacion/` | Presente | Revisar y exportar la versión final solicitada. |
| `pruebas/` | Preparada | Plan presente; faltan resultados ejecutados. |
| `scripts/` | Reservada | No hay automatizaciones auxiliares todavía. |
| `sistema/` | Presente | Solución C# y script SQL versionados. |
| `.github/ISSUE_TEMPLATE/` | Presente | Plantillas de error y solicitud de mejora. |
| `.github/pull_request_template.md` | Presente | Lista de comprobación para revisiones. |
| `.github/CODEOWNERS` | Presente | Responsable de revisión configurado. |
| `.github/workflows/` | Preparada | Flujo de compilación automatizada añadido en esta rama. |
| `CONTRIBUTING.md`, `CHANGELOG.md`, `SECURITY.md`, `LICENSE` | Presentes | Mantenerlos actualizados. |

## 2. Documentación del proyecto

- [ ] Confirmar requisitos y alcance con el docente.
- [ ] Incorporar evidencia primaria y anonimizada de entrevistas/observación.
- [ ] Resolver cómo se relaciona SERVICIO con CITA.
- [ ] Mantener arquitectura y modelo de datos alineados con el script SQL.
- [ ] Actualizar cronograma con fechas reales y responsables.
- [ ] Completar manual de usuario/técnico si lo solicita la consigna.
- [ ] Revisar que la presentación describa el estado real, no funciones futuras como terminadas.

## 3. Aplicación y base de datos

- [ ] Abrir y compilar la solución en Visual Studio 2022 con .NET Framework 4.8.
- [ ] Ejecutar el script SQL en una instancia de prueba.
- [ ] Confirmar las cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA.
- [ ] Verificar la conexión desde la versión actual de la aplicación.
- [ ] Implementar y probar los módulos de clientes, profesionales y servicios.
- [ ] Implementar y probar agenda, modificación, cancelación y regla de solapamiento.
- [ ] Resolver y probar la asociación de servicios a las citas, si forma parte del alcance.
- [ ] Confirmar que las consultas usan parámetros.
- [ ] Revisar manejo de errores y configuración local.

## 4. Pruebas y evidencias

- [ ] Ejecutar todos los casos de `pruebas/casos-prueba/PLAN_DE_PRUEBAS.md`.
- [ ] Registrar fecha, commit, responsable, resultado observado y estado.
- [ ] Adjuntar capturas actuales en `pruebas/evidencias/`.
- [ ] No incluir credenciales ni datos personales reales.
- [ ] Repetir la prueba de conexión, porque la captura disponible corresponde a una interfaz anterior.
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

La estructura documental y de colaboración está preparada. La aplicación sigue siendo un esqueleto inicial: los módulos funcionales, la validación de citas y la ejecución completa de pruebas continúan pendientes. También está pendiente resolver la relación entre SERVICIO y CITA. La entrega no debe considerarse terminada hasta completar y evidenciar esos puntos.
