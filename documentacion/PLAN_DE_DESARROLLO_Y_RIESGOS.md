# Plan de desarrollo, coordinación y riesgos

**Estado:** planificación propuesta. Las fechas deben ajustarse al calendario oficial de la asignatura y la disponibilidad real del equipo.

## 1. Responsables

- **Ekaitz Yale Yauli — Backend/base de datos:** modelo SQL, tablas, acceso ADO.NET y persistencia.
- **Leonor Alejandra Almanza Arroyo — Interfaz y flujo:** formularios Windows Forms, navegación, validaciones visuales y mensajes.
- **Jairo Damian Rodríguez Huanca — Calidad/documentación:** casos de prueba, resultados, evidencias y documentos.
- **Compartido:** alcance, reglas de negocio, integración, revisión del repositorio y demostración final.

## 2. Plan tentativo por semanas

| Etapa | Periodo propuesto | Tareas | Responsable principal | Salida/dependencia |
|---|---|---|---|---|
| 1. Acordar alcance | 19–23 oct. 2026 | Confirmar MVP, reglas, versiones y criterios | Todo el equipo | Acuerdo escrito |
| 2. Validar problema | 19–30 oct. | Consultar usuarios potenciales y registrar resultados | Jairo, con apoyo del equipo | Evidencia de validación |
| 3. Modelo de datos | 26 oct.–6 nov. | Entidades, claves, estados y duración de citas | Ekaitz | Modelo revisado |
| 4. Prueba técnica | 2–6 nov. | Probar conexión ADO.NET y lectura/escritura | Ekaitz | Evidencia de conexión |
| 5. Diseño de formularios | 2–13 nov. | Diseñar pantallas y navegación | Leonor | Flujo de pantallas |
| 6. CRUD básicos | 9–20 nov. | Registro, consulta y modificación de datos | Ekaitz y Leonor | Módulos básicos |
| 7. Gestión de citas | 16–27 nov. | Registrar, consultar, modificar, cancelar y validar cruces | Ekaitz y Leonor | Función central |
| 8. Integración | 23 nov.–4 dic. | Integrar módulos y revisar errores | Todo el equipo | Versión candidata |
| 9. Pruebas/correcciones | 30 nov.–11 dic. | Ejecutar casos, corregir fallos y guardar evidencias | Jairo, con apoyo del equipo | Registro de pruebas |
| 10. Documentación/demo | 7–18 dic. | README, instrucciones, informe y ensayo | Jairo, con apoyo del equipo | Entrega preparada |

Estas fechas son una propuesta de organización, no una confirmación de la fecha de entrega.

## 3. Dependencias y tareas bloqueantes

1. Alcance y reglas antes del diseño definitivo de tablas.
2. Modelo de datos y prueba de conexión antes de integrar formularios.
3. Definición de duración, inicio, fin, profesional y estado antes de programar solapamientos.
4. Módulos integrados antes de las pruebas completas.
5. Correcciones antes de la entrega.
6. La documentación final debe reflejar la versión realmente implementada, no funciones que solo estaban planeadas.

## 4. Mecanismo de trabajo

- Usar GitHub como fuente común de código y documentos.
- Hacer commits pequeños con mensajes descriptivos.
- Revisar cambios antes de integrarlos a main.
- No subir .vs, bin, obj, credenciales, cadenas de conexión ni datos reales.
- Registrar decisiones de reglas de negocio en Markdown.
- Realizar una revisión semanal de avances y bloqueos.
- Mantener una lista de tareas: pendiente, en curso, bloqueada o terminada.
- Probar cada función antes de declararla completa.

## 5. Riesgos y mitigación

| Riesgo | Probabilidad inicial | Impacto | Mitigación | Señal temprana |
|---|---|---|---|---|
| Crecimiento del alcance | Alta | Alto | Congelar MVP y aceptar extras después | Se agregan módulos antes de terminar citas |
| Error de integración SQL Server | Media | Alto | Probar conexión y consultas al inicio | No se puede guardar/consultar |
| Solapamiento mal validado | Media | Alto | Probar intervalos cruzados, consecutivos y cancelados | Se acepta una cita incompatible |
| Integrante no disponible | Media | Alto | Documentar, compartir avances y reasignar | Tarea crítica sin respaldo |
| Conflictos de versiones | Media | Medio | Commits frecuentes y revisión antes de integrar | Cambios sobrescritos o errores de compilación |
| Falta de evidencia | Media | Alto | Registrar resultado y captura al ejecutar cada prueba | Función marcada como lista sin prueba |

Las probabilidades son estimaciones iniciales y deben revisarse.

## 6. Continuidad si alguien no está disponible

1. Revisar la tarea y los últimos cambios en GitHub.
2. Consultar requisitos y arquitectura.
3. Reasignar la tarea con una revisión breve.
4. Reducir funciones opcionales si peligra el MVP.
5. Registrar la decisión y actualizar el plan.

## 7. Revisión semanal

El equipo revisará qué se terminó y dónde está el resultado; qué prueba se ejecutó; qué está bloqueado; quién puede ayudar; cuál es la siguiente tarea; y si el alcance sigue siendo viable.
