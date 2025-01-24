using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola4
{
    class Program
    {
        static void Main(string[] args)
        {
            //uso de WHILE
            string password = ""; //se inicializa password con un valor incorrecto para poder entrar en el bucle
            while (password != "pass123")
            {
                Console.WriteLine("Ingrese la contraseña:");
                password = Console.ReadLine();
            }
            Console.WriteLine("Contraseña correcta!");
            Console.ReadKey();

            //lo anterior es lo mismo que escribir lo siguiente con el uso de DO WHILE
            /*
            string password;    //aqui no se inicializa password con un valor pues luego se tomarà lo ingresado al menos una vez
            do
            {
                Console.WriteLine("Ingrese la contraseña:");
                password = Console.ReadLine();
            }
            while (password != "pass123");
            Console.WriteLine("Contraseña correcta!");
            Console.ReadKey();
            */
        }
    }
}
