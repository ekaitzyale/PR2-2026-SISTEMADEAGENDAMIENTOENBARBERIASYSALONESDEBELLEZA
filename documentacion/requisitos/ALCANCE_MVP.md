# Alcance del proyecto y MVP

**Estado:** propuesta que el equipo debe aprobar y confirmar con el docente.

## 1. Objetivo del producto

Desarrollar una aplicación de escritorio para organizar clientes, profesionales, servicios y citas, y reducir errores de agenda mediante una validación de disponibilidad.

## 2. MVP: primera versión funcional

La primera versión propuesta permitirá:
1. Registrar, consultar y modificar clientes.
2. Registrar y consultar profesionales.
3. Registrar y consultar servicios con duración y precio.
4. Registrar citas con cliente, servicio, profesional, fecha y hora.
5. Consultar agenda por fecha y profesional.
6. Modificar y cancelar citas.
7. Rechazar citas que se superpongan con otra cita activa del mismo profesional.
8. Guardar y recuperar datos desde SQL Server.
9. Mostrar mensajes claros para datos inválidos y errores al guardar.

**Valor entregado:** el personal puede mantener una agenda centralizada y recibir una advertencia antes de guardar una cita que se cruce con otra del mismo profesional.

## 3. Fuera del MVP

Se propone dejar para una etapa posterior:
- Reservas directas por web o aplicación móvil.
- Confirmaciones automáticas por WhatsApp, SMS o correo.
- Pagos en línea y facturación fiscal.
- Productos e inventario.
- Múltiples sucursales.
- Dashboard avanzado y reportes comerciales complejos.
- Integración con calendarios externos.

Estas funciones pueden ser útiles, pero se posponen para reducir el riesgo de no terminar el núcleo. El equipo debe confirmar que la consigna del curso permite excluirlas.

## 4. Si se reduce el proyecto un 40 %

Conservar: conexión y base de datos mínima, clientes, profesionales, servicios, gestión de citas y validación de solapamientos. Posponer reportes avanzados, dashboard, facturación e inventario.

## 5. Definición de terminado

El MVP se considera terminado cuando los módulos incluidos se ejecutan; los datos persisten en SQL Server; las operaciones principales funcionan con datos válidos e inválidos; los casos de solapamiento se comportan correctamente; las pruebas tienen resultados registrados; y las instrucciones permiten que otro integrante prepare el entorno.

## 6. Decisiones que deben cerrarse antes de programar

- Confirmar alcance con el docente.
- Acordar duración de servicios y si una cita puede incluir varios servicios.
- Definir estados de cita y si cancelar libera el horario.
- Definir horarios laborales, pausas y días no laborables.
- Acordar versiones de .NET, SQL Server y herramientas.
- Confirmar fecha de entrega y ajustar el plan.
