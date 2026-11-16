# Visión y alcance del producto

## Visión
Ofrecer a barberías y salones de belleza una herramienta de escritorio sencilla para organizar clientes, profesionales, servicios y citas, reduciendo errores de agenda.

## Problema
La coordinación manual de reservas puede causar citas duplicadas, confusión sobre la disponibilidad del personal y dificultad para mantener datos actualizados. Esta es la problemática descrita en el documento inicial del equipo; su validación con usuarios debe quedar respaldada mediante entrevistas u observaciones documentadas.

## Objetivo general
Desarrollar un sistema de escritorio que centralice los datos principales del establecimiento y facilite la administración de citas.

## Usuarios
- Administrador o recepción: administra registros y agenda.
- Profesional: consulta sus citas asignadas.
- Cliente: solicita una reserva mediante el establecimiento.

## Alcance actual
El esquema SQL versionado comprende cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA. La aplicación se desarrolla con C#, Windows Forms, .NET Framework 4.8, ADO.NET y SQL Server. El alcance funcional previsto comprende mantenimiento de clientes, profesionales y servicios, registro y consulta de citas y validación de disponibilidad.

**Decisión pendiente:** el esquema actual no relaciona SERVICIO con CITA. Si el sistema debe guardar el servicio seleccionado en cada reserva, se debe definir y aprobar cómo representar esa relación antes de implementar esa parte.

## Fuera del alcance inicial
No se consideran incluidas en el MVP las reservas web o móviles, notificaciones automáticas, pagos en línea, facturación fiscal, inventario ni múltiples sucursales. Dashboard avanzado y reportes complejos se consideran mejoras posteriores, salvo indicación distinta del docente.

## Criterio de evolución
Las funciones se marcarán como terminadas solo cuando estén implementadas, probadas y reflejadas en el repositorio. Las propuestas futuras deben identificarse como pendientes.
