using System;

namespace ToDoListApp
{
    public class Tarea
    {
        // Propiedades de la clase Tarea
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool Completada { get; set; }

        // Constructor para inicializar una tarea
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false;
        }

        // Método para mostrar información de la tarea
        public override string ToString()
        {
            string estado = Completada ? "Completada" : "Pendiente";
            string fecha = FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin fecha límite";
            return $"Descripción: {Descripcion}, Fecha Límite: {fecha}, Estado: {estado}";
        }
    }
}
