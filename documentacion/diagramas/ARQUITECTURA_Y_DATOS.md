# Arquitectura técnica inicial y modelo de datos

**Estado:** diseño conceptual. Debe compararse con el diagrama relacional del documento inicial antes de crear tablas definitivas.

## 1. Arquitectura propuesta

1. **Presentación:** formularios Windows Forms para ingresar datos, consultar agenda y mostrar mensajes.
2. **Lógica de negocio:** validaciones, reglas de citas, cálculo de hora final y comprobación de disponibilidad.
3. **Acceso a datos:** ADO.NET, consultas parametrizadas y operaciones CRUD sobre SQL Server.

Flujo: Formulario → lógica de negocio → acceso a datos (ADO.NET) → SQL Server.

Los formularios no deben concentrar toda la lógica de negocio ni construir consultas SQL concatenando texto ingresado por el usuario.

## 2. Entidades mínimas propuestas para el MVP

### CLIENTE
- IdCliente — clave primaria.
- Nombre.
- Telefono.
- Correo — opcional, si se confirma.

### PROFESIONAL
- IdProfesional — clave primaria.
- Nombre.
- Especialidad o tipo de profesional, según acuerdo.
- Activo — opcional si se necesita desactivar sin borrar historial.

### SERVICIO
- IdServicio — clave primaria.
- Nombre.
- DuracionMinutos.
- Precio.
- Activo — opcional.

### CITA
- IdCita — clave primaria.
- IdCliente — clave foránea.
- IdProfesional — clave foránea.
- IdServicio — clave foránea en la versión mínima de un servicio por cita.
- FechaHoraInicio.
- FechaHoraFin o duración calculada de forma consistente.
- Estado: por ejemplo, programada, atendida o cancelada.

Si se acuerda que una cita puede incluir varios servicios, se debe incorporar una tabla de detalle y calcular la duración total. Esta decisión no debe quedar implícita.

## 3. Relaciones iniciales

- Un cliente puede tener muchas citas: CLIENTE 1:N CITA.
- Un profesional puede atender muchas citas: PROFESIONAL 1:N CITA.
- Un servicio puede aparecer en muchas citas: SERVICIO 1:N CITA en la versión mínima.

El modelo inicial del documento del equipo contempla otras entidades: categorías, trabajadores, administrativos, barberos, estilistas, sucursales, detalles, productos y facturas. No deben eliminarse automáticamente; el equipo debe decidir si son obligatorias. Para el MVP se recomienda no desarrollar tablas que no se utilizarán.

## 4. Regla de solapamiento

Para una cita nueva se obtiene el inicio y el fin. Existe solapamiento si, para una cita activa del mismo profesional:

**inicioNuevo < finExistente** y **finNuevo > inicioExistente**

Se excluyen citas canceladas y, al modificar, se excluye el identificador de la cita actual. Debe considerarse la consistencia si dos usuarios intentan guardar reservas casi simultáneamente.

## 5. Decisiones técnicas pendientes

- Versión de .NET y SQL Server.
- Nombre de la base de datos y configuración de conexión.
- Uno o varios servicios por cita.
- Almacenar o calcular el fin de la cita.
- Horarios laborales, pausas y estados.
- Cuentas y roles de usuario en el MVP.
- Si el modelo ampliado del documento inicial es obligatorio.

## 6. Prueba técnica temprana

Antes de construir todos los formularios:
1. Crear una base de datos de prueba sin datos reales.
2. Conectar una aplicación de prueba mediante ADO.NET.
3. Insertar y consultar un registro con parámetros.
4. Probar un error controlado de conexión.
5. Guardar resultado, versiones utilizadas y evidencia.

No marcar esta validación como realizada hasta que se ejecute.
