using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola03_Condicionales_If_vs_Switch
{
    class Program
    {
        enum Idioma
        {
            Español = 1,
            English = 2,
            Français = 3,
            Português = 4,
        }
        static void Main(string[] args)
        {
            Idioma lang;
            Console.WriteLine("Inserte un número del 1 al 4 según corresponda su idioma: \n1 -Español \n2 -English \n3 -Français \n4 -Português");
            int opcion = Convert.ToInt32(Console.ReadLine());   //captamos el ingreso y convertimos a int
            lang = (Idioma)opcion;                              //realizamos el CAST o conversion a Idioma

            //aqui usamos Condicional IF
            Console.WriteLine("Resultado con If...");
            if (opcion == 1)
            {
                Console.Write("Bienvenido, usted ha elegido idioma {0}", lang);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Welcome, you have chosen {0} language", lang);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Bienvenue, vous avez choisi la langue {0}", lang);
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Bem-vindo, você escolheu a língua {0}", lang);
            }
            else
            {
                Console.WriteLine("Reintente/Retry/Réessayer/Tente novamente");
            }

            //Aquí obtendremos el mismo resultado que antes pero utilizando un condicional SWITCH
            Console.WriteLine("Resultado con Switch...");
            switch (opcion)
            {
                case 1:
                    Console.Write("Bienvenido, usted ha elegido idioma {0}", lang);
                    break;
                case 2:
                    Console.WriteLine("Welcome, you have chosen {0} language", lang);
                    break;
                case 3:
                    Console.WriteLine("Bienvenue, vous avez choisi la langue {0}", lang);
                    break;
                case 4:
                    Console.WriteLine("Bem-vindo, você escolheu a língua {0}", lang);
                    break;
                default:
                    Console.WriteLine("Reintente/Retry/Réessayer/Tente novamente");
                    break;
            }

            Console.ReadKey();
        }
    }
}
