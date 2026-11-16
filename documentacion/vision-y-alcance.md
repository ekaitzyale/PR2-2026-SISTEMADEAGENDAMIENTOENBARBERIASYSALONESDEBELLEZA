# Visión y alcance del producto

## Visión
Ofrecer a barberías y salones de belleza una herramienta de escritorio sencilla para organizar clientes, profesionales, servicios y citas, reduciendo errores de agenda.

## Problema
La coordinación manual de reservas puede causar citas duplicadas, confusión sobre la disponibilidad del personal y dificultad para mantener datos actualizados.

## Objetivo general
Desarrollar un sistema de escritorio que centralice los datos principales del establecimiento y facilite la administración de citas.

## Usuarios
- Administrador o recepción: administra registros y agenda.
- Profesional: consulta sus citas asignadas.
- Cliente: solicita una reserva mediante el establecimiento.

## Alcance actual
El esquema de datos acordado comprende cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA. La aplicación se desarrolla con C#, Windows Forms, .NET Framework 4.8, ADO.NET y SQL Server. El alcance funcional previsto comprende mantenimiento de clientes, profesionales y servicios, registro y consulta de citas y validación de disponibilidad.

## Fuera del alcance actual
No se consideran implementadas reservas web o móviles, notificaciones automáticas, pagos en línea, facturación fiscal, inventario ni múltiples sucursales. Tampoco se incluyen tablas de detalle de cita o factura en el esquema actual.

## Criterio de evolución
Las funciones se marcarán como terminadas solo cuando estén implementadas, probadas y reflejadas en el repositorio. Las propuestas futuras deben identificarse como pendientes.