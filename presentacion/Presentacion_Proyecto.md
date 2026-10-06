<PARSED TEXT FOR PAGE: 1 / 6>
Sistema de
Agendamiento
y Gestión para
Barberías y
Salones de Belleza
Universidad Privada Franz Tamayo
Facultad de Ingeniería
Programación 2
Integrantes
Ekaitz Yale Yauli
Leonor Alejandra Almanza Arroyo
Jairo Damian Rodríguez Huanca
Docente
Ing. Diego Patrick Cardenas Sejas
<PARSED TEXT FOR PAGE: 2 / 6>
Problema, Solución
y Objetivos
EL PROBLEMA
La gestión manual con agendas físicas y
WhatsApp genera errores, dobles
reservas y pérdidas de tiempo.
LA SOLUCIÓN
Un sistema centralizado y automatizado
para agendamiento y gestión de citas.
Base de datos SQL Server para clientes, servicios y citas
Interfaz gráfica en C# Windows Forms con operaciones CRUD
Validación automática para evitar citas solapadas
Dashboard con métricas de citas diarias
Historial y reportes para seguimiento
OBJETIVOS CLAVE
<PARSED TEXT FOR PAGE: 3 / 6>
Funcionamiento y
Algoritmo Principal
Funcionamiento y
Algoritmo Principal
“GestionarCita”
01
Seleccionar
cliente, servicio,
profesional y
fecha
02
Consultar
horarios
disponibles del
profesional
03 04
Registrar cita
omostrar error
según validación
05
Modificar o
cancelar citas
según necesidad
¿Profesional
atiende ese día?
¿Hay horarios libres?
¿Datos correctos?
¿Sin solapamientos?
04A
Registrar cita
con éxito
04B
Mostrarmensaje
de error
Validar
<PARSED TEXT FOR PAGE: 4 / 6>
Arquitectura Tecnológica
y Modelo de Datos Relacional
TECNOLOGÍA
C# + Windows Forms + SQL Server
Visual Studio y ADO.NET
para integración nativa y rendimiento
MODELO RELACIONAL
CLIENTE, PROFESIONAL, SERVICIO, CITA,
DETALLE
_CITA, FACTURA
Claves primarias y foráneas para evitar
duplicación y ordenar información
BENEFICIOS
Modularidad
Facilidad de mantenimiento
Escalabilidad
CLIENTE
IdCliente (PK)
Nombre
Teléfono
Email
PROFESIONAL
IdProfesional (PK)
Nombre
Especialidad
CITA
IdCita (PK)
FechaHora
IdCliente (FK)
IdProfesional (FK)
Estado
SERVICIO
IdServicio (PK)
Nombre
Duración
PrecioBase
DETALLE
_CITA
IdDetalle (PK)
IdCita (FK)
IdServicio (FK)
Precio
FACTURA
IdFactura (PK)
IdCita (FK)
Fecha
Total
<PARSED TEXT FOR PAGE: 5 / 6>
BENEFICIOS,
COSTOS
Y
VIABILIDAD
Administradores
Visibilidad en tiempo real
y menos trabajo manual
Personal operativo
Organización y
eliminación de empalmes
Clientes
Reducción de esperas y
garantía de cita
<PARSED TEXT FOR PAGE: 6 / 6>
Estado Actual y
Próximos Pasos
Estado Actual y
Próximos Pasos
El proyecto está en planificación y preparación.
Avanzamos con un cronograma claro hacia su finalización.
El proyecto está en planificación y preparación.
Avanzamos con un cronograma claro hacia su finalización.
OCT-NOV 2026
Diseño BD
e interfaces
Diseño BD
e interfaces
Diseño de base de datos y
diseño de interfaces
de usuario
Diseño de base de datos y
diseño de interfaces
de usuario
NOV 2026
Implementación
y módulos
Implementación
y módulos
Desarrollo de funcionalidades
e integración de módulos
Desarrollo de funcionalidades
e integración de módulos
DIC 2026
Pruebas y
documentación
Pruebas y
documentación
Pruebas del sistema
y documentación final
Pruebas del sistema
y documentación final
EQUIPO RESPONSABLE
Ekaitz
backend/BD
Leonor
UI/UX frontend
Jairo
QA documentación
Gracias por su atención. ¿Preguntas?