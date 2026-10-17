# Cuestionario de madurez del proyecto — 52 preguntas

**Proyecto:** Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza  
**Equipo:** Virus · **Asignatura:** Programación II — P2  
**Docente:** Ing. Diego Patrick Cárdenas Sejas

Documento de trabajo elaborado a partir del cuestionario del docente y del documento inicial del equipo. Las propuestas deben ser confirmadas por los integrantes y con el docente cuando corresponda. Entrevistas, pruebas y avances solo deben marcarse como realizados cuando exista evidencia.

## 1. Problema y valor

**1. ¿Pueden explicar el problema en menos de 30 segundos sin mencionar tecnología?**  
Sí: algunas barberías y salones organizan sus turnos con cuadernos y mensajes, lo que puede provocar confusión, pérdida de tiempo y reservas del mismo profesional a la misma hora.

**2. ¿Quién tiene el problema y quién utilizará la solución?**  
Administradores, barberos, estilistas y personal que registra citas. En el MVP propuesto, el personal registrará las reservas; no se contempla una aplicación pública para reservar por Internet.

**3. ¿Qué evidencia demuestra que el problema es real?**  
El documento inicial describe el problema, pero el repositorio aún no contiene entrevistas ni observaciones documentadas. **Pendiente:** consultar al menos a dos personas que trabajen en barberías o salones, registrar fecha, perfil general y respuestas resumidas, sin publicar datos personales.

**4. ¿Qué consecuencias tiene el problema?**  
Posibles cruces de horarios, tiempo perdido respondiendo consultas, demoras, espera de clientes y dificultad para revisar el historial. Deben contrastarse con la validación pendiente.

**5. ¿Qué valor aportará la solución?**  
Centralizar clientes, profesionales, servicios y citas, y advertir antes de guardar una cita que se cruce con otra del mismo profesional.

**6. ¿Por qué es una respuesta adecuada?**  
Porque la función principal aborda la desorganización de la agenda y la duplicación de turnos. Se demostrará con pruebas de registro, consulta, modificación, cancelación y solapamiento.

## 2. Objetivos y éxito

**7. ¿El objetivo general es comprobable?**  
Objetivo general propuesto: desarrollar una aplicación de escritorio para gestionar clientes, profesionales, servicios y citas, con una validación que impida citas superpuestas del mismo profesional. Se comprobará mediante demostración y casos de prueba.

**8. ¿Los objetivos específicos permiten medir el avance?**  
Sí: diseñar la base de datos; implementar el mantenimiento de clientes, profesionales y servicios; gestionar citas; validar disponibilidad; y ejecutar pruebas documentadas.

**9. ¿Hay relación entre problema, objetivos, solución y resultados?**  
Sí. La desorganización conduce a centralizar la agenda; la validación responde a los cruces; el resultado esperado es una agenda ordenada y ningún solapamiento en los casos probados.

**10. ¿Cómo sabrán si tuvieron éxito?**  
Criterios propuestos: operaciones principales del MVP funcionales; rechazo de citas que se cruzan; aceptación de casos válidos; persistencia en SQL Server; y pruebas registradas. Son metas de aceptación del software, no una afirmación de impacto comercial ya medido.

## 3. Usuarios y requisitos

**11. ¿Usuarios y necesidades están definidos?**  
A nivel inicial: administración organiza registros y agenda; profesionales consultan turnos; el personal registra y actualiza reservas. Los permisos específicos quedan por acordar.

**12. ¿Las funciones responden a necesidades reales?**  
Clientes, profesionales, servicios, agenda y validación se relacionan con la organización de turnos. Se recomienda confirmar necesidades con entrevistas.

**13. ¿Las funciones están descritas para que otro integrante las desarrolle?**  
La descripción inicial era general. Se amplía en el documento de requisitos y criterios de aceptación.

**14. ¿Cada función tiene criterios verificables?**  
Sí, se proponen criterios en el documento de requisitos y casos en el plan de pruebas. Deben marcarse como aprobados solo después de ejecutarlos.

**15. ¿Hay requisitos de calidad?**  
Se proponen validación de entradas, mensajes comprensibles, integridad de datos, consultas parametrizadas, protección de credenciales y compatibilidad con el entorno Windows, .NET y SQL Server acordado.

## 4. Alcance

**16. ¿Está definido qué desarrollarán?**  
MVP propuesto: aplicación de escritorio para clientes, profesionales, servicios, citas, agenda, validación de disponibilidad y persistencia en SQL Server.

**17. ¿Está definido qué no desarrollarán?**  
Se propone excluir del MVP reservas públicas web/móvil, mensajes automáticos, pagos en línea, facturación fiscal, inventario, múltiples sucursales y dashboard avanzado. Confirmar con el docente que estas exclusiones son aceptables.

**18. ¿Identificaron funciones interesantes pero no esenciales?**  
Sí: dashboard avanzado, reportes, facturación, productos e inventario. Se posponen hasta completar la agenda.

**19. ¿El alcance es realista?**  
Un MVP reducido es más viable para tres estudiantes que implementar todos los módulos simultáneamente. Debe confirmarse según fechas oficiales y disponibilidad del equipo.

**20. Si redujeran el proyecto un 40 %, ¿qué conservarían?**  
Base de datos, clientes, profesionales, servicios, gestión de citas y prevención de solapamientos. Se pospondrían reportes avanzados, dashboard, facturación e inventario.

## 5. MVP

**21. ¿Existe una primera versión funcional definida?**  
Sí, como propuesta: aplicación de escritorio conectada a SQL Server para administrar los datos mínimos y registrar citas sin solapamientos.

**22. ¿Resuelve una parte real del problema?**  
Sí: centraliza la agenda y evita reservas incompatibles del mismo profesional.

**23. ¿Puede terminarse a tiempo?**  
Es más viable que el alcance completo, pero se deben confirmar las fechas oficiales y ajustar las estimaciones.

**24. ¿Las funciones posteriores están separadas?**  
Sí: reservas públicas, notificaciones, dashboard avanzado, reportes complejos, facturación, productos e inventario se proponen como mejoras posteriores.

## 6. Diseño y viabilidad técnica

**25. ¿Es viable con las tecnologías del equipo?**  
La propuesta usa C#, Windows Forms, SQL Server y ADO.NET, previstas en el documento inicial. La viabilidad debe confirmarse con una prueba de conexión y persistencia.

**26. ¿Identificaron las partes técnicamente difíciles?**  
Sí: conexión a SQL Server, relaciones de datos, validación de intervalos horarios, modificación de citas y manejo de errores.

**27. ¿Validaron las integraciones críticas?**  
Aún no hay evidencia de esa prueba en el repositorio. Antes de depender de ella, probar una conexión ADO.NET y una lectura/escritura con datos ficticios y guardar el resultado.

**28. ¿Las decisiones tecnológicas están justificadas?**  
C# y Windows Forms para la aplicación de escritorio; SQL Server para datos relacionales; ADO.NET para la conexión desde C#. La elección coincide con el entorno planteado para la materia.

**29. ¿Identificaron dependencias externas?**  
Equipo Windows, Visual Studio compatible, instancia de SQL Server, permisos para crear una base de datos, versión acordada de .NET, GitHub y acceso de los integrantes. Las versiones exactas quedan pendientes de acuerdo.

**30. ¿La estructura técnica es clara?**  
Se propone separar presentación, lógica de negocio y acceso a datos. La arquitectura inicial se documenta en el archivo de arquitectura y datos del repositorio.

## 7. Datos, seguridad y calidad

**31. ¿Qué información manejará el sistema y de dónde provendrá?**  
Datos introducidos por el personal: clientes, profesionales, servicios y citas. Para pruebas se usarán datos ficticios. No se cargarán datos reales sin autorización.

**32. ¿Hay restricciones de privacidad y seguridad?**  
Sí: recopilar solo lo necesario, limitar el acceso al personal autorizado, usar consultas parametrizadas, no publicar credenciales ni cadenas de conexión y no subir datos personales reales a GitHub.

**33. ¿Cómo comprobarán las funciones?**  
Con casos de prueba de datos válidos e inválidos, persistencia, modificación/cancelación y escenarios con y sin solapamiento.

**34. ¿Hay una estrategia inicial de pruebas?**  
Sí, propuesta en el plan de pruebas: pruebas funcionales, validación, persistencia, integración y regresión.

## 8. Plan de desarrollo

**35. ¿El Gantt tiene tareas concretas?**  
El documento inicial enumera etapas, pero el repositorio no contenía un Gantt detallado. Se incorpora un plan tentativo por tareas en el plan de desarrollo y riesgos.

**36. ¿Cada tarea tiene responsable?**  
Ekaitz: backend/base de datos; Leonor: interfaz y flujo; Jairo: pruebas y documentación. Integración y alcance son responsabilidad compartida.

**37. ¿Las estimaciones son razonables?**  
Las estimaciones por etapas son propuestas y deben ajustarse según disponibilidad real y fecha de entrega confirmada.

**38. ¿Las dependencias están identificadas?**  
Sí: alcance antes del modelo; modelo y conexión antes de integrar formularios; módulos antes de pruebas completas; correcciones antes de entrega.

**39. ¿Se contemplan desarrollo, integración, pruebas, correcciones y documentación?**  
Sí, están incluidas en el plan propuesto.

**40. ¿Qué tareas podrían bloquear al resto?**  
Definir el alcance, diseñar el modelo de datos, probar la conexión y resolver la regla de solapamiento. Deben probarse temprano.

## 9. Equipo y riesgos

**41. ¿Cada integrante tiene responsabilidad verificable?**  
Ekaitz: modelo, base de datos y acceso a datos; Leonor: formularios, navegación y validaciones visuales; Jairo: pruebas, resultados y documentación.

**42. ¿Hay mecanismo de revisión e integración?**  
Se propone usar GitHub, commits descriptivos, revisión antes de integrar a main, pruebas conjuntas y registro escrito de decisiones. Mantener los canales de coordinación acordados por el equipo.

**43. ¿Cuáles son los tres riesgos principales?**  
1. Crecimiento del alcance. 2. Errores de integración o de validación horaria. 3. Retraso o indisponibilidad de una persona clave.

**44. ¿Hay mitigación para cada riesgo?**  
1. Congelar el MVP y posponer extras. 2. Probar conexión y solapamientos al inicio. 3. Documentar decisiones, compartir avances y reasignar tareas si es necesario.

**45. ¿Qué harían si una persona clave no está disponible?**  
Revisar el estado en GitHub, consultar la documentación, reasignar la tarea, reducir funciones opcionales si hace falta y registrar la decisión.

## 10. Preparación para desarrollar

**46. ¿Hay decisiones fundamentales pendientes?**  
Sí: alcance final, versiones de herramientas, duración de servicios, reglas de modificación/cancelación, horarios laborales y si el docente exige módulos adicionales. Deben cerrarse antes de desarrollar todos los módulos.

**47. ¿Hay requisitos que aún no comprenden?**  
Deben concretarse los casos límite de solapamiento, duración de servicio, citas con varios servicios, pausas y horarios laborales.

**48. ¿Falta una dependencia o recurso?**  
El árbol actual de GitHub no contiene código de aplicación ni scripts SQL. Se debe verificar que todos puedan abrir el entorno y conectarse a una base de prueba. No afirmar que está probado hasta guardar evidencia.

**49. ¿Cada integrante sabría qué construir primero?**  
Tarea inicial propuesta: Ekaitz define el esquema mínimo y prueba la conexión; Leonor diseña los formularios y flujo de citas; Jairo prepara casos de prueba y registro de resultados. Deben acordar los campos antes de integrar.

**50. ¿Un nuevo integrante entendería el proyecto solo con el repositorio?**  
La documentación incorporada explica el problema, alcance, requisitos, arquitectura, plan y pruebas. Para completar la preparación de ejecución, deberán añadirse el código, scripts SQL, instrucciones de instalación y evidencias reales cuando existan.

## 11. Prueba de fracaso

**51. ¿Qué tendría que ocurrir para que el proyecto fracase?**  
Intentar desarrollar demasiadas funciones, no conectar la aplicación con la base de datos, permitir citas superpuestas, no integrar las partes, no probar o perder avances por falta de coordinación.

**52. ¿Hay estrategia para evitar esas condiciones?**  
Sí, como plan preventivo: mantener un MVP reducido, probar conexión temprano, diseñar casos de solapamiento, integrar por partes, revisar avances semanalmente, documentar decisiones y reservar tiempo para correcciones. Su eficacia se comprobará durante el desarrollo.

## Pendientes reales del equipo

- Confirmar con el docente que el MVP propuesto cumple la consigna.
- Validar el problema con usuarios y documentar resultados reales.
- Confirmar fecha de entrega, versiones y estimaciones.
- Acordar las reglas de negocio que aún están abiertas.
- Ejecutar pruebas y adjuntar evidencias; no marcar como realizadas las que solo están planificadas.
- Actualizar este documento conforme avance el proyecto.
