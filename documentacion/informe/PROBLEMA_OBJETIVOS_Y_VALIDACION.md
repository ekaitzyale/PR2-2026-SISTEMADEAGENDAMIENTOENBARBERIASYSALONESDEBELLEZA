# Problema, objetivos, valor y validación

## 1. Problema

El documento inicial del equipo describe que algunas barberías y salones organizan citas mediante agendas físicas y mensajes, lo que puede dificultar consultar disponibilidad, consumir tiempo del personal y provocar reservas superpuestas.

Esta es la hipótesis inicial del proyecto. Para demostrar que representa necesidades reales, el equipo debe recoger evidencia mediante entrevistas u observación autorizada y registrar resultados.

## 2. Usuarios y necesidades

- **Propietarios/administradores:** organizar agenda y consultar registros.
- **Barberos/estilistas:** conocer sus citas y evitar cruces.
- **Personal que registra citas:** consultar disponibilidad, registrar, modificar y cancelar.
- **Clientes:** recibir una reserva clara y evitar esperas. En el MVP propuesto, la cita la registra el personal; no hay aplicación pública para clientes.

## 3. Objetivo general propuesto

Desarrollar una aplicación de escritorio para gestionar clientes, profesionales, servicios y citas de barberías y salones de belleza, incorporando una validación de disponibilidad que impida registrar citas superpuestas para un mismo profesional.

## 4. Objetivos específicos

1. Diseñar una base de datos relacional para los datos mínimos de clientes, profesionales, servicios y citas.
2. Crear una interfaz de escritorio para registrar y consultar los datos principales.
3. Implementar modificación y cancelación de citas con validación.
4. Verificar la disponibilidad antes de guardar o modificar una cita.
5. Ejecutar y documentar pruebas funcionales.
6. Documentar la preparación del entorno, el uso del sistema y las decisiones técnicas.

## 5. Valor esperado

El valor principal es organizar la agenda desde un lugar central y detectar un cruce antes de guardar una cita. Los beneficios comerciales —por ejemplo, reducir realmente las esperas o el tiempo administrativo— no deben presentarse como resultados demostrados hasta medirlos.

## 6. Indicadores de éxito propuestos

| Indicador | Meta propuesta | Comprobación |
|---|---|---|
| Operaciones principales | Los casos de registro, consulta, modificación y cancelación funcionan | Casos y demostración |
| Prevención de solapamientos | Todos los casos definidos de cruce se rechazan | CP-06 y CP-10, más casos adicionales |
| Horario libre | Los casos válidos se guardan | CP-05 y CP-08 |
| Persistencia | Los datos guardados se recuperan de SQL Server | CP-11 |
| Manejo de errores | Los datos inválidos se rechazan con mensajes comprensibles | CP-02, CP-04, CP-12 y CP-14 |
| Reproducibilidad | Otro integrante puede preparar el entorno siguiendo instrucciones | Revisión cruzada |

Son metas de aceptación del software; no demuestran por sí solas impacto comercial en un negocio real.

## 7. Validación del problema — pendiente

1. Identificar al menos dos personas que trabajen o administren una barbería o salón, con autorización.
2. Preguntar cómo registran citas, qué errores ocurren y qué información necesitan consultar.
3. Anotar fecha, perfil general y respuestas resumidas, sin nombres ni teléfonos personales.
4. Comparar las respuestas con las funciones del MVP.
5. Guardar el resumen en el repositorio sin publicar datos personales.

Preguntas sugeridas:
- ¿Cómo registran y consultan las citas actualmente?
- ¿Qué ocurre cuando dos clientes piden el mismo horario?
- ¿Qué datos necesitan al registrar una cita?
- ¿Qué cambios o cancelaciones son frecuentes?
- ¿Qué sería lo más útil que hiciera un sistema de agenda?

**Estado:** pendiente de realizar y documentar. No afirmar que la investigación se completó hasta contar con resultados reales.
