# Problema, objetivos, valor y validación

## 1. Problema

El documento inicial del equipo describe que algunas barberías y salones organizan citas mediante agendas físicas y mensajes. Esta forma de trabajo puede dificultar la consulta de disponibilidad, consumir tiempo del personal y provocar reservas superpuestas.

Esta descripción constituye el planteamiento del problema. Para demostrar su frecuencia y sus efectos se deben conservar evidencias de entrevistas u observaciones autorizadas.

## 2. Usuarios y necesidades

- **Propietarios/administradores:** organizar la agenda y consultar registros.
- **Barberos/estilistas:** conocer sus citas y evitar cruces.
- **Personal de recepción:** consultar disponibilidad, registrar, modificar y cancelar citas.
- **Clientes:** recibir una reserva clara y evitar esperas. En el MVP propuesto, la cita la registra el personal; no se incluye una aplicación pública para clientes.

## 3. Objetivo general

Desarrollar una aplicación de escritorio para gestionar clientes, profesionales, servicios y citas de barberías y salones de belleza, incorporando una validación de disponibilidad que impida registrar citas superpuestas para un mismo profesional.

## 4. Objetivos específicos

1. Diseñar una base de datos relacional para los datos de clientes, profesionales, servicios y citas.
2. Crear una interfaz de escritorio para registrar y consultar los datos principales.
3. Implementar modificación y cancelación de citas con validación.
4. Verificar la disponibilidad antes de guardar o modificar una cita.
5. Ejecutar y documentar pruebas funcionales.
6. Documentar la preparación del entorno, el uso del sistema y las decisiones técnicas.

## 5. Valor esperado

El valor esperado es organizar la agenda desde un lugar central y detectar un cruce antes de guardar una cita. Los beneficios comerciales —por ejemplo, reducir realmente las esperas o el tiempo administrativo— no deben presentarse como resultados demostrados hasta medirlos con usuarios.

## 6. Indicadores de éxito propuestos

| Indicador | Meta propuesta | Comprobación |
|---|---|---|
| Operaciones principales | Registro, consulta, modificación y cancelación funcionan | Casos de prueba y demostración |
| Prevención de solapamientos | Los casos definidos de cruce se rechazan | CP-06 y CP-10, más casos adicionales |
| Horario libre | Los casos válidos se guardan | CP-05 y CP-08 |
| Persistencia | Los datos guardados se recuperan de SQL Server | CP-11 |
| Manejo de errores | Datos inválidos se rechazan con mensajes comprensibles | CP-02, CP-04, CP-12 y CP-14 |
| Reproducibilidad | Otro integrante prepara el entorno siguiendo instrucciones | Revisión cruzada |

Son metas de aceptación del software; no demuestran por sí solas impacto comercial en un negocio real.

## 7. Validación del problema — evidencia por completar

El cuestionario de madurez afirma que se realizó una observación inicial de negocios del rubro. Sin embargo, el repositorio no contiene un registro verificable con fechas, método, cantidad de participantes/negocios y resultados resumidos. Por ello, la validación debe completarse documentalmente antes de presentar esa afirmación como evidencia comprobada.

Pasos:
1. Identificar al menos dos personas que trabajen o administren una barbería o salón, con autorización.
2. Preguntar cómo registran citas, qué errores ocurren y qué información necesitan consultar.
3. Anotar fecha, perfil general y respuestas resumidas, sin nombres ni teléfonos personales.
4. Comparar las respuestas con las funciones del MVP.
5. Guardar un resumen anonimizado en el repositorio.

Preguntas sugeridas:
- ¿Cómo registran y consultan las citas actualmente?
- ¿Qué ocurre cuando dos clientes piden el mismo horario?
- ¿Qué datos necesitan al registrar una cita?
- ¿Qué cambios o cancelaciones son frecuentes?
- ¿Qué sería lo más útil que hiciera un sistema de agenda?

**Estado:** pendiente de documentar con evidencia primaria.
