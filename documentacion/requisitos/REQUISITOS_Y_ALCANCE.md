# Requisitos del sistema y alcance del MVP

**Proyecto:** Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza  
**Equipo:** Virus  
**Estado:** requisitos propuestos para el MVP; deben mantenerse sincronizados con el código, el script SQL y la consigna del docente.

## 1. Propósito y usuarios

El sistema de escritorio busca centralizar la información de clientes, profesionales, servicios y citas, y ayudar a prevenir reservas superpuestas.

- **Administrador/recepción:** registra y consulta información y gestiona citas.
- **Profesional:** necesita consultar sus turnos.
- **Cliente:** solicita la reserva al personal y recibe la atención. El MVP no contempla una aplicación pública web o móvil.

## 2. Requisitos funcionales

| ID | Requisito | Comportamiento esperado |
|---|---|---|
| RF-01 | Registrar cliente | Guardar nombre y teléfono; correo opcional. |
| RF-02 | Consultar/buscar cliente | Mostrar clientes y permitir búsqueda por nombre o teléfono. |
| RF-03 | Modificar cliente | Actualizar datos de un cliente existente. |
| RF-04 | Registrar profesional | Guardar nombre y especialidad. |
| RF-05 | Consultar profesional | Mostrar profesionales activos disponibles para citas. |
| RF-06 | Registrar servicio | Guardar nombre, duración estimada y precio. |
| RF-07 | Consultar servicio | Mostrar servicios activos con duración y precio. |
| RF-08 | Registrar cita | Seleccionar cliente, uno o varios servicios, profesional, fecha y hora de inicio. |
| RF-09 | Consultar agenda | Mostrar citas por fecha y profesional, con hora y estado. |
| RF-10 | Evitar solapamientos | Rechazar una cita que se cruce con otra cita no cancelada del mismo profesional. |
| RF-11 | Modificar cita | Volver a validar disponibilidad antes de guardar los cambios. |
| RF-12 | Cancelar cita | Cambiar el estado a cancelada y conservar el registro para consulta. |
| RF-13 | Validar entradas | Rechazar datos obligatorios vacíos, fechas inválidas y valores fuera de regla. |
| RF-14 | Persistir datos | Guardar y recuperar información en SQL Server mediante consultas parametrizadas. |

## 3. Criterios de aceptación

| ID | Criterio verificable |
|---|---|
| CA-01 | Un cliente válido se guarda y aparece al volver a consultarlo. |
| CA-02 | Un cliente sin campo obligatorio no se guarda y recibe un mensaje claro. |
| CA-03 | Un servicio requiere nombre, duración positiva y precio no negativo. |
| CA-04 | Una cita válida se guarda y aparece en la agenda. |
| CA-05 | Una cita que se cruza con otra no cancelada del mismo profesional se rechaza y no se guarda. |
| CA-06 | Una cita en horario libre puede guardarse si los demás datos son válidos. |
| CA-07 | La coincidencia de horario con otro profesional no bloquea la cita por sí sola. |
| CA-08 | Una cita cancelada deja de bloquear el horario, según la regla propuesta. |
| CA-09 | Al modificar una cita se vuelve a comprobar la disponibilidad, excluyendo la propia cita. |
| CA-10 | Al cancelar, el estado cambia y el registro permanece consultable. |
| CA-11 | Un error de conexión se informa sin cierre inesperado ni exposición de credenciales. |
| CA-12 | Las consultas usan parámetros y no concatenan directamente entradas del usuario en SQL. |

## 4. Regla de disponibilidad

Cada cita reserva un intervalo de inicio y fin. Para una nueva cita existe solapamiento si:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

La comparación se realiza para el mismo profesional y citas no canceladas. Al modificar una cita, se excluye su propio identificador. Dos citas consecutivas (por ejemplo, 10:00–10:30 y 10:30–11:00) no se solapan con esta regla.

La duración total de una cita se obtiene sumando las duraciones de los servicios incluidos en sus detalles. Los horarios laborales, pausas y días no laborables deben definirse antes de implementar esas restricciones.

## 5. Alcance del MVP

La primera versión propuesta contempla:
1. Registrar, consultar y modificar clientes.
2. Registrar y consultar profesionales.
3. Registrar y consultar servicios con duración y precio.
4. Registrar citas con cliente, profesional, servicio(s), fecha y hora.
5. Consultar la agenda por fecha y profesional.
6. Modificar y cancelar citas.
7. Validar disponibilidad y evitar solapamientos.
8. Guardar y recuperar datos desde SQL Server.
9. Mostrar mensajes claros ante datos inválidos y errores de operación.

**Definición de terminado:** los módulos incluidos se ejecutan; los datos persisten; las operaciones válidas e inválidas se comportan según los criterios; las pruebas tienen resultados reales registrados; y otro integrante puede preparar el entorno siguiendo las instrucciones.

## 6. Funciones fuera del MVP inicial

Se posponen las reservas públicas por web/móvil, recordatorios automáticos, pagos en línea, facturación fiscal electrónica, inventario, múltiples sucursales, dashboard avanzado, reportes comerciales complejos e integración con calendarios externos. Confirmar con el docente si alguno es obligatorio.

## 7. Correspondencia con la base de datos actual

El script SQL versionado define seis tablas:
- `CLIENTE`
- `PROFESIONAL`
- `SERVICIO`
- `CITA`
- `DETALLE_CITA`
- `FACTURA`

`DETALLE_CITA` permite asociar uno o varios servicios a una cita. `FACTURA` representa un registro interno de cobro y no una factura fiscal electrónica. La existencia de estas tablas en el script no demuestra que sus operaciones estén implementadas en la interfaz.

El equipo debe confirmar si la gestión interna de facturas forma parte del MVP visible o si queda preparada en el esquema para una etapa posterior.

## 8. Decisiones pendientes

- Confirmar el alcance con el docente y contrastarlo con la consigna/rúbrica.
- Confirmar si una cita admite varios servicios (el SQL actual sí lo permite).
- Confirmar si se implementará un módulo de factura interna en el MVP.
- Definir horarios laborales, pausas y días no laborables.
- Definir si los profesionales tendrán cuentas propias.
- Confirmar versiones exactas de SQL Server y herramientas.
