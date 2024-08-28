Gestión de Tareas (To-Do List) - Aplicación de Consola
Descripción del Proyecto
Esta aplicación de consola en C# está diseñada para gestionar una pequeña lista de tareas (To-Do List). Los usuarios pueden agregar, listar, marcar como completadas y eliminar tareas. La aplicación hace uso de .NET Framework 4.8.

Características
Agregar Tareas: Permite agregar nuevas tareas con una descripción y una fecha límite opcional.
Listar Tareas: Muestra un listado de todas las tareas registradas, junto con su estado (completada o pendiente).
Marcar Tareas como Completadas: Permite marcar una tarea específica como completada.
Eliminar Tareas: Permite eliminar una tarea específica de la lista.
Requerimientos Técnicos
Uso de clases y objetos para representar las tareas.
Manejo de colecciones utilizando una lista genérica (List<T>).
Interacción con el usuario a través de un menú en la consola.
Manejo básico de excepciones para entradas inválidas.
Instrucciones para Compilar y Ejecutar la Aplicación
Pre-requisitos:

Asegúrate de tener instalado .NET Framework 4.8.
Un IDE que soporte C# y .NET Framework 4.8, como Visual Studio (versión 2019 o posterior).
Clonar el Repositorio:

bash
Copiar código
git clone https://github.com/anfececa/Gestion-de-Tareas-To-Do-List.git
cd Gestion-de-Tareas-To-Do-List
Abrir el Proyecto:

Abre el archivo de solución (.sln) en Visual Studio.
Compilar la Aplicación:

En Visual Studio, selecciona el menú Build y luego Build Solution o presiona Ctrl + Shift + B.
Asegúrate de que no haya errores de compilación.
Ejecutar la Aplicación:

Presiona Ctrl + F5 en Visual Studio para ejecutar la aplicación sin depuración.
Sigue las instrucciones en la consola para interactuar con el menú de gestión de tareas.
Documentación del Código
El código fuente está documentado con comentarios para explicar la lógica implementada y las funciones de cada método. Consulta los archivos .cs para obtener más detalles sobre la implementación.

Manejo de Errores
La aplicación incluye manejo básico de excepciones para validar entradas del usuario. Si se ingresa una entrada no válida, la aplicación mostrará un mensaje de error adecuado y solicitará una nueva entrada.

Notas
Este proyecto está diseñado para ser una introducción básica a la programación orientada a objetos y la interacción con el usuario a través de la consola.
Puedes extender esta aplicación agregando características adicionales como persistencia de datos, prioridad de tareas, etc.
Contribuciones
Si deseas contribuir a este proyecto, por favor haz un fork del repositorio y envía un pull request con tus cambios.
