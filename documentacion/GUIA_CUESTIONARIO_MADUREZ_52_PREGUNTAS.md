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
Se realizó una investigación inicial en la zona, observando el funcionamiento diario de varios negocios del rubro. Se identificó que la mayoría gestiona sus agendas de forma manual, utilizando cuadernos, hojas sueltas o aplicaciones de mensajería, lo que provoca confusión en los horarios, duplicidad de reservas y demoras al intentar consultar disponibilidad. Estas observaciones confirman que la desorganización de la agenda es una necesidad real y frecuente en este tipo de negocios.

**4. ¿Qué consecuencias tiene el problema?**  
Confusión en la agenda, reservas duplicadas del mismo profesional en el mismo horario, tiempo perdido gestionando consultas, clientes que llegan y no son atendidos, demoras en el servicio y dificultad para saber con anticipación qué citas hay pendientes.

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
Sí. Administrador: gestiona registros del sistema y supervisa la agenda; Profesional: consulta sus turnos del día; Personal de recepción: registra clientes y crea/modifica/cancela citas. En esta versión MVP todos acceden desde la misma aplicación de escritorio sin diferenciación de perfiles de acceso; se considerarán roles específicos en una versión posterior.
 

**12. ¿Las funciones responden a necesidades reales?**  
Sí. Registrar clientes y profesionales evita escribir los datos repetidamente; definir servicios permite saber qué se va a realizar; gestionar citas centraliza la información en un solo lugar; validar horarios evita los cruces que los entrevistados identificaron como su principal problema.

**13. ¿Las funciones están descritas para que otro integrante las desarrolle?**  
Sí. Cada módulo cuenta con su propósito, campos principales y comportamiento esperado en el documento de requisitos: Clientes (nombre, teléfono), Profesionales (nombre, especialidad), Servicios (nombre, precio, duración), Citas (cliente, profesional, servicio, fecha y hora), y validación de disponibilidad antes de guardar.

**14. ¿Cada función tiene criterios verificables?**  
Sí. Por ejemplo: "al intentar guardar una cita con el mismo profesional en un horario ya ocupado, el sistema muestra un mensaje explicativo y no guarda el registro"; "al registrar una cita válida, esta se persiste en la base de datos y aparece en la lista de citas del día". Los criterios detallados se encuentran en el documento de casos de prueba.

**15. ¿Hay requisitos de calidad?**  
Sí: validación de campos obligatorios y formatos; mensajes claros en español; no permitir datos duplicados; guardar toda modificación en la base de datos; usar consultas parametrizadas para proteger la integridad de los datos; interfaz comprensible sin necesidad de manual extenso; y funcionamiento en entorno Windows con SQL Server conectado.

## 4. Alcance

**16. ¿Está definido qué desarrollarán?**  
MVP propuesto: aplicación de escritorio para clientes, profesionales, servicios, citas, agenda, validación de disponibilidad y persistencia en SQL Server.

**17. ¿Está definido qué no desarrollarán?**  
Sí. Queda fuera del alcance del MVP: reservas desde página web o aplicación móvil, envío automático de recordatorios, procesamiento de pagos en línea, generación de facturas fiscales, control de inventario de productos, gestión de múltiples sucursales y paneles estadísticos avanzados. Estas funciones se evaluarán para una versión posterior si el proyecto continúa.

**18. ¿Identificaron funciones interesantes pero no esenciales?**  
Sí: dashboard avanzado, reportes, facturación, productos e inventario. Se posponen hasta completar la agenda.

**19. ¿El alcance es realista?**  
Sí. El alcance del MVP se limita a las operaciones esenciales que resuelven el problema principal identificado. Se ajusta al tiempo disponible y al conocimiento actual del equipo. Se priorizó que lo esencial funcione correctamente sobre incluir muchas funciones sin completar.

**20. Si redujeran el proyecto un 40 %, ¿qué conservarían?**  
Se conservarían estrictamente: registro de profesionales, registro de clientes, definición de servicios, agenda de citas y la validación que impide solapamientos. Se eliminaría temporalmente la modificación y cancelación de citas desde la interfaz, así como la búsqueda avanzada y reportes. La edición de registros se recuperaría en cuanto lo esencial esté funcionando.
## 5. MVP

**21. ¿Existe una primera versión funcional definida?**  
Sí, como propuesta: aplicación de escritorio conectada a SQL Server para administrar los datos mínimos y registrar citas sin solapamientos.

**22. ¿Resuelve una parte real del problema?**  
Sí: centraliza la agenda y evita reservas incompatibles del mismo profesional.

**23. ¿Puede terminarse a tiempo?**  
Sí. La conexión con la base de datos ya está probada y funciona correctamente. Los módulos restantes son independientes entre sí y se pueden desarrollar en paralelo. Se cuenta con un plan de trabajo semanal que permite completar todo antes de la fecha de entrega establecida.

**24. ¿Las funciones posteriores están separadas?**  
Sí: reservas públicas, notificaciones, dashboard avanzado, reportes complejos, facturación, productos e inventario se proponen como mejoras posteriores.

## 6. Diseño y viabilidad técnica

**25. ¿Es viable con las tecnologías del equipo?**  
La propuesta usa C#, Windows Forms, SQL Server y ADO.NET, previstas en el documento inicial. La viabilidad debe confirmarse con una prueba de conexión y persistencia.

**26. ¿Identificaron las partes técnicamente difíciles?**  
Sí: conexión a SQL Server, relaciones de datos, validación de intervalos horarios, modificación de citas y manejo de errores.

**27. ¿Validaron las integraciones críticas?**  
Sí. Se realizó una prueba de conexión desde la aplicación de C# hacia SQL Server. La conexión se estableció exitosamente y se obtuvo confirmación del sistema. Queda pendiente realizar pruebas de lectura y escritura de registros reales, que se ejecutarán una vez definida la estructura de tablas.

**28. ¿Las decisiones tecnológicas están justificadas?**  
C# y Windows Forms para la aplicación de escritorio; SQL Server para datos relacionales; ADO.NET para la conexión desde C#. La elección coincide con el entorno planteado para la materia.

**29. ¿Identificaron dependencias externas?**  
Sí. El sistema requiere: sistema operativo Windows; Visual Studio con soporte para C# y .NET Framework; instancia de SQL Server accesible; y que todos los integrantes del equipo tengan instalados y configurados estos componentes. Se verificó que cada integrante cuenta con el entorno instalado y funcional.

**30. ¿La estructura técnica es clara?**  
Sí. Se organiza en tres capas: 1) Capa de presentación: formularios de Windows Forms; 2) Capa de acceso a datos: clase ConexionBD responsable de conectar y ejecutar consultas en SQL Server; 3) Capa de lógica: clases que representan Clientes, Profesionales, Servicios y Citas. No se implementa arquitectura compleja innecesaria para el alcance del MVP.

## 7. Datos, seguridad y calidad

**31. ¿Qué información manejará el sistema y de dónde provendrá?**  
Datos introducidos por el personal: clientes, profesionales, servicios y citas. Para pruebas se usarán datos ficticios. No se cargarán datos reales sin autorización.

**32. ¿Hay restricciones de privacidad y seguridad?**  
Sí. Se manejan datos personales básicos como nombres y teléfonos; no se solicitarán datos sensibles. La cadena de conexión no se almacenará en código visible ni en el repositorio público. Los datos de prueba que se usen durante el desarrollo serán ficticios. No se compartirá información de los usuarios reales con terceros.
 
**33. ¿Cómo comprobarán las funciones?**  
Mediante casos de prueba diseñados antes de codificar cada módulo: datos válidos que deben guardarse; datos incompletos o incorrectos que deben rechazarse; citas que se solapan que deben ser bloqueadas; y modificación/eliminación de registros con confirmación. Cada caso se ejecuta y se registra el resultado obtenido.

**34. ¿Hay una estrategia inicial de pruebas?**  
Sí. Se realizarán: pruebas unitarias por formulario; pruebas de validación de entradas; pruebas de persistencia para verificar que los cambios se guardan en SQL Server; pruebas de integración para confirmar que todos los formularios usan la misma base de datos correctamente; y pruebas de regresión para asegurar que al agregar algo nuevo no se rompa lo que ya funcionaba.
 
## 8. Plan de desarrollo

**35. ¿El Gantt tiene tareas concretas?**  
Sí. Se detalla por semana: Semana 1 — Definir alcance, entrevistar usuarios y diseñar la base de datos; Semana 2 — Crear tablas en SQL Server y configurar la conexión desde C#; Semana 3 — Desarrollar formularios de mantenimiento; Semana 4 — Desarrollar agenda y regla de validación de horarios; Semana 5 — Pruebas completas, corrección de errores y preparación de entrega final.

**36. ¿Cada tarea tiene responsable?**  
Ekaitz: backend/base de datos; Leonor: interfaz y flujo; Jairo: pruebas y documentación. Integración y alcance son responsabilidad compartida.

**37. ¿Las estimaciones son razonables?**  
Las estimaciones por etapas son propuestas y deben ajustarse según disponibilidad real y fecha de entrega confirmada.

**38. ¿Las dependencias están identificadas?**  
Sí. No se pueden crear los formularios de citas sin antes tener definida la estructura de la base de datos; no se puede probar la persistencia sin tener la conexión funcionando; no se puede integrar todo sin que cada módulo funcione por separado; y no se puede entregar sin haber ejecutado las pruebas finales.
**39. ¿Se contemplan desarrollo, integración, pruebas, correcciones y documentación?**  
Sí, están incluidas en el plan propuesto.

**40. ¿Qué tareas podrían bloquear al resto?**  
Definición del modelo de datos, configuración de la conexión a la base de datos y la lógica de validación de horarios. Por eso se programaron al inicio del cronograma y cada una se prueba de forma independiente antes de continuar con las siguientes.
 
## 9. Equipo y riesgos

**41. ¿Cada integrante tiene responsabilidad verificable?**  
Ekaitz: modelo, base de datos y acceso a datos; Leonor: formularios, navegación y validaciones visuales; Jairo: pruebas, resultados y documentación.

**42. ¿Hay mecanismo de revisión e integración?**  
Se propone usar GitHub, commits descriptivos, revisión antes de integrar a main, pruebas conjuntas y registro escrito de decisiones. Mantener los canales de coordinación acordados por el equipo.

**43. ¿Cuáles son los tres riesgos principales?**  
1. Agregar funciones fuera del alcance acordado y no terminar a tiempo; 2. Que la validación de horarios permita citas superpuestas por error de lógica; 3. Que algún integrante no pueda participar y afecte el avance.

**44. ¿Hay mitigación para cada riesgo?**  
1. Cualquier idea nueva se anota y se evalúa para una versión posterior, no se agrega al MVP en curso; 2. Se probará la validación con varios escenarios: misma hora, hora dentro de otra cita, hora de inicio coincidiendo con fin de otra, y horarios separados; 3. Todo avance se sube al repositorio y se documenta para que cualquiera pueda continuar sin depender de una sola persona.
 

**45. ¿Qué harían si una persona clave no está disponible?**  
Revisar el repositorio para ver el último trabajo realizado, leer los comentarios del código y documentos, distribuir las tareas pendientes entre los integrantes restantes, comunicar al equipo y al docente la situación si afecta la fecha de entrega, y simplificar funciones opcionales si es necesario para cumplir con lo esencial.
 
## 10. Preparación para desarrollar

**46. ¿Hay decisiones fundamentales pendientes?**  
Sí, pero ya están identificadas y se resolverán antes de implementar los módulos correspondientes: confirmar con el docente que el alcance propuesto cumple con los requisitos de la asignatura; definir la duración estándar de cada tipo de servicio; establecer el horario de atención; y acordar si se podrán modificar o eliminar citas una vez registradas.

**47. ¿Hay requisitos que aún no comprenden?**  
Los casos límite de solapamiento horario ya fueron analizados: se validará que la hora de inicio de la nueva cita no quede entre la hora de inicio y fin de otra cita existente del mismo profesional. Quedan por definir detalles de interfaz y reportes secundarios que no afectan el funcionamiento del MVP.

**48. ¿Falta una dependencia o recurso?**  
No. El entorno de desarrollo está instalado y funcionando en las computadoras de cada integrante; la conexión con la base de datos ya fue probada exitosamente; el repositorio de GitHub está creado y accesible para todos. A medida que se generen los archivos del sistema, se subirán al repositorio para disponibilidad del equipo.

**49. ¿Cada integrante sabría qué construir primero?**  
Sí. Integrante 1: diseñar y crear las tablas en SQL Server; Integrante 2: diseñar los formularios de Clientes y Profesionales; Integrante 3: preparar los casos de prueba que se usarán para verificar cada función. Antes de integrar todo, se acuerda el nombre y tipo de cada campo para que todo funcione correctamente.

**50. ¿Un nuevo integrante entendería el proyecto solo con el repositorio?**  
Actualmente cuenta con el documento del problema, alcance, requisitos, arquitectura y plan de trabajo. A medida que avance el desarrollo se añadirá: el código completo de la aplicación, los scripts para crear la base de datos, un archivo README con instrucciones de instalación y configuración, y capturas de pantalla de las pruebas realizadas.

## 11. Prueba de fracaso

**51. ¿Qué tendría que ocurrir para que el proyecto fracase?**  
No lograr conectar la aplicación con la base de datos; que la validación de horarios no funcione y se generen reservas duplicadas; perder el control de qué está incluido y qué no; no coordinar entre el equipo y que las partes no encajen; o no reservar tiempo para probar y corregir errores antes de entregar.

**52. ¿Hay estrategia para evitar esas condiciones?**  
Sí: mantener el alcance simple y definido; probar la conexión a la base de datos desde el inicio como ya se hizo; diseñar con anticipación todos los escenarios de solapamiento y probarlos antes de entregar; integrar el trabajo poco a poco usando el repositorio compartido; y dejar al menos una semana completa solo para pruebas y correcciones finales.

## Pendientes reales del equipo

- Confirmar con el docente que el MVP propuesto cumple la consigna.
- Actualizar este documento conforme avance el proyecto.

##Evidencias: conexion aplicacion-Base de Datos
**Evidencia 1-Clase ConexionBD y cadena de conexion 

<img width="1292" height="612" alt="image" src="https://github.com/user-attachments/assets/277eecb8-047e-44bf-a565-fc2a59841bb7" />


Se muestra la clase responsable de gestionar la conexión con SQL Server. La variable  cadenaConexion  especifica el nombre del servidor, la base de datos  SistemaAgendamiento  y el tipo de autenticación utilizada. El método  ProbarConexion()  intenta abrir la conexión y devuelve  true  si es exitosa.


**Figura 2 — Prueba de conexión exitosa

<img width="804" height="490" alt="image" src="https://github.com/user-attachments/assets/eea01cb5-9f5c-43d2-822e-90b444cb6341" />


Al ejecutar la aplicación y presionar el botón "Probar", el sistema intenta establecer comunicación con la base de datos. Al lograrlo, muestra el mensaje "¡CONECTADO!", confirmando que la aplicación de Windows Forms se comunica correctamente con SQL Server.


**Figura 3 — Base de datos SistemaAgendamiento en SQL Server Management Studio

<img width="229" height="215" alt="image" src="https://github.com/user-attachments/assets/14b52a71-5a4d-46cf-871e-e61d60ea1b80" />


Se observa la base de datos  SistemaAgendamiento  dentro de la instancia del servidor, con su estructura de tablas ya creada:  Cliente ,  Profesional ,  Servicio  y  Cita . Esto confirma que el almacenamiento de datos está listo y accesible desde el motor de base de datos.

