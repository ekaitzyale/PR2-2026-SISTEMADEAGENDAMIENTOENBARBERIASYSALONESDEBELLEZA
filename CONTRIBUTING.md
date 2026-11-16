# Guía de contribución

Gracias por colaborar con el proyecto del equipo Virus.

## Antes de comenzar
1. Clonar el repositorio y actualizar la rama principal.
2. Revisar el README y la documentación relacionada con la tarea.
3. Comprobar que el entorno local esté configurado.
4. Consultar las incidencias abiertas para evitar duplicar trabajo.
5. Confirmar con el equipo las decisiones que afecten al alcance, modelo de datos o arquitectura.

## Flujo de trabajo
1. Crear una rama descriptiva desde `main` (por ejemplo, `feature/modulo-clientes` o `docs/actualizar-readme`).
2. Realizar cambios pequeños y relacionados con una tarea.
3. Mantener la organización actual del proyecto.
4. Usar consultas SQL parametrizadas.
5. No incluir credenciales, datos reales ni archivos generados.
6. Actualizar la documentación cuando cambie el comportamiento o el modelo de datos.
7. Compilar la solución y ejecutar las pruebas relacionadas.
8. Abrir un Pull Request hacia `main`, describiendo cambios y verificaciones.
9. Revisar el diff y resolver observaciones antes de integrar.

## Commits
Usar mensajes claros y descriptivos:
- `feat:` funcionalidad nueva.
- `fix:` corrección.
- `docs:` documentación.
- `test:` pruebas.
- `chore:` mantenimiento/configuración.

Ejemplos: `docs: actualizar instrucciones de instalación`, `feat: agregar registro de clientes`, `fix: validar disponibilidad de citas`.

## Verificación
- Compilar la solución en Visual Studio/MSBuild.
- Ejecutar las pruebas relacionadas.
- Revisar los archivos modificados.
- Confirmar que no se incluyan secretos, datos personales ni archivos temporales.
- No marcar una función como terminada sin registrar evidencia.
