using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola31
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Ingrese un valor entero: ");
            //en el curso normal de la ejecución, si el código de try da un error(excepcion)...
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            //...se salta al código en catch, donde capturamos la excepcion como un objeto por parámetro...
            catch(SystemException SE)
            {
                Console.WriteLine(SE.Message);      //...y mostramos el mensaje de la excepción al usuario.
            }
            //Y luego se sigue aquí, se halla o no ejecutado el catch
            Console.WriteLine("Ingreso: " + a);
            Console.ReadKey();
        }
    }
    //SystemException.Message nos dará donde se halla el error.
}
