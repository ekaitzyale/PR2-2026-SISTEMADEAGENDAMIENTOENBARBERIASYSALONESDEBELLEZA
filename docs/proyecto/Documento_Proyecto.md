<PARSED TEXT FOR PAGE: 1 / 19>
Cochabamba - Bolivia
UNIVERSIDAD PRIVADA “FRANZ TAMAYO”
FACULTAD DE INGENIERIA
Programación 2
SISTEMA DE AGENDAMIENTO Y GESTIÓN 
PARA BARBERÍAS Y SALONES DE BELLLEZA
INTEGRANTES:
EKAITZ YALE YAULI
LEONOR ALEJANDRA ALMANZA ARROYO
JAIRO DAMIAN RODRÍGUEZ HUANCA
DOCENTE: ING. DIEGO PATRICK CARDENAS SEJAS
<PARSED TEXT FOR PAGE: 2 / 19>
1. ORGANIZACIÓN DEL EQUIPO DE DESAROLLO
1.1. Nombre del equipo
El equipo de desarrollo operará bajo el nombre de Virus.
1.2. Estructura Organizativa, Roles y Reponsabilidades
Para asegurar la correcta ejecución del software, se definió la siguiente distribución de 
roles y tareas:
• Ekaitz Yale Yauli – Líder de Proyecto y Desarrollo Backend: Responsable 
de coordinar la arquitectura lógica del sistema, la estructuración de la base de 
datos relacional en SQL Server, la integración mediante C# (ADO.NET) y el 
diseño del algoritmo principal.
• Leonor Alejandra Almanza Arroyo – Diseñadora UI/UX y Derarolladora 
Frontend: Encargada del diseño visual de los formularios en Windows Forms, 
la usabilidad de la interfaz, el flujo de navegación del usuario y la 
diagramación del fluxograma principal.
• Jairo Damian Rodriguez Huanca – Encargado de Control de Calidad 
(QA) y Documentación: Responsable de la ejecución de pruebas funcionales 
(validación de datos, control de superposición de citas), recopilación de 
anexos, registro de interacción con herramientas de IA y la consolidación 
formal del documento en formato APA.
<PARSED TEXT FOR PAGE: 3 / 19>
1.3. Mecanismo de Coordinación y Trabajo Colaborativo
• Metodología de trabajo: Se emplea un enfoque ágil adaptado con interacciones
cortas (sprints) alineadas con los hitos académicos de la materia.
• Canales de comunicación: Coordinación continua vía grupo de trabajo en 
Discord/WhatssApp y almacenamiento centralizado de documentación en 
Google Drive.
• Control de versiones: Uso de un repositorio en GitHub para la gestión del 
código fuente en Visual Studio y los scripts de la base de datos.
2. DESCRIPCIÓN DEL PROBLEMA A RESOLVER
2.1. Antecedentes y Contexto
En la ciudad de Cochabamba, un amplio número de barberías y salones de belleza 
pertenecientes al sector de micro y pequeñas empresas (MIPYMES) experimenta una demanda 
creciente de servicios de cuidado personal. No obstante, sus procesos administrativos continúan 
apoyándose en métodos tradicionales de gestión de agenda.
2.2. Situación Actual
El proceso de agendamiento se realiza mediante registros manuales en cuadernos o 
agendas físicas, complementado de manera informal con la recepción de mensajes a través de 
WhatsApp. Esta dinámica exige que el personal interrumpa sus labores operativas para responder 
mensajes y consultar disponibilidad en papel.
2.3. Personas y Sectores Afectados
<PARSED TEXT FOR PAGE: 4 / 19>
• Administradores/Proprietarios: Presentan pérdidas de tiempo operativo, falta 
de métricas consolidadas sobre el rendimiento del negocio e imposibilidad de 
llevar un registro histórico confiable de sus clientes.
• Trabajadores (Barberos y Estilistas): Sufren cruces de horarios, superposición 
de citas y falta de claridad respecto a sus jornadas diarias de trabajo.
• Clientes: Afrontan demoras en la confirmación de turnos, riesgo de doble reserva 
(dos clientes citados a la misma hora con el mismo profesional) y tiempos de 
espera innecesarios en el establecimiento.
2.4. Relevancia del Problema
Desarrollar una solución informática que automatice y centralice el proceso de 
agendamiento elimina el error humano por duplicidad de turnos, optimiza la productividad del 
personal, mejora la satisfacción del cliente y sienta las bases tecnológicas para la escalabilidad 
del negocio.
3. OBJETIVOS ESPECÍFICOS
• Diseñar e implementar una base de datos relacional en SQL Server para almacenar de 
forma estructurada la información de clientes, trabajadores, servicios, horarios y citas.
• Desarrollar una interfaz gráfica intuitiva en C# utilizando Windows Forms, 
permitiendo la gestión completa (operaciones CRUD) de los distintos módulos del 
sistema.
• Programar un algoritmo de validación de disponibilidad que impida automáticamente 
el registro de citas solapadas o duplicadas para un mismo profesional en una misma 
fecha y rango horario.
<PARSED TEXT FOR PAGE: 5 / 19>
• Implementar un panel de control (Dashboard) que despliegue métricas e información 
en tiempo real sobre las citas programadas, atendidas y canceladas del día.
• Establecer un módulo de consulta de historial y reportes que facilite el seguimiento 
del comportamiento del cliente y el volumen de servicios prestados por el personal.
4. ALGORITMO PRINCIPAL DEL PROYECTO
Algoritmo: GestionarCita
INICIO
1. Mostrar el módulo de gestión de citas.
2. Seleccionar o buscar al cliente.
3. Seleccionar el servicio que desea realizar.
4. Seleccionar el profesional que realizará el servicio.
5. Seleccionar la fecha de la cita.
6. Consultar el horario de atención del profesional.
7. ¿El profesional trabaja en la fecha seleccionada?
 SI:
 - Consultar las citas registradas para esa fecha.
 - Continuar con el proceso.
 NO:
 - Mostrar el mensaje: “El profesional no atiende en la fecha seleccionada”.
 - Solicitar una nueva fecha.
 - Volver al paso 5.
8. Mostrar los horarios disponibles del profesional.
9. ¿Existen horarios disponibles?
 SI:
 - Mostrar los horarios disponibles.
 - Permitir seleccionar una hora.
 NO:
 - Mostrar el mensaje: “No existen horarios disponibles”.
 - Solicitar otra fecha u horario.
 - Volver al paso 5.
10. Seleccionar la hora para la cita.
11. Validar los datos de la cita:
 - Cliente.
 - Servicio.
 - Profesional.
 - Fecha.
 - Hora.
<PARSED TEXT FOR PAGE: 6 / 19>
12. ¿Los datos son correctos y el horario continúa disponible?
 SI:
 - Registrar la cita en la base de datos.
 - Mostrar el mensaje: “Cita registrada correctamente”.
 NO:
 - Mostrar el mensaje: “Los datos son incorrectos o el horario ya está ocupado”.
 - Solicitar la corrección de los datos.
 - Volver al paso 10.
13. Mostrar las opciones para consultar, modificar o cancelar la cita registrada.
FIN
5. FLUJOGRAMA PRINCIPAL DEL PROYECTO
<PARSED TEXT FOR PAGE: 7 / 19>
Figura 1
Diagrama de Flujo del Proceso de Gestión de Citas
Nota: Elaboración propia.
6. INVESTIGACIÓN Y JUSTIFICACIÓN TECNOLÓGICA
6.1. Cuadro Comparativo de Tecnologías Evaluadas
Tabla 1
Comparativa de Tecnologías Evaluadas
<PARSED TEXT FOR PAGE: 8 / 19>
Criterio de 
Evaluación
C# + Windows Forms Java (Swing / JavaFX) Python (Tkinter / 
PyQt)
Integración 
con BD
Integración nativa y fluida 
con SQL Server vía 
ADO.NET.
Alta compatibilidad 
mediante conectores 
JDBC.
Buena mediante 
ORMs o librerías 
específicas.
Desarrollo 
Visual Desktop
Diseñador visual por 
arrastre de controles 
(WYSIWYG) altamente 
eficiente.
Complejidad media en la 
maquetación y diseño de 
componentes.
Maquetación basada 
principalmente en 
código.
Curva de 
Aprendizaje
Ideal para los objetivos 
académicos de 
Programación II.
Media a alta por el 
manejo del entorno de la 
JVM.
Baja a media.
Rendimiento 
en Windows
Desempeño nativo 
optimizado para el entorno 
Microsoft Windows.
Dependiente de la 
máquina virtual de Java.
Moderado en 
interfaces complejas.
Nota. Cuadro comparativo elaborado para la evaluación de tecnologías para entornos de escritorio.
6.2. JUSTIFICACIÓN TÉCNICA
Se determinó seleccionar el ecosistema C# + Windows Forms + SQL Server debido a los 
siguientes factores técnicos:
• Entorno Integrado: Visual Studio proporciona un ambiente robusto para el 
modelado de formularios guiados por eventos.
• Control Transaccional: ADO.NET permite ejecutar consultas directas y 
procedimientos almacenados en SQL Server, garantizando un control estricto en 
la verificación de disponibilidades ocurrentes.
• Modularidad: La separación en capas de la lógica de negocio facilita futuras 
migraciones a plataformas web o móviles en etapas académicas posteriores.
<PARSED TEXT FOR PAGE: 9 / 19>
7. ANÁLISIS DE IMPACTO Y USUARIOS FINALES
7.1. Usuarios Finales y Beneficios Concretos
• Administradores: Visibilidad global del estado del negocio en tiempo real, 
reducción drástica de tiempos administrativos y eliminación de registros en 
papel.
• Personal Operativo (Barberos/Estilistas): Organización clara de la jornada 
laboral, eliminación de sobrecargas por empalme de citas y optimización del 
tiempo por servicio.
• Clientes Finales: Reducción de tiempos de espera, garantía de disponibilidad en 
el horario reservado y atención ágil.
7.2. Estimación de Comercialización
• Licencia de Uso Local (Instalación y Configuración Única): $US 350 - $US 
500.
• Modelo por Suscripción (SaaS): $US 25 - $US 35 mensuales.
• Justificación de Comercialización: La inversión se justifica plenamente 
mediante el retorno directo derivado de evitar pérdidas de clientes por 
desorganización o citas canceladas por duplicidad.
7.3. Viabilidad de Mercado en Cochabamba
El proyecto presenta una alta factibilidad de comercialización en Cochabamba debido a la 
elevada concentración de salones de belleza y barberías informales en zonas comerciales que 
requieren soluciones digitales accesibles y de rápida implementación sin costos excesivos de 
infraestructura.
8. ESTIMACIÓN DE COSTOS Y FACTIBILIDAD FINANCIERA 
<PARSED TEXT FOR PAGE: 10 / 19>
A continuación, se detalla la estimación presupuestaria para un ciclo de desarrollo de 3 
meses:
8.1. Recursos Tecnológicos
• Licencias de Software (Visual Studio Community, SQl Server Express): $US 
0 (Uso de ediciones comunitarias y gratuitas)
• Equipos de Cómputo (Depreciación de 3 laptops durante el periodo): $US 
150.
• Servicios de Conectividad e Internet ($US 30/mes por 3 meses): $US 90.
• Subtotal Recursos Tecnológicos: $US 240
8.2. Recursos Humanos
• 3 desarrolladores / estudiantes (10 hrs/semana cada uno durante 12 semanas 
= 360 horas a $US 5/hora): $US 1.800.
• Subtotal Recursos Humanos: $US 1.800.
8.3. Otros Gastos
• Gastos Operativos (Transporte, levantamiento de requerimientos y 
papelería): $US 60.
• Reserva de Contingencia (10%): $US 210.
• Subtotal Otros Gastos: $US 270.
COSTO TOTAL ESTIMADO DEL PROYECTO: $US 2.310
9. ESTADO ACTUAL Y PLANIFICACIÓN DEL PROYECTO
9.1. Estado actual del proyecto
Actualmente, el proyecto se encuentra en una etapa de planificación y preparación para 
su posterior implementación. Hasta el momento, el equipo ha trabajado principalmente 
<PARSED TEXT FOR PAGE: 11 / 19>
en la definición del problema, los objetivos, la estructura general del sistema, el 
algoritmo principal, las tecnologías que serán utilizadas y la distribución de 
responsabilidades entre los integrantes.
La propuesta del sistema consiste en desarrollar una aplicación de escritorio para la 
gestión de citas en barberías y salones de belleza. El sistema tendrá como finalidad 
organizar la información de clientes, trabajadores, servicios, horarios y citas, además de 
controlar la disponibilidad de los profesionales para evitar la duplicidad de reservas.
En esta etapa todavía no se ha iniciado formalmente la implementación completa del 
sistema. Por este motivo, las actividades de programación, creación de la base de datos, 
integración, pruebas y documentación final se consideran actividades pendientes dentro 
del cronograma del proyecto.
9.2. Actividades planificadas
Para continuar con el desarrollo del proyecto se establecieron las siguientes actividades:
1. Revisar y definir los requerimientos funcionales y no funcionales del sistema.
2. Diseñar y revisar el modelo de la base de datos.
3. Crear las tablas y relaciones en SQL Server.
4. Diseñar las interfaces principales utilizando Windows Forms.
5. Desarrollar los módulos principales del sistema.
6. Implementar las operaciones CRUD.
7. Conectar la aplicación de C# con SQL Server mediante ADO.NET.
8. Implementar la validación de disponibilidad de horarios.
9. Desarrollar el Dashboard y los módulos de consulta y reportes.
10. Realizar pruebas funcionales del sistema.
<PARSED TEXT FOR PAGE: 12 / 19>
11. Corregir errores y realizar ajustes.
12. Elaborar la documentación final y el manual de usuario.
13. Preparar la presentación y demostración final.
9.3. Metodología de trabajo
Para el desarrollo se mantendrá el enfoque ágil planteado inicialmente, organizando el 
trabajo mediante actividades progresivas y revisiones periódicas.
Cada etapa será revisada antes de avanzar a la siguiente, con el objetivo de detectar 
errores y realizar modificaciones oportunamente. El equipo utilizará GitHub para el 
control de versiones del código y Google Drive para la documentación, manteniendo los 
canales de comunicación establecidos anteriormente.
9.4. Cronograma tentativo
Debido a que el proyecto todavía se encuentra en una etapa inicial, el cronograma 
presentado corresponde a una planificación tentativa. Las fechas podrán modificarse de 
acuerdo con el avance real del equipo y las fechas establecidas por la asignatura.
El cronograma contempla las etapas de análisis, diseño, implementación, integración, 
pruebas, documentación y preparación de la presentación final.
9.5. Diagrama de Gantt
<PARSED TEXT FOR PAGE: 13 / 19>
El diagrama de Gantt permite representar visualmente las actividades previstas para el 
desarrollo del proyecto, indicando el periodo aproximado en el que cada actividad será 
realizada.
El cronograma considera una secuencia progresiva, comenzando con el análisis y diseño, 
continuando con la implementación e integración del sistema y finalizando con las 
pruebas, documentación y presentación del proyecto.
10. MODELO RELACIONAL DE NUESTRO SISTEMA DE AGENDAMIENTO
<PARSED TEXT FOR PAGE: 14 / 19>
Explicación del modelo relacional – Sistema de Agendamiento
El modelo relacional representa la estructura de una base de datos para un sistema de 
agendamiento de servicios. Su función es organizar la información de clientes, trabajadores, 
servicios, citas, productos y facturas, relacionando las diferentes tablas entre sí.
Sucursal
La tabla SUCURSAL almacena los datos de las diferentes sucursales del negocio. Contiene 
el identificador de la sucursal, nombre, dirección y teléfono. El identificador id_sucursal es la 
clave primaria (PK).
Cliente
<PARSED TEXT FOR PAGE: 15 / 19>
La tabla CLIENTE contiene los datos de las personas que utilizan los servicios. Sus campos 
son id_cliente, nombre, apellido, teléfono y correo. El id_cliente permite identificar de 
manera única a cada cliente.
Un cliente puede tener varias citas, por lo que existe una relación de 1:N entre CLIENTE y 
Servicio
La tabla SERVICIO registra los servicios disponibles, incluyendo id_servicio, nombre del 
servicio, precio e id_categoria. El campo id_categoria es una clave foránea (FK) que permite 
relacionar cada servicio con su categoría.
Categoría de servicio
Categoría de servicio
La tabla CATEGORIA_SERVICIO permite clasificar los servicios. Contiene id_categoria, 
nombre de la categoría y descripción. Una categoría puede contener varios servicios, 
estableciendo una relación 1:N entre CATEGORIA_SERVICIO y SERVICIO.
Trabajador
La tabla TRABAJADOR almacena los datos generales de los empleados, como 
id_trabajador, nombre, apellido, fecha de contratación y salario.
Esta tabla se relaciona con las tablas ADMINISTRATIVO y PROFESIONAL, permitiendo 
diferenciar los tipos de trabajadores que existen en el sistema.
Administrativo y Profesional
<PARSED TEXT FOR PAGE: 16 / 19>
La tabla ADMINISTRATIVO representa a los trabajadores que realizan funciones 
administrativas y contiene el cargo que desempeñan.
La tabla PROFESIONAL representa a los trabajadores que realizan los servicios. Contiene 
los años de experiencia del profesional.
A su vez, la tabla PROFESIONAL se especializa en BARBERO y ESTILISTA, permitiendo 
registrar información específica de cada tipo de profesional.
Cita
La tabla CITA es una de las principales del sistema, ya que registra las reservas realizadas por 
los clientes. Contiene id_cita, fecha y hora, estado, id_cliente, id_profesional e id_sucursal.
Las claves foráneas permiten conocer qué cliente realizó la cita, qué profesional lo atenderá y 
en qué sucursal se realizará.
Detalle de cita
La tabla DETALLE_CITA registra los servicios incluidos en cada cita. Contiene id_detalle, 
id_cita, id_servicio y precio_aplicado.
Una cita puede tener uno o varios servicios, por lo que esta tabla permite almacenar cada 
servicio de manera independiente.
Producto
<PARSED TEXT FOR PAGE: 17 / 19>
La tabla PRODUCTO almacena los productos disponibles en el negocio. Contiene 
id_producto, nombre del producto, precio unitario y stock. El campo stock permite controlar 
la cantidad disponible de cada producto.
Factura
La tabla FACTURA registra las facturas generadas a partir de las citas. Contiene id_factura, 
fecha de emisión, total e id_cita.
De esta forma, una factura puede relacionarse con la cita correspondiente y registrar el pago 
de los servicios realizados.
Factura detalle
La tabla FACTURA_DETALLE registra los productos incluidos en cada factura. Contiene 
id_factura_detalle, id_factura, id_producto, cantidad y subtotal.
Esta tabla permite registrar varios productos dentro de una misma factura y calcular el 
subtotal correspondiente a cada uno.
Claves primarias y foráneas
Las claves primarias (PK) permiten identificar de forma única cada registro de una tabla. Por 
ejemplo, id_cliente identifica a cada cliente.
<PARSED TEXT FOR PAGE: 18 / 19>
Las claves foráneas (FK) permiten relacionar una tabla con otra. Por ejemplo, id_cliente 
dentro de CITA permite identificar al cliente que realizó la reserva.
Relaciones del modelo
Las relaciones representadas como 1:N significan que un registro de una tabla puede estar 
relacionado con varios registros de otra tabla. Por ejemplo, un cliente puede tener varias 
citas, una categoría puede tener varios servicios y una factura puede contener varios detalles.
En general, el funcionamiento del sistema puede representarse de la siguiente manera:
Cliente → Cita → Profesional y Sucursal → Detalle de Cita → Servicio → Categoría
Y para la facturación:
Cita → Factura → Factura Detalle → Producto
Objetivo del modelo
El objetivo de este modelo relacional es organizar correctamente la información del sistema 
de agendamiento, evitando la repetición innecesaria de datos y facilitando el registro y 
consulta de clientes, trabajadores, servicios, citas, productos y facturas. De esta manera, las 
diferentes tablas se encuentran relacionadas y permiten manejar la información de forma 
ordenada.
<PARSED TEXT FOR PAGE: 19 / 19>
11. ANEXOS
Anexo A: Evidencia de Documentación Consultada
• Documentación oficial de Microsoft Learn referente a la conectividad ADO.NET con 
C#.
• Guías de diseño relacional y normalización de bases de datos para SQL Server.
Anexo B: Registro de Interacción con Herramientas de Inteligencia Artificial
• Herramientas empleadas: Gemini
• Prompt de consulta:
“Diseña la estructura lógica en algoritmo para un sistema en C# con SQL Server 
que valide la disponibilidad horaria de una cita en una barbearía, verificando la 
tabla CITAS y HORARIOS para evitar empalmes de tiempo.”
• Resultado e Impacto: El análisis obtenido sirvió como base para la 
estructuración de la lógica de validación del sistema y la definición del algoritmo 
principal del proyecto.