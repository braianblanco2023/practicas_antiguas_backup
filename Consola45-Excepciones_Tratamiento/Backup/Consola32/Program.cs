using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola32
{
    class Program
    {
        //Podemos tratar cada excepcion que se pueda dar de diferente manera y con diferente código...
        static void Main(string[] args)
        {
            int dividendo;
            int divisor = 2;
            int resultado = 0;
            Console.Write("Ingrese un número a dividir a la mitad: ");
            try
            {
                dividendo = Convert.ToInt32(Console.ReadLine());
                resultado = divisor / dividendo;
            }
            catch (FormatException FE)           //Esta es una excepcion de Formato
            {
                Console.WriteLine("Excepcion de formato:");
                Console.WriteLine(FE.Message);
            }
            catch (DivideByZeroException DZE)    //Esta es una excepcion de Division por cero
            {
                Console.WriteLine("Excepcion de division por cero:");
                Console.WriteLine(DZE.Message);
            }
            catch (Exception E)                 //Esta es cualquier excepcion, todas en general
            {
                Console.WriteLine("Otras excepciones");
                Console.WriteLine(E.Message);
            }
            Console.WriteLine("Resultado de division: " + resultado);
            Console.ReadKey();
        }
        //Pero si usamos las dos primeras, la tercera (Exception) debe ir última, como si se tratase
        //de un "else" (otros casos) dentro de un condicional "if", sino tendremos error de ejecucion.
    }
}
