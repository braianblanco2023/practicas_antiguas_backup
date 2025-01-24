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
            int divisor;
            int resultado = 0;
            
            try
            {
                Console.Write("Ingrese un número a dividir: ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese un número como divisor: ");
                divisor = Convert.ToInt32(Console.ReadLine());
                resultado = dividendo / divisor;
                //e incluso podemos personalizar nuesrtos errores:
                if (divisor == 4)
                {   //...creando nuestra excepción que desencadena una de tipo Exception
                    throw new Exception("Esta es una excepcion al dividir por 4");
                }
                Console.WriteLine("Resultado de division: " + resultado);
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
            //Esto se ejecuta de cualquier modo
            finally
            {
                Console.WriteLine("Esto se ejecuta en un finally si o si");
            }
            Console.ReadKey();

            //Pero si usamos las dos primeras, la tercera (Exception) debe ir última, como si se tratase
            //de un "else" (otros casos) dentro de un condicional "if", sino tendremos error de ejecucion.
        }
    }
}
