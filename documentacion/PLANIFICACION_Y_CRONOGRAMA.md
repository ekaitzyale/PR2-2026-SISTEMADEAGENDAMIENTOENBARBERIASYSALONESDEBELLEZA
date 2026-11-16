# Planificación, cronograma, coordinación y riesgos

**Estado:** plan de trabajo del equipo. Las fechas originales son tentativas y deben contrastarse con el calendario oficial y la fecha de entrega confirmada. El estado se actualiza solo con evidencia del repositorio o de pruebas ejecutadas.

## 1. Responsables

- **Ekaitz Yale Yauli — coordinación técnica y backend/base de datos:** modelo SQL, script, acceso ADO.NET, persistencia e integración técnica.
- **Leonor Alejandra Almanza Arroyo — interfaz y flujo:** formularios Windows Forms, navegación, validaciones visuales y mensajes.
- **Jairo Damian Rodríguez Huanca — calidad y documentación:** casos de prueba, resultados, evidencias y documentos.
- **Todo el equipo:** alcance, reglas de negocio, integración, revisión del repositorio y demostración final.

## 2. Estado de avance comprobable

| Área | Estado según el repositorio |
|---|---|
| Análisis, problema y objetivos | Documentados como propuesta; falta incorporar evidencia primaria de validación con usuarios. |
| Requisitos y alcance | Documentados; falta confirmar alcance con el docente y resolver la relación SERVICIO–CITA. |
| Base de datos | Script SQL de cuatro tablas e índices versionado; ejecución y validación en el entorno actual deben registrarse. |
| Aplicación C# | Solución y proyecto .NET Framework 4.8 versionados. |
| Interfaz | Menú inicial creado; botones deshabilitados. |
| Acceso a datos | Clase de conexión y cadena de configuración presentes; faltan operaciones CRUD verificadas. |
| Lógica de negocio | No se observan clases implementadas para reglas de citas o disponibilidad. |
| Pruebas | Casos diseñados; resultados de ejecución pendientes de registrar. |
| Documentación y presentación | Archivos presentes; deben actualizarse conforme avance la implementación. |

## 3. Etapas de trabajo

| Etapa | Actividades | Responsable principal | Entregable/condición de cierre |
|---|---|---|---|
| 1. Confirmar alcance | Revisar consigna/rúbrica, MVP, reglas y versiones | Todo el equipo | Acuerdos registrados |
| 2. Validar problema | Entrevistar u observar usuarios con autorización y resumir resultados | Jairo, con apoyo del equipo | Evidencia anonimizada |
| 3. Modelo de datos | Revisar entidades, claves, estados y relación SERVICIO–CITA | Ekaitz | Modelo y SQL coherentes |
| 4. Verificar entorno | Ejecutar script, probar conexión y persistencia | Ekaitz | Evidencia reproducible |
| 5. Formularios | Diseñar y habilitar formularios de mantenimiento | Leonor | Formularios navegables |
| 6. CRUD básicos | Implementar registro, consulta y modificación | Ekaitz y Leonor | Operaciones probadas |
| 7. Gestión de citas | Registrar, consultar, modificar, cancelar y validar cruces | Ekaitz y Leonor | Regla de disponibilidad probada |
| 8. Integración | Integrar módulos y revisar errores | Todo el equipo | Versión candidata |
| 9. Pruebas y correcciones | Ejecutar casos, registrar resultados y corregir fallos | Jairo, con apoyo del equipo | Matriz de pruebas completa |
| 10. Entrega | Actualizar manuales, informe, presentación y preparar demostración | Todo el equipo | Entrega revisada |

## 4. Cronograma de referencia

El equipo propuso inicialmente estas ventanas: octubre de 2026 para alcance y diseño; octubre-noviembre para modelo de datos, prueba técnica e interfaces; noviembre para CRUD e integración; y noviembre-diciembre para pruebas, documentación y presentación.

Las fechas son tentativas, no confirman actividades completadas ni la fecha oficial de entrega. Se conserva el Gantt original como referencia visual:

![Diagrama Gantt original del equipo](https://github.com/user-attachments/assets/7b6597ad-71e3-44a0-84a9-cbaeb1804b25)

Actualizar las fechas y el estado de cada tarea según el avance real del equipo.

## 5. Dependencias y tareas bloqueantes

1. Confirmar alcance y reglas antes de cerrar el modelo de datos.
2. Resolver la relación SERVICIO–CITA antes de implementar el registro completo de citas con servicio.
3. Ejecutar y verificar el script antes de integrar los formularios.
4. Definir duración, inicio, fin, profesional y estado antes de programar solapamientos.
5. Integrar los módulos antes de ejecutar pruebas completas.
6. Corregir los fallos antes de preparar la entrega.
7. La documentación final debe describir la versión realmente implementada.

## 6. Mecanismo de trabajo

- Usar GitHub como fuente común del código y los documentos.
- Hacer commits pequeños con mensajes descriptivos.
- Trabajar en ramas y revisar cambios antes de integrarlos en `main`.
- No subir `.vs`, `bin`, `obj`, credenciales, cadenas de conexión privadas ni datos reales.
- Registrar decisiones de reglas de negocio en Markdown.
- Revisar semanalmente avances, pruebas y bloqueos.
- Mantener tareas en estados: pendiente, en curso, bloqueada o terminada.
- No marcar una función como completa sin ejecutarla y registrar evidencia.

## 7. Riesgos y mitigación

| Riesgo | Probabilidad inicial | Impacto | Mitigación | Señal temprana |
|---|---|---|---|---|
| Crecimiento del alcance | Alta | Alto | Mantener el MVP y posponer extras | Se agregan módulos antes de terminar citas |
| Error de integración SQL Server | Media | Alto | Probar conexión y consultas al inicio | No se puede guardar/consultar |
| Solapamiento mal validado | Media | Alto | Probar intervalos cruzados, consecutivos y cancelados | Se acepta una cita incompatible |
| Relación servicio-cita sin definir | Alta | Alto | Resolver cardinalidad y actualizar SQL antes de programar esa parte | No se puede recuperar qué servicio corresponde a una cita |
| Integrante no disponible | Media | Alto | Documentar avances y reasignar tareas | Tarea crítica sin respaldo |
| Conflictos de versiones | Media | Medio | Commits frecuentes y revisión antes de integrar | Cambios sobrescritos |
| Falta de evidencia | Media | Alto | Registrar resultado y captura al ejecutar cada prueba | Función marcada como lista sin prueba |

Las probabilidades son estimaciones iniciales y deben revisarse durante el proyecto.

## 8. Continuidad y revisión

Si alguien no está disponible: revisar tareas y últimos cambios en GitHub, consultar requisitos y arquitectura, reasignar la tarea, reducir funciones opcionales si peligra el MVP y registrar la decisión.

En cada revisión semanal el equipo debe responder: qué se terminó y dónde está; qué prueba se ejecutó; qué está bloqueado; quién puede ayudar; cuál es la siguiente tarea; y si el alcance sigue siendo viable.
