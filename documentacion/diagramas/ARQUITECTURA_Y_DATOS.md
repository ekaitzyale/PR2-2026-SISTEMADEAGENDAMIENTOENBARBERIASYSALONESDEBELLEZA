# Arquitectura técnica y modelo de datos

**Estado:** documentación alineada con el esquema actual de cuatro tablas del MVP.

## 1. Arquitectura

La aplicación es una solución de escritorio desarrollada con C# y Windows Forms sobre .NET Framework 4.8. La arquitectura separa tres responsabilidades:

1. **Presentación:** formularios Windows Forms para mostrar información y recibir datos.
2. **Lógica de negocio:** validaciones, reglas de agenda y disponibilidad.
3. **Acceso a datos:** clases ADO.NET para comunicarse con SQL Server.

Flujo general: formulario → lógica de negocio → acceso a datos → SQL Server.

## 2. Componentes

| Componente | Responsabilidad |
|---|---|
| Windows Forms | Interfaz y navegación |
| Lógica de negocio | Validaciones y reglas de agendamiento |
| ADO.NET | Conexión y ejecución de consultas parametrizadas |
| SQL Server | Persistencia de clientes, profesionales, servicios y citas |

La clase de conexión publicada se encuentra en sistema/codigo/SistemaAgendamiento/Datos/ConexionBD.cs y obtiene la cadena desde App.config. Cada integrante debe adaptar Data Source a su instancia local.

## 3. Modelo de datos actual

El esquema actual contiene exactamente cuatro tablas:

### CLIENTE
- IdCliente: clave primaria autoincremental.
- Nombre: obligatorio.
- Telefono: obligatorio.
- Email: opcional.

### PROFESIONAL
- IdProfesional: clave primaria autoincremental.
- Nombre y Especialidad: obligatorios.
- Activo: indica si está habilitado.

### SERVICIO
- IdServicio: clave primaria autoincremental.
- Nombre: obligatorio.
- DuracionMinutos: entero mayor que cero.
- Precio: decimal no negativo.
- Activo: indica si se ofrece actualmente.

### CITA
- IdCita: clave primaria autoincremental.
- FechaHoraInicio y FechaHoraFin: intervalo reservado.
- Estado: Programada, Atendida o Cancelada.
- IdCliente: clave foránea hacia CLIENTE.
- IdProfesional: clave foránea hacia PROFESIONAL.
- Observacion: opcional.

## 4. Relaciones

- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- SERVICIO se mantiene como catálogo independiente en este esquema. La asignación de servicios a citas requeriría ampliar el modelo y no se declara implementada.

## 5. Regla de solapamiento

Para un mismo profesional existe cruce de horarios cuando:

    inicioNuevo < finExistente AND finNuevo > inicioExistente

Las citas canceladas no deben bloquear el horario. Al editar una cita se excluye el registro que se está modificando. La validación debe ejecutarse en la lógica de negocio antes de guardar.

## 6. Límites del modelo

Esta versión documenta únicamente CLIENTE, PROFESIONAL, SERVICIO y CITA. No incluye DETALLE_CITA ni FACTURA. No se deben presentar esas funcionalidades como implementadas.

## 7. Inicialización y verificación

Ejecutar sistema/base-datos/01_Crear_Base_Datos.sql en SSMS. El script crea la base SistemaAgendamiento, las cuatro tablas y los índices. Después, verificar los nombres de las tablas y adaptar la cadena local en App.config.

## 8. Pruebas pendientes de evidenciar

- Conexión desde la aplicación a SQL Server.
- Inserción y consulta de registros.
- Validación de campos obligatorios.
- Relaciones de citas con clientes y profesionales.
- Rechazo de intervalos superpuestos.
- Manejo de errores de conexión.