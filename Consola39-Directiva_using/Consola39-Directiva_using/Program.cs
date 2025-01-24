using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola39_Directiva_using
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antes de la instrucción using");

            using (Libro mv = new Libro())      //Aqui se implementa el bloque using, al objeto de Libro
            {
                Console.WriteLine("Dentro de la instrucción using");
                mv.Nombre = "Juan";
                mv.NumeroPaginas = 204;
                mv.Mostrar();
            }                                   //hasta aqui, donde se libera los recursos del objeto

            Console.WriteLine("Después de la instrucción using");
            Console.ReadKey();
        }
    }
    //Para el uso de using las clases de los objetos que la dispongan deben implementar la interfaz IDisposable
    class Libro : IDisposable       //con esta interfaz pueden implementar su metodo Dispose();
    {				    //si trabajamos con	Streams (archivos), estos ya implementan IDisposable
        private String nombre;
        private int numeroPaginas;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }
        public void Mostrar()
        {
            Console.WriteLine("Libro Nombre:{0}", Nombre);
            Console.WriteLine("Libro NumeroPaginas:{0}", NumeroPaginas);
        }
        void IDisposable.Dispose()  //Este es el encargado de liberar los recursos al final del bloque using
        {                           //como se ve también puede agregarse instrucciones al metodo Dispose()
            Console.WriteLine("El Alcance de using ha finalizado. El recurso Libro se ha dispuesto.");
        }
    }
}
/* En C#, using se utiliza para asegurar que los recursos no administrados (archivos, conexiones de red,
 * conexiones de bases de datos, etc.) se liberen adecuadamente cuando ya no sean necesarios.
 * Si trabajamos con archivos, using garantiza que este se cierre correctamente después de su uso, 
 * incluso si ocurre una excepción durante el proceso de lectura o escritura.
 * Esto afecta el rendimiento positivamente, ya que almacenando un conjunto de datos y objetos pesados, 
 * se liberará el recurso tan pronto como se termine de ejecutar el bloque using o se lanze una excepción 
 * La instrucción using define el alcance del objeto/recurso.
 */
