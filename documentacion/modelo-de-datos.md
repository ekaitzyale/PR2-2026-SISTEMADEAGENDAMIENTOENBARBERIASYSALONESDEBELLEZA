# Modelo de datos

**Base de datos:** SistemaAgendamiento  
**Motor:** Microsoft SQL Server  
**Esquema actual:** cuatro tablas.

## Entidades
| Tabla | Clave primaria | Propósito |
|---|---|---|
| CLIENTE | IdCliente | Datos de las personas que reservan |
| PROFESIONAL | IdProfesional | Datos de barberos y estilistas |
| SERVICIO | IdServicio | Catálogo de servicios, duración y precio |
| CITA | IdCita | Reserva de un cliente con un profesional |

## Campos principales
### CLIENTE
- IdCliente: INT, identidad y clave primaria.
- Nombre: NVARCHAR(100), obligatorio.
- Telefono: NVARCHAR(20), obligatorio.
- Email: NVARCHAR(120), opcional.

### PROFESIONAL
- IdProfesional: INT, identidad y clave primaria.
- Nombre: NVARCHAR(100), obligatorio.
- Especialidad: NVARCHAR(80), obligatoria.
- Activo: BIT, valor predeterminado 1.

### SERVICIO
- IdServicio: INT, identidad y clave primaria.
- Nombre: NVARCHAR(100), obligatorio.
- DuracionMinutos: INT, mayor que cero.
- Precio: DECIMAL(10,2), no negativo.
- Activo: BIT, valor predeterminado 1.

### CITA
- IdCita: INT, identidad y clave primaria.
- FechaHoraInicio y FechaHoraFin: DATETIME2, obligatorias.
- Estado: Programada, Atendida o Cancelada.
- IdCliente: clave foránea hacia CLIENTE.
- IdProfesional: clave foránea hacia PROFESIONAL.
- Observacion: NVARCHAR(250), opcional.

## Relaciones
- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- SERVICIO es un catálogo independiente en este esquema. Asignar uno o varios servicios a una cita requeriría ampliar el modelo; no se declara implementado.

## Integridad
- Las claves foráneas impiden citas con clientes o profesionales inexistentes.
- La fecha final debe ser posterior a la fecha inicial.
- El estado solo puede ser Programada, Atendida o Cancelada.
- La duración del servicio debe ser positiva y su precio no negativo.

## Regla de disponibilidad
Para un mismo profesional existe solapamiento cuando:
    inicioNuevo < finExistente AND finNuevo > inicioExistente

Las citas canceladas no bloquean el horario. La aplicación debe comprobar esta regla antes de guardar o modificar una cita.

## Inicialización
Ejecutar sistema/base-datos/01_Crear_Base_Datos.sql en SSMS. Para verificar:

    USE SistemaAgendamiento;
    SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo';