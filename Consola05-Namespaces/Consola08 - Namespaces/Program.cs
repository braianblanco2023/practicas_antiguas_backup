using System;
//Separar clases en Namespaces sirve para agrupar un conjunto de clases relacionadas

namespace miNamespace_1                 //creamos nuestro namespace
{
    class miClase                       //creamos una clase con x nombre
    {
        public static void miMetodo()   //creamos un metodo con x nombre
        {
            Console.WriteLine("Metodo miMetodo en miClase en miNamespace_1");
        }
    }
}
namespace miNamespace_2                 //creamos nuestro namespace
{
    class miClase                       //creamos una clase con el mismo nombre que el anterior namespace
    {
        public static void miMetodo()   //creamos un metodo con el mismo nombre que el anterior namespace
        {
            Console.WriteLine("Metodo miMetodo en miClase en miNamespace_2");
        }
    }
}
namespace Consola08___Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finalmente llamamos a las clases con mismo nombre, sin conflicto
            miNamespace_1.miClase.miMetodo();   //la diferencia solo radica en el nombre del namespace
            miNamespace_2.miClase.miMetodo();
            //hemos creado los metodos static adrede, para invocarlos sin crear un objeto de la clase
            Console.WriteLine("Hello World!");
        }
    }
}
