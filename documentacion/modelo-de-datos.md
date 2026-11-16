# Modelo de datos

**Base de datos:** SistemaAgendamiento  
**Motor:** Microsoft SQL Server  
**Esquema vigente en el repositorio:** cuatro tablas.  
**Fuente:** `sistema/base-datos/01_Crear_Base_Datos.sql`.

## 1. Entidades

| Tabla | Clave primaria | Propósito |
|---|---|---|
| CLIENTE | IdCliente | Datos de las personas que reservan |
| PROFESIONAL | IdProfesional | Datos de barberos y estilistas |
| SERVICIO | IdServicio | Catálogo de servicios, duración y precio |
| CITA | IdCita | Reserva de un cliente con un profesional |

## 2. Campos principales

### CLIENTE
- `IdCliente`: INT, identidad y clave primaria.
- `Nombre`: NVARCHAR(100), obligatorio.
- `Telefono`: NVARCHAR(20), obligatorio.
- `Email`: NVARCHAR(120), opcional.

### PROFESIONAL
- `IdProfesional`: INT, identidad y clave primaria.
- `Nombre`: NVARCHAR(100), obligatorio.
- `Especialidad`: NVARCHAR(80), obligatoria.
- `Activo`: BIT, valor predeterminado 1.

### SERVICIO
- `IdServicio`: INT, identidad y clave primaria.
- `Nombre`: NVARCHAR(100), obligatorio.
- `DuracionMinutos`: INT, mayor que cero.
- `Precio`: DECIMAL(10,2), no negativo.
- `Activo`: BIT, valor predeterminado 1.

### CITA
- `IdCita`: INT, identidad y clave primaria.
- `FechaHoraInicio` y `FechaHoraFin`: DATETIME2, obligatorias.
- `Estado`: Programada, Atendida o Cancelada.
- `IdCliente`: clave foránea hacia CLIENTE.
- `IdProfesional`: clave foránea hacia PROFESIONAL.
- `Observacion`: NVARCHAR(250), opcional.

## 3. Relaciones existentes

- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- SERVICIO es un catálogo independiente en este esquema. No existe una clave foránea desde CITA hacia SERVICIO ni una tabla intermedia.

## 4. Decisión pendiente: servicio asociado a la cita

Los requisitos funcionales plantean seleccionar un servicio al registrar una cita, pero el esquema actual no permite persistir esa asociación.

El equipo debe decidir:
- **Un servicio por cita:** agregar una clave foránea `IdServicio` a CITA.
- **Varios servicios por cita:** crear una tabla intermedia, por ejemplo `CITA_SERVICIO`, con las claves y los datos históricos que el equipo acuerde.

Estas son alternativas para discusión, no cambios ya aplicados. No modificar el SQL hasta que el equipo acuerde la cardinalidad y actualice conjuntamente los requisitos, el modelo, el script y las pruebas.

## 5. Integridad

- Las claves foráneas actuales impiden citas con clientes o profesionales inexistentes.
- La fecha final debe ser posterior a la fecha inicial.
- El estado solo puede ser Programada, Atendida o Cancelada.
- La duración del servicio debe ser positiva y su precio no negativo.

## 6. Regla de disponibilidad

Para un mismo profesional existe solapamiento cuando:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

Las citas canceladas no bloquean el horario. La aplicación debe comprobar esta regla antes de guardar o modificar una cita.

## 7. Inicialización

Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SSMS. Para verificar las tablas:

```sql
USE SistemaAgendamiento;
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo';
```
