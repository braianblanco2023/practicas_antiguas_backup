using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola04_Bucles_For_y_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miArray = new int[4];             //se crea un array tipo int, y se lo crea con 4 elementos, de [0] a [3]
            miArray[0] = 20;                        //a este elemento en el array le pasamos un entero 
            miArray[1] = miArray[0] + 10;           //a este le pasamos la suma del elemento [0] mas un entero
            miArray[2] = miArray[0] + miArray[1];   //y a este le pasamos la suma del valor de los elementos [0] y [1]
                                                    //al elemento [3] no le pasamos valor por lo que queda en 0
            //creamos un int de valor inicial 0, que mientras sea menor a 4, lo aumentaremos de 1 en 1
            for (int posicion = 0; posicion < 4; posicion++)    
            {   //y en cada vuelta del bucle, mostramos el valor del elemento segun la posicion indicada
                Console.WriteLine("Elemento {0} valor {1}", posicion, miArray[posicion]);   //usamos "posicion" para recorrer el array
            }

            //creamos una variable que representa un entero en el conjunto de enteros del array
            foreach (int valor in miArray)
            {   //y por cada uno (for each) mostramos su valor
                Console.WriteLine("Valor {0}", valor);
            }
            Console.ReadKey();
        }
    }
}
