using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListApp
{
    public class GestorDeTareas
    {
        private List<Tarea> listaDeTareas = new List<Tarea>();

        // Método para agregar una nueva tarea a la lista
        public void AgregarTarea(string descripcion, DateTime? fechaLimite = null)
        {
            Tarea nuevaTarea = new Tarea(descripcion, fechaLimite);
            listaDeTareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        // Método para listar todas las tareas
        public void ListarTareas()
        {
            if (listaDeTareas.Any())
            {
                Console.WriteLine("Listado de Tareas:");
                for (int i = 0; i < listaDeTareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaDeTareas[i]}");
                }
            }
            else
            {
                Console.WriteLine("No hay tareas registradas.");
            }
        }

        // Método para marcar una tarea como completada
        public void MarcarTareaComoCompletada(int indice)
        {
            if (indice > 0 && indice <= listaDeTareas.Count)
            {
                listaDeTareas[indice - 1].Completada = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Índice de tarea no válido.");
            }
        }

        // Método para eliminar una tarea de la lista
        public void EliminarTarea(int indice)
        {
            if (indice > 0 && indice <= listaDeTareas.Count)
            {
                listaDeTareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada de la lista.");
            }
            else
            {
                Console.WriteLine("Índice de tarea no válido.");
            }
        }
    }
}
