# Plan inicial de pruebas

**Estado:** casos diseñados; no deben considerarse ejecutados hasta probar la aplicación real.  
**Datos de prueba:** usar registros ficticios.

## 1. Objetivo

Comprobar que las funciones principales cumplen los requisitos, que los datos se guardan correctamente y que no se permiten citas superpuestas del mismo profesional.

## 2. Estrategia

- **Funcionales:** registrar, consultar, modificar y cancelar.
- **Validación:** campos vacíos, duración inválida, precio negativo y fecha/hora incorrecta.
- **Reglas de negocio:** horario libre, solapamiento, cita cancelada y profesional distinto.
- **Persistencia:** comprobar que los datos se conservan en SQL Server.
- **Integración:** formularios, lógica de negocio y base de datos funcionando juntos.
- **Regresión:** repetir pruebas importantes después de corregir errores.

## 3. Casos de prueba

| ID | Caso | Acción/condición | Resultado esperado | Estado inicial |
|---|---|---|---|---|
| CP-01 | Cliente válido | Guardar nombre y teléfono ficticios válidos | Se guarda y aparece en la lista | Pendiente |
| CP-02 | Cliente sin nombre | Dejar el nombre vacío y guardar | No se guarda; mensaje claro | Pendiente |
| CP-03 | Servicio válido | Guardar nombre, duración positiva y precio válido | Se guarda | Pendiente |
| CP-04 | Duración inválida | Intentar guardar duración cero o negativa | Se rechaza | Pendiente |
| CP-05 | Horario libre | Crear cita sin otra que se cruce para el profesional | Se guarda y aparece en agenda | Pendiente |
| CP-06 | Solapamiento parcial | Existente 10:00–10:30; nueva 10:20–10:50, mismo profesional | Se rechaza la nueva cita | Pendiente |
| CP-07 | Otro profesional | Mismo intervalo, pero profesional distinto | Se acepta si los demás datos son válidos | Pendiente |
| CP-08 | Citas consecutivas | Existente 10:00–10:30; nueva 10:30–11:00 | Se acepta si no hay otra restricción | Pendiente |
| CP-09 | Cita cancelada | Cancelar cita y reservar su intervalo | Cancelada no bloquea, según regla acordada | Pendiente |
| CP-10 | Modificación a ocupado | Cambiar una cita a intervalo que se cruza con otra | Cambio rechazado; datos anteriores conservados | Pendiente |
| CP-11 | Persistencia | Guardar cita y consultar nuevamente | La cita sigue registrada | Pendiente |
| CP-12 | Error de conexión | Deshabilitar la base de prueba de forma controlada | Mensaje de error sin cierre inesperado | Pendiente |
| CP-13 | Entrada con caracteres especiales | Introducir texto especial en búsqueda/entrada | Se trata como dato; no ejecuta SQL arbitrario | Pendiente |
| CP-14 | Cita incompleta | Omitir cliente, profesional, servicio, fecha u hora | No se guarda; indica qué falta | Pendiente |

## 4. Registro de ejecución

Para cada prueba completar: fecha, commit/versión probada, persona responsable, resultado observado, estado (aprobado/fallido/bloqueado), evidencia y número de incidencia si existe.

No marcar una prueba como aprobada solo por leer el requisito; debe ejecutarse contra la aplicación.

## 5. Evidencias

Guardar capturas en la carpeta pruebas/evidencias, con nombres como CP-06-solapamiento.png. Acompañar cada captura con una breve explicación. No incluir credenciales ni información real de clientes.
