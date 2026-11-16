# Guía de contribución

Gracias por colaborar con el proyecto del equipo Virus.

## Antes de trabajar

1. Revisar la consigna/rúbrica, el README y el documento de requisitos.
2. Consultar las incidencias abiertas para evitar duplicar trabajo.
3. Confirmar con el equipo las decisiones que afecten al modelo de datos, alcance o arquitectura.
4. No modificar código funcional de otro integrante sin coordinarlo.

## Flujo de trabajo

1. Crear una rama descriptiva desde `main` (por ejemplo, `feature/modulo-clientes` o `docs/actualizar-readme`).
2. Realizar cambios pequeños y relacionados.
3. Ejecutar las comprobaciones aplicables: compilar la solución, ejecutar el script SQL en un entorno de prueba y/o ejecutar los casos afectados.
4. Registrar en la incidencia o descripción del cambio qué se modificó y qué pruebas se realizaron.
5. Abrir un Pull Request hacia `main` y solicitar revisión del equipo.
6. No integrar el cambio hasta revisar el diff y resolver los problemas detectados.

## Mensajes de commit

Usar mensajes breves y descriptivos, preferiblemente con prefijo:
- `feat:` funcionalidad nueva.
- `fix:` corrección.
- `docs:` documentación.
- `test:` pruebas.
- `chore:` mantenimiento o configuración.

Ejemplos: `docs: actualizar instrucciones de instalación`, `feat: agregar formulario de clientes`.

## Reglas del repositorio

- Mantener C#, Windows Forms, .NET Framework 4.8, SQL Server y ADO.NET salvo acuerdo del equipo/docente.
- No subir contraseñas, credenciales, cadenas privadas ni datos reales de clientes.
- No subir carpetas generadas como `.vs`, `bin` u `obj`.
- Mantener los documentos sincronizados con el código y el script SQL.
- No marcar una funcionalidad o prueba como terminada sin ejecutarla y registrar evidencia.
