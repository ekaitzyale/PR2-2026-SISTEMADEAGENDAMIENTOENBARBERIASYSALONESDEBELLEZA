# Arquitectura técnica y modelo de datos

**Estado:** modelo inicial propuesto para el MVP, alineado con las seis entidades incluidas en la presentación del equipo. Debe revisarse con el docente y mantenerse sincronizado con el script SQL.

## 1. Arquitectura

La aplicación se organiza en tres partes:

1. **Presentación:** formularios Windows Forms para registrar datos, consultar agenda y mostrar mensajes.
2. **Lógica de negocio:** validaciones, reglas de citas, cálculo de duración y disponibilidad.
3. **Acceso a datos:** clases ADO.NET que ejecutan consultas parametrizadas contra SQL Server.

Flujo: Formulario → lógica de negocio → acceso a datos (ADO.NET) → SQL Server.

Los formularios no deben concentrar toda la lógica ni construir consultas SQL concatenando texto ingresado por el usuario.

## 2. Entidades del modelo

### CLIENTE
- `IdCliente`: clave primaria.
- `Nombre`: obligatorio.
- `Telefono`: obligatorio.
- `Email`: opcional.

### PROFESIONAL
- `IdProfesional`: clave primaria.
- `Nombre`: obligatorio.
- `Especialidad`: obligatorio.
- `Activo`: permite desactivar sin borrar el historial.

### SERVICIO
- `IdServicio`: clave primaria.
- `Nombre`: obligatorio.
- `DuracionMinutos`: entero mayor que cero.
- `Precio`: decimal no negativo.
- `Activo`: permite desactivar servicios sin borrar su historial.

### CITA
- `IdCita`: clave primaria.
- `FechaHoraInicio` y `FechaHoraFin`: intervalo reservado.
- `Estado`: Programada, Atendida o Cancelada.
- `IdCliente`: clave foránea.
- `IdProfesional`: clave foránea.
- `Observacion`: opcional.

### DETALLE_CITA
- `IdDetalle`: clave primaria.
- `IdCita`: clave foránea.
- `IdServicio`: clave foránea.
- `Precio`: precio histórico del servicio al reservar.
- `DuracionMinutos`: duración histórica del servicio al reservar.

Una cita puede contener uno o varios servicios. La duración total se obtiene sumando las duraciones de sus detalles. La hora final de la cita debe corresponder a esa duración total.

### FACTURA
- `IdFactura`: clave primaria.
- `IdCita`: clave foránea y único, para permitir como máximo una factura por cita.
- `FechaEmision`: fecha y hora de emisión.
- `Total`: importe no negativo.
- `Estado`: Pendiente, Pagada o Anulada.

La factura del MVP es un registro interno de cobro; no equivale a facturación fiscal electrónica.

## 3. Relaciones

- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- CITA 1:N DETALLE_CITA.
- SERVICIO 1:N DETALLE_CITA.
- CITA 1:0..1 FACTURA.

## 4. Regla de solapamiento

Para una cita nueva se obtiene el inicio y el fin. Existe solapamiento cuando, para una cita no cancelada del mismo profesional:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

Se excluye la cita actual cuando se modifica. Las citas canceladas no bloquean el horario. La comprobación debe ejecutarse en la lógica de negocio antes de guardar; para evitar carreras entre reservas simultáneas se debe ejecutar la comprobación y escritura dentro de una transacción adecuada.

## 5. Decisiones que debe confirmar el equipo

- Si el docente exige factura o solo un registro interno de pago.
- Si se permitirán varios servicios por cita (este modelo lo permite).
- Horarios laborales, pausas y días no laborables.
- Si los profesionales tendrán cuentas propias.
- Versiones exactas de .NET Framework y SQL Server.

## 6. Prueba técnica inicial

1. Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SQL Server.
2. Confirmar que aparecen las seis tablas.
3. Insertar datos ficticios para probar relaciones.
4. Conectar la aplicación mediante ADO.NET.
5. Registrar y consultar un dato usando parámetros.
6. Probar un error controlado de conexión.
7. Guardar capturas y registrar resultados en `pruebas/evidencias`.

No marcar la conexión o las pruebas como realizadas hasta ejecutarlas.
