# Arquitectura técnica

**Estado:** arquitectura objetivo propuesta. La implementación actual es inicial y todavía no completa las tres capas.

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

## 3. Componentes existentes en el código

- `Program.cs`: configura los estilos visuales e inicia `Forms.FrmMenu`.
- `Forms/FrmMenu.cs`: menú inicial con botones para Clientes, Profesionales, Servicios y Citas; los botones están deshabilitados.
- `Datos/ConexionBD.cs`: obtiene una conexión desde `App.config` y contiene un método `ProbarConexion()`.
- `App.config`: cadena de conexión de ejemplo/local, que cada integrante debe adaptar a su instancia.

En el código revisado todavía no aparecen los formularios CRUD, clases de lógica de negocio ni consultas de persistencia para los módulos. Por tanto, las tres capas describen la arquitectura objetivo, no el estado terminado.

## 4. Modelo de datos

El modelo relacional detallado y las relaciones implementadas se mantienen en [modelo-de-datos.md](../modelo-de-datos.md). El script SQL vigente contiene cuatro tablas: CLIENTE, PROFESIONAL, SERVICIO y CITA.

**Brecha pendiente:** SERVICIO no está relacionado con CITA en el esquema actual. Resolver esta decisión antes de implementar la selección y persistencia del servicio en una reserva.

## 5. Regla de solapamiento

Para un mismo profesional existe cruce de horarios cuando:

`inicioNuevo < finExistente AND finNuevo > inicioExistente`

Las citas canceladas no deben bloquear el horario. Al editar una cita se excluye el registro que se está modificando. La validación debe ejecutarse en la lógica de negocio antes de guardar.

## 6. Prueba técnica y verificación

1. Ejecutar `sistema/base-datos/01_Crear_Base_Datos.sql` en SQL Server Management Studio.
2. Confirmar la creación de las cuatro tablas.
3. Ajustar `Data Source` en `App.config` a la instancia local.
4. Probar conexión, lectura y escritura desde la versión actual de la aplicación.
5. Registrar resultados y capturas en `pruebas/evidencias`.

La guía del cuestionario conserva capturas aportadas por el equipo sobre una prueba anterior de conexión. El menú actual no muestra el botón “Probar” de la captura; se debe repetir la comprobación sobre la versión vigente.
