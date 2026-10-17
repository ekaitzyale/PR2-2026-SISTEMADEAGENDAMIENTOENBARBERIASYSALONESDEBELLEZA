# Requisitos del sistema y criterios de aceptación

**Estado:** propuesta inicial para revisión del equipo y confirmación con el docente.  
**Tecnologías previstas:** C#, Windows Forms, SQL Server y ADO.NET.

## 1. Propósito y usuarios

El sistema de escritorio ayudará al personal de una barbería o salón a organizar clientes, profesionales, servicios y citas. En el MVP propuesto, el personal registra las citas; no se incluye una aplicación pública web o móvil.

- **Administrador/personal:** mantiene registros y gestiona citas.
- **Profesional:** necesita consultar sus citas; el acceso por cuenta propia queda por confirmar.
- **Cliente:** recibe la atención y la reserva a través del personal.

## 2. Requisitos funcionales

| ID | Requisito | Comportamiento esperado |
|---|---|---|
| RF-01 | Registrar cliente | Guardar nombre y teléfono; correo opcional si se confirma. |
| RF-02 | Consultar/buscar cliente | Mostrar clientes y permitir buscar por nombre o teléfono. |
| RF-03 | Modificar cliente | Actualizar datos de un cliente existente. |
| RF-04 | Registrar profesional | Guardar los datos mínimos para identificar a cada profesional. |
| RF-05 | Consultar profesional | Mostrar profesionales disponibles para citas. |
| RF-06 | Registrar servicio | Guardar nombre, duración estimada y precio. |
| RF-07 | Consultar servicio | Mostrar servicios activos con duración y precio. |
| RF-08 | Registrar cita | Seleccionar cliente, servicio, profesional, fecha y hora de inicio. |
| RF-09 | Consultar agenda | Mostrar citas por fecha y profesional, con hora y estado. |
| RF-10 | Evitar solapamientos | Rechazar una cita que se cruce con otra cita activa del mismo profesional. |
| RF-11 | Modificar cita | Volver a validar disponibilidad antes de guardar los cambios. |
| RF-12 | Cancelar cita | Cambiar estado a cancelada y conservar el registro para consulta. |
| RF-13 | Validar entradas | Rechazar datos obligatorios vacíos, fechas inválidas y valores fuera de regla. |
| RF-14 | Persistir datos | Guardar y recuperar información en SQL Server mediante consultas parametrizadas. |

## 3. Regla de disponibilidad

Cada cita tiene un inicio y un fin. El fin se calcula sumando la duración acordada del servicio a la hora de inicio. Hay solapamiento si:

**inicioNuevo < finExistente** y **finNuevo > inicioExistente**

La regla se aplica a citas no canceladas del mismo profesional. Al modificar, la cita actual debe excluirse de la comparación. Los horarios laborales, pausas, servicios múltiples y tratamiento de citas fuera de horario deben acordarse antes de programar.

Ejemplo: una cita de 10:00 a 10:30 se cruza con otra de 10:20 a 10:50; la segunda debe rechazarse. Una cita de 10:30 a 11:00 no se cruza por tiempo si se permite que sean consecutivas.

## 4. Criterios de aceptación verificables

| ID | Criterio |
|---|---|
| CA-01 | Un cliente válido se guarda y aparece al volver a consultar. |
| CA-02 | Un cliente sin campo obligatorio no se guarda y recibe un mensaje claro. |
| CA-03 | Un servicio requiere nombre, duración positiva y precio no negativo. |
| CA-04 | Una cita válida se guarda y aparece en la agenda. |
| CA-05 | Una cita que se cruza con otra activa del mismo profesional se rechaza y no se guarda. |
| CA-06 | Una cita en horario libre puede guardarse si los demás datos son válidos. |
| CA-07 | Una coincidencia de hora con otro profesional no debe bloquearse solo por esa coincidencia. |
| CA-08 | Una cita cancelada deja de bloquear el horario según la regla acordada. |
| CA-09 | Al modificar una cita, se vuelve a comprobar la disponibilidad. |
| CA-10 | Al cancelar, el estado cambia y el registro permanece consultable. |
| CA-11 | Un error de conexión se informa sin cerrar inesperadamente la aplicación ni mostrar credenciales. |
| CA-12 | Las consultas usan parámetros y no concatenan directamente entradas del usuario en SQL. |

## 5. Requisitos no funcionales

- **Usabilidad:** formularios consistentes, etiquetas claras y mensajes que indiquen cómo corregir errores.
- **Integridad:** claves primarias/foráneas y reglas de validación.
- **Seguridad:** no publicar credenciales; restringir acceso si se implementan cuentas; usar consultas parametrizadas.
- **Privacidad:** recopilar solo datos necesarios y usar datos ficticios en pruebas.
- **Compatibilidad:** documentar las versiones acordadas de Windows, .NET y SQL Server.
- **Mantenibilidad:** separar interfaz, lógica de negocio y acceso a datos.
- **Confiabilidad:** confirmar éxito solo si la operación se guardó correctamente.

## 6. Fuera del MVP propuesto

Reservas públicas por web/móvil, notificaciones automáticas, pagos en línea, facturación fiscal, inventario, múltiples sucursales y dashboard avanzado. Confirmar con el docente que estos elementos no son obligatorios.

## 7. Trazabilidad

Problema: desorganización y riesgo de citas duplicadas.  
Objetivo: centralizar agenda y prevenir solapamientos.  
Requisitos centrales: RF-08 a RF-12.  
Pruebas relacionadas: archivo PLAN_DE_PRUEBAS.md en la carpeta pruebas/casos-prueba.
