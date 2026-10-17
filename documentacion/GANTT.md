# Diagrama de Gantt — planificación propuesta

**Proyecto:** Sistema de Agendamiento y Gestión para Barberías y Salones de Belleza  
**Equipo:** Virus  
**Estado:** propuesta inicial; las fechas deben confirmarse con el calendario oficial del docente.

El cronograma está organizado para avanzar desde la definición del alcance hasta la preparación de la entrega. Las tareas se superponen cuando pueden realizarse en paralelo. La integración y las pruebas requieren que las funciones correspondientes ya existan.

```mermaid
gantt
    title Sistema de agendamiento — plan tentativo 2026
    dateFormat YYYY-MM-DD
    axisFormat %d %b
    section Preparación
    Confirmar MVP y reglas de negocio     :a1, 2026-10-19, 5d
    Validar problema con usuarios         :a2, 2026-10-19, 10d
    section Diseño
    Modelo de datos y relaciones          :b1, after a1, 10d
    Prueba de conexión ADO.NET            :b2, 2026-11-02, 5d
    Diseño de formularios                 :b3, 2026-11-02, 10d
    section Desarrollo
    CRUD de clientes, servicios y profesionales :c1, 2026-11-09, 12d
    Gestión de citas y solapamientos      :c2, 2026-11-16, 12d
    section Integración y calidad
    Integración de módulos                :d1, 2026-11-23, 12d
    Pruebas y correcciones                :d2, 2026-11-30, 12d
    section Cierre
    Documentación e instrucciones         :e1, 2026-12-07, 12d
    Ensayo de demostración y entrega      :e2, 2026-12-14, 5d
```

## Responsables principales

- Alcance, modelo de datos, conexión y backend: Ekaitz Yale Yauli.
- Diseño de formularios y flujo de usuario: Leonor Alejandra Almanza Arroyo.
- Casos de prueba, registro de resultados y documentación: Jairo Damian Rodríguez Huanca.
- Integración, decisiones de alcance y demostración: todo el equipo.

## Dependencias importantes

- El modelo definitivo depende de confirmar el alcance y las reglas de negocio.
- Los formularios conectados dependen de que el modelo y la conexión funcionen.
- Las pruebas de integración dependen de que los módulos estén conectados.
- La documentación final debe describir solo lo que realmente se implementó y probó.

**Importante:** este cronograma es tentativo y no demuestra que las tareas estén completadas. El equipo debe revisar la fecha oficial de entrega y actualizar el plan si las fechas no coinciden.
