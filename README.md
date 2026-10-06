# PR2-2026 — SISTEMA DE AGENDAMIENTO Y GESTIÓN PARA BARBERÍAS Y SALONES DE BELLEZA

> **Equipo:** Virus  
> **Universidad:** Universidad Privada "Franz Tamayo"  
> **Sede:** Cochabamba, Bolivia

---

## 1. Descripción del problema

Las barberías y salones de belleza en Cochabamba gestionan actualmente sus citas mediante cuadernos físicos y mensajes de WhatsApp. Esta forma de trabajo puede generar diferentes dificultades:

- Superposición y doble reserva de citas.
- Pérdida de tiempo del personal al atender consultas.
- Falta de un historial confiable de clientes.
- Ausencia de métricas organizadas sobre el funcionamiento del negocio.
- Demoras e incertidumbre para los clientes.

## 2. Propósito del proyecto

Desarrollar una aplicación de escritorio que **automatice y centralice** el agendamiento de citas, reduciendo errores humanos, optimizando los tiempos de trabajo y mejorando la experiencia de clientes y profesionales.

## 3. Usuarios del sistema

| Perfil | Beneficios |
|---|---|
| **Propietarios / Administradores** | Control global, métricas en tiempo real y registros organizados. |
| **Profesionales (barberos / estilistas)** | Horarios organizados y prevención de empalmes. |
| **Clientes** | Reservas seguras y confirmación inmediata. |

## 4. Objetivos del proyecto

- Implementar una base de datos relacional normalizada en **SQL Server**.
- Desarrollar una aplicación de escritorio en **C# y Windows Forms** con operaciones CRUD completas.
- Implementar un algoritmo de validación que **impida automáticamente las citas solapadas**.
- Incorporar un panel de control con métricas de citas programadas, atendidas y canceladas.
- Implementar módulos de historial, reportes y facturación.

## 5. Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| **C# (.NET Framework)** | Desarrollo de la aplicación |
| **Windows Forms** | Diseño de la interfaz gráfica |
| **SQL Server** | Gestión de la base de datos |
| **ADO.NET** | Conexión entre la aplicación y la base de datos |
| **Visual Studio** | Entorno de desarrollo |
| **GitHub** | Control de versiones y trabajo colaborativo |

## 6. Equipo y responsabilidades

| Nombre y Apellido | Rol | Responsabilidad principal |
|---|---|---|
| **Ekaitz Yale Yauli** | Líder / Backend | Arquitectura, base de datos SQL Server y conexión ADO.NET. |
| **Leonor Alejandra Almanza Arroyo** | Diseño / Frontend | Interfaces Windows Forms, experiencia de usuario y flujos del sistema. |
| **Jairo Damian Rodríguez Huanca** | QA / Documentación | Pruebas funcionales, validaciones y documentación en formato APA. |

## 7. Estructura del repositorio

```text
PR2-2026-SISTEMADEAGENDAMIENTOENBARBERIASYSALONESDEBELLEZA/
│
├── README.md
│
├── equipo/
│   ├── equipo-Ekaitz_Yale_Yauli.txt
│   ├── equipo-Leonor_Almanza.txt
│   └── equipo-jairo_rodriguez_huanca.txt
│
├── documentacion/
│   ├── informe/
│   ├── requisitos/
│   └── diagramas/
│
├── sistema/
│   ├── codigo/
│   ├── base-datos/
│   └── recursos/
│
├── pruebas/
│   ├── evidencias/
│   └── casos-prueba/
│
└── entregables/
```

## 8. Estado del proyecto

Este repositorio contiene la estructura base para el desarrollo del proyecto de **Programación II**. A medida que avance el desarrollo, se incorporarán el código fuente, la base de datos, la documentación, los diagramas, las pruebas y los entregables correspondientes.

---

**Proyecto de Programación II — Universidad Privada "Franz Tamayo"**  
**Cochabamba, Bolivia — 2026**