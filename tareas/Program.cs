using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorDeTareas gestor = new GestorDeTareas();
            bool salir = false;

            while (!salir)
            {
                // Mostrar menú de opciones al usuario
                Console.WriteLine("\n--- Gestor de Tareas ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                try
                {
                    switch (opcion)
                    {
                        case "1":
                            // Agregar nueva tarea
                            Console.Write("Descripción de la tarea: ");
                            string descripcion = Console.ReadLine();
                            Console.Write("Fecha límite (opcional, formato: dd/mm/yyyy) o presiona Enter para omitir: ");
                            string fechaInput = Console.ReadLine();
                            DateTime? fechaLimite = null;

                            if (!string.IsNullOrWhiteSpace(fechaInput) && DateTime.TryParse(fechaInput, out DateTime fecha))
                            {
                                fechaLimite = fecha;
                            }

                            gestor.AgregarTarea(descripcion, fechaLimite);
                            break;

                        case "2":
                            // Listar todas las tareas
                            gestor.ListarTareas();
                            break;

                        case "3":
                            // Marcar una tarea como completada
                            Console.Write("Índice de la tarea a marcar como completada: ");
                            if (int.TryParse(Console.ReadLine(), out int indiceCompletada))
                            {
                                gestor.MarcarTareaComoCompletada(indiceCompletada);
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
                            }
                            break;

                        case "4":
                            // Eliminar una tarea de la lista
                            Console.Write("Índice de la tarea a eliminar: ");
                            if (int.TryParse(Console.ReadLine(), out int indiceEliminar))
                            {
                                gestor.EliminarTarea(indiceEliminar);
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
                            }
                            break;

                        case "5":
                            // Salir del programa
                            salir = true;
                            Console.WriteLine("Saliendo de la aplicación...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida, por favor intenta de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo general de excepciones
                    Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
                }
            }
        }
    }
}
