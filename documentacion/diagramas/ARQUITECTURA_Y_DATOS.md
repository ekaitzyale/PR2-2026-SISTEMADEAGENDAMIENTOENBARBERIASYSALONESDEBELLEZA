# Arquitectura técnica y modelo de datos

**Estado:** arquitectura objetivo propuesta y modelo relacional contrastado con el script SQL vigente. La arquitectura completa todavía no está implementada.

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

En el código revisado todavía no aparecen los formularios CRUD, clases de lógica de negocio ni consultas de persistencia para los módulos. Por tanto, las tres capas describen la arquitectura objetivo, no el estado terminado.

## 3. Modelo de datos del script SQL vigente

El esquema actual contiene exactamente cuatro tablas.

### CLIENTE
- `IdCliente`: clave primaria autoincremental.
- `Nombre`: obligatorio.
- `Telefono`: obligatorio.
- `Email`: opcional.

### PROFESIONAL
- `IdProfesional`: clave primaria autoincremental.
- `Nombre`: obligatorio.
- `Especialidad`: obligatoria.
- `Activo`: valor predeterminado 1.

### SERVICIO
- `IdServicio`: clave primaria autoincremental.
- `Nombre`: obligatorio.
- `DuracionMinutos`: entero mayor que cero.
- `Precio`: decimal no negativo.
- `Activo`: valor predeterminado 1.

### CITA
- `IdCita`: clave primaria autoincremental.
- `FechaHoraInicio` y `FechaHoraFin`: intervalo reservado.
- `Estado`: Programada, Atendida o Cancelada.
- `IdCliente`: clave foránea hacia CLIENTE.
- `IdProfesional`: clave foránea hacia PROFESIONAL.
- `Observacion`: opcional.

## 4. Relaciones existentes

- CLIENTE 1:N CITA.
- PROFESIONAL 1:N CITA.
- SERVICIO no tiene relación con CITA en el esquema actual; es un catálogo independiente.

**Brecha de diseño que debe resolverse:** los requisitos plantean seleccionar un servicio al registrar una cita, pero el esquema actual no permite guardar esa asociación. Si una cita solo admite un servicio, podría incorporarse una clave foránea a CITA; si admite varios, se necesitaría una tabla intermedia (por ejemplo, CITA_SERVICIO). Esta es una propuesta técnica para decisión del equipo, no una modificación ya realizada.

El script actual no contiene DETALLE_CITA, FACTURA, SUCURSAL, TRABAJADOR, PRODUCTO ni otras tablas de modelos conceptuales anteriores. No describirlas como tablas implementadas.

## 5. Regla de solapamiento

Para un mismo profesional existe cruce de horarios cuando:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

Las citas canceladas no deben bloquear el horario. Al editar una cita se excluye el registro que se está modificando. La validación debe ejecutarse en la lógica de negocio antes de guardar.

## 6. Integridad y rendimiento

El script establece claves primarias y foráneas entre CITA, CLIENTE y PROFESIONAL; exige que la fecha final sea posterior a la inicial; limita el estado de la cita a Programada, Atendida o Cancelada; y define restricciones de duración y precio en SERVICIO. También crea índices para consultas de agenda por profesional/fecha y por cliente/fecha.

## 7. Inicialización y verificación

1. Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SQL Server Management Studio.
2. Confirmar la creación de las cuatro tablas.
3. Ajustar `Data Source` en `App.config` a la instancia local.
4. Probar conexión, lectura y escritura desde la versión actual de la aplicación.
5. Registrar resultados y capturas en `pruebas/evidencias`.

La guía del cuestionario conserva capturas aportadas por el equipo sobre una prueba anterior de conexión. El menú actual no muestra el botón “Probar” de la captura; se debe repetir la comprobación sobre la versión vigente.
