using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola27_Colecciones_Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

class Program
       {
            static void Main(string[] args)
            {
                // Crear un diccionario para almacenar las calificaciones de los estudiantes
                Dictionary<string, double> calificaciones = new Dictionary<string, double>();

                // Añadir algunas calificaciones al diccionario
                calificaciones.Add("Juan", 8.5);
                calificaciones.Add("María", 9.2);
                calificaciones.Add("Pedro", 7.8);

                // Mostrar las calificaciones
                Console.WriteLine("Calificaciones de los estudiantes:");
                foreach (var estudiante in calificaciones)
                {
                    Console.WriteLine($"{estudiante.Key}: {estudiante.Value}");
                }

                // Buscar una calificación específica
                string nombreEstudiante = "María";
                if (calificaciones.ContainsKey(nombreEstudiante))
                {
                    Console.WriteLine($"\nLa calificación de {nombreEstudiante} es: {calificaciones[nombreEstudiante]}");
                }
                else
                {
                    Console.WriteLine($"\nEstudiante {nombreEstudiante} no encontrado.");
                }

                // Actualizar una calificación
                calificaciones["Pedro"] = 8.1;
                Console.WriteLine($"\nCalificación actualizada de Pedro: {calificaciones["Pedro"]}");

                // Eliminar una calificación
                calificaciones.Remove("Juan");
                Console.WriteLine("\nCalificaciones después de eliminar a Juan:");
                foreach (var estudiante in calificaciones)
                {
                    Console.WriteLine($"{estudiante.Key}: {estudiante.Value}");
                }

                Console.ReadKey();
            }
        }

    }
}
}
