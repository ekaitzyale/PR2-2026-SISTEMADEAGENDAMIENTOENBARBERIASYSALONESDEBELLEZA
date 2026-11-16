# Arquitectura técnica y modelo de datos

**Estado:** arquitectura objetivo propuesta y modelo relacional contrastado con el script SQL versionado. La arquitectura completa todavía no está implementada.

## 1. Tecnologías

- C# y Windows Forms.
- .NET Framework 4.8.
- SQL Server.
- ADO.NET mediante `System.Data.SqlClient`.
- Visual Studio 2022.

## 2. Arquitectura objetivo

La separación prevista es:

1. **Presentación:** formularios Windows Forms para capturar datos y mostrar resultados.
2. **Lógica de negocio:** validaciones, reglas de citas, cálculo de duración y disponibilidad.
3. **Acceso a datos:** clases ADO.NET que ejecutan consultas parametrizadas contra SQL Server.

Flujo objetivo: Formulario → lógica de negocio → acceso a datos → SQL Server.

Los formularios no deberían concentrar las reglas de negocio ni construir consultas SQL concatenando entradas del usuario.

### Componentes que existen actualmente

- `Program.cs`: configura los estilos visuales e inicia `Forms.FrmMenu`.
- `Forms/FrmMenu.cs`: menú inicial con botones para Clientes, Profesionales, Servicios y Citas; los botones están deshabilitados.
- `Datos/ConexionBD.cs`: obtiene una conexión desde `App.config` y contiene un método `ProbarConexion()`.
- `App.config`: cadena de conexión de ejemplo/local, que cada integrante debe adaptar a su instancia.
- `WindowsForms.cs`: archivo de comentarios de contexto; no implementa un formulario ni una funcionalidad.

En el código revisado todavía no aparecen los formularios CRUD, clases de lógica de negocio ni consultas de persistencia para los módulos. Por tanto, las tres capas describen la arquitectura objetivo, no el estado terminado.

## 3. Modelo de datos del script SQL

### CLIENTE
- `IdCliente`: clave primaria.
- `Nombre`: obligatorio.
- `Telefono`: obligatorio.
- `Email`: opcional.

### PROFESIONAL
- `IdProfesional`: clave primaria.
- `Nombre`: obligatorio.
- `Especialidad`: obligatorio.
- `Activo`: permite desactivar al profesional sin borrar su historial.

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
- `Precio`: precio histórico aplicado al reservar.
- `DuracionMinutos`: duración histórica del servicio.

Una cita puede incluir uno o varios servicios. La duración total se obtiene sumando las duraciones de sus detalles.

### FACTURA
- `IdFactura`: clave primaria.
- `IdCita`: clave foránea y única, para permitir como máximo una factura por cita.
- `FechaEmision`: fecha y hora de emisión.
- `Total`: importe no negativo.
- `Estado`: Pendiente, Pagada o Anulada.

Esta tabla representa un registro interno de cobro; no equivale a facturación fiscal electrónica.

## 4. Relaciones

- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- CITA 1:N DETALLE_CITA.
- SERVICIO 1:N DETALLE_CITA.
- CITA 1:0..1 FACTURA.

El script actual no contiene las tablas SUCURSAL, TRABAJADOR, ADMINISTRATIVO, BARBERO, ESTILISTA, PRODUCTO ni FACTURA_DETALLE que aparecen en partes del modelo conceptual del documento inicial. No describirlas como tablas implementadas sin modificar primero y aprobar el esquema SQL.

## 5. Regla de solapamiento

Existe solapamiento cuando, para una cita no cancelada del mismo profesional:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

Al modificar, se excluye la cita actual. Las citas canceladas no bloquean el horario según la regla propuesta. La comprobación debe ejecutarse en la lógica de negocio antes de guardar; para evitar reservas simultáneas incompatibles, la comprobación y escritura deben coordinarse mediante una transacción adecuada.

## 6. Prueba técnica y verificación

1. Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SQL Server.
2. Confirmar que se crean las seis tablas esperadas.
3. Insertar datos ficticios y comprobar las relaciones.
4. Ajustar `App.config` a la instancia local.
5. Ejecutar `ConexionBD.ProbarConexion()` desde una prueba o interfaz habilitada.
6. Probar lectura y escritura con consultas parametrizadas.
7. Registrar resultados y capturas en `pruebas/evidencias`.

La guía del cuestionario contiene capturas que el equipo presentó como evidencia de una prueba anterior. Se debe repetir la prueba en la versión actual y actualizar la captura de SQL, ya que la evidencia existente muestra cuatro tablas y el script versionado define seis.
