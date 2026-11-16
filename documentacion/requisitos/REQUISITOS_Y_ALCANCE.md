# Requisitos del sistema y alcance del MVP

**Proyecto:** Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza  
**Equipo:** Virus  
**Estado:** requisitos propuestos para el MVP; deben mantenerse sincronizados con el código, el script SQL y la consigna/rúbrica del docente.

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
| RF-08 | Registrar cita | Seleccionar cliente, profesional, fecha y hora; asociar el servicio seleccionado cuando el modelo de datos permita persistir esa relación. |
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
| CA-13 | El servicio elegido queda asociado a la cita y se recupera correctamente; este criterio requiere resolver primero el vínculo SERVICIO–CITA en el modelo SQL. |

## 4. Regla de disponibilidad

Cada cita reserva un intervalo de inicio y fin. Para una nueva cita existe solapamiento si:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

La comparación se realiza para el mismo profesional y citas no canceladas. Al modificar una cita, se excluye su propio identificador. Dos citas consecutivas (por ejemplo, 10:00–10:30 y 10:30–11:00) no se solapan con esta regla.

El script SQL guarda `FechaHoraInicio` y `FechaHoraFin` en CITA. La duración del servicio debe determinar el fin, pero el servicio no está relacionado actualmente con CITA; resolver esta relación es una dependencia para completar RF-08.

## 5. Alcance del MVP

La primera versión propuesta contempla:
1. Registrar, consultar y modificar clientes.
2. Registrar y consultar profesionales.
3. Registrar y consultar servicios con duración y precio.
4. Registrar y consultar citas.
5. Consultar la agenda por fecha y profesional.
6. Modificar y cancelar citas.
7. Validar disponibilidad y evitar solapamientos.
8. Guardar y recuperar datos desde SQL Server.
9. Mostrar mensajes claros ante datos inválidos y errores de operación.

La asociación del servicio a una cita queda condicionada a la decisión y actualización del modelo de datos. No declarar esta parte terminada hasta que el script, el código y las pruebas la soporten.

**Definición de terminado:** los módulos incluidos se ejecutan; los datos persisten; las operaciones válidas e inválidas se comportan según los criterios; las pruebas tienen resultados reales registrados; y otro integrante puede preparar el entorno siguiendo las instrucciones.

## 6. Funciones fuera del MVP inicial

Se posponen las reservas públicas por web/móvil, recordatorios automáticos, pagos en línea, facturación fiscal electrónica, inventario, múltiples sucursales, dashboard avanzado, reportes comerciales complejos e integración con calendarios externos. Confirmar con el docente si alguno es obligatorio.

## 7. Correspondencia con la base de datos actual

El script SQL versionado define cuatro tablas:
- `CLIENTE`
- `PROFESIONAL`
- `SERVICIO`
- `CITA`

Relaciones existentes:
- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.

SERVICIO funciona actualmente como catálogo independiente. No hay una clave foránea ni una tabla intermedia que conecte SERVICIO con CITA. El equipo debe decidir si una cita tendrá un único servicio o varios y actualizar el modelo/SQL en consecuencia, con aprobación del equipo y del docente cuando corresponda.

## 8. Decisiones pendientes

- Confirmar el alcance con el docente y contrastarlo con la consigna/rúbrica.
- Definir cómo se relaciona SERVICIO con CITA.
- Definir horarios laborales, pausas y días no laborables.
- Definir si los profesionales tendrán cuentas propias.
- Confirmar versiones exactas de SQL Server y herramientas.
