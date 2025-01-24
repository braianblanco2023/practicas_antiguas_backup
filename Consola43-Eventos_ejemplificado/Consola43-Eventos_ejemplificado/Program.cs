using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola43_Eventos_ejemplificado
{
    using System;
    using System.Collections.Generic;

    // Definición del delegado
    public delegate void delTarea(Tarea t);

    // Argumentos del evento
    public class Tarea  : EventArgs
    {
        public string NombreTarea { get; set; }

        public Tarea(string nombreTarea)
        {
            NombreTarea = nombreTarea;
        }
    }

    // Clase que maneja las tareas
    public class GestorTareas
    {
        // Definición de los eventos
        public event delTarea TareaAñadida;
        public event delTarea TareaCompletada;

        private List<string> tareas = new List<string>();

        // Método para añadir una nueva tarea
        public void AñadirTarea(string nombreTarea)
        {
            tareas.Add(nombreTarea);
            // Disparar el evento TareaAñadida
            TareaAñadida?.Invoke(new Tarea(nombreTarea));
        }

        // Método para completar una tarea
        public void CompletarTarea(string nombreTarea)
        {
            if (tareas.Contains(nombreTarea))
            {
                tareas.Remove(nombreTarea);
                // Disparar el evento TareaCompletada
                TareaCompletada?.Invoke(new Tarea(nombreTarea));
            }
        }
    }

    // Clase que maneja las notificaciones
    public class Notificador
    {
        public void OnTareaAñadida(Tarea t)
        {
            Console.WriteLine($"Notificación: Se ha añadido la tarea '{t.NombreTarea}'.");
        }

        public void OnTareaCompletada(Tarea t)
        {
            Console.WriteLine($"Notificación: Se ha completado la tarea '{t.NombreTarea}'.");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            GestorTareas gestorTareas = new GestorTareas();
            Notificador notificador = new Notificador();

            // Suscribir los métodos a los eventos
            gestorTareas.TareaAñadida += notificador.OnTareaAñadida;
            gestorTareas.TareaCompletada += notificador.OnTareaCompletada;

            // Añadir y completar tareas para ver los eventos en acción
            gestorTareas.AñadirTarea("Aprender C#");
            gestorTareas.AñadirTarea("Escribir código limpio");
            gestorTareas.CompletarTarea("Aprender C#");

            Console.ReadKey();
        }
    }
    /* EXPLICACION siguiendo el flujo de datos en la aplicación: 
     * Al Añadir una Nueva Tarea con el método AñadirTarea del GestorTareas, pasando el nombre de la tarea
     * como argumento, por un lado, se agrega la misma a una lista, y además, con este nombre se construye 
     * un objeto Tarea, objeto que se pasa como parámetro al evento TareaAñadida invocado en la misma linea.
     * Debido a que este evento tiene la misma firma que el delegado al que esta suscrito, y está vinculado
     * al metodo OnTareaAñadida del notificador, la Tarea creada se envia mediante el delegado al metodo en 
     * cuestion (como parametro), y alli se usa el objeto para imprimir su propiedad Nombre.
     */
}
