using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //Necesario para utilizar colecciones, como ArrayList, etc...
using System.Collections.Concurrent; //Necesario para Diccionarios Concurrentes

namespace Consola25_Colecciones
{
    class Program
    {
        public void trabajaconArrays()
        {        //Arrays...
            int[] miArray = new int[6];         //Unidimensionales (en este caso 1 x 6, de 0 a 5)
            Console.WriteLine(miArray[3]);      //accedemos indicando su indice

            int[,] tabla = new int[3, 2];       //De 2 dimensiones (en este caso de 3 filas x 2 columnas)
            tabla[0, 2] = 10;   //el cual le asignamos valores indicando posicion
            int[,] tabla2 = { { 2, 4, 6 }, { 5, 10, 15 } }; //o le asignamos al definirlo
            Console.WriteLine(tabla[2,0]);      //accedemos indicando su indice (fila) y subindice (columna)
        }
        public void ArraysdeArrays()            //'jagged array' o Array que contiene arrays (dentado)
        {
            int[][] arraydeArrays;  //lo declaramos así
            arraydeArrays = new int[3][];// definimos la cantidad de elementos (arrays) del array primario
            // y Luego definimos como arrays convencionales, los arrays dentro del array primario...
            arraydeArrays[0] = new int[8];
            arraydeArrays[1] = new int[7];
            //arraydeArrays[2] = new int[2, 2];     //esto da error pues solo recibe arrays unidimensionales
            Console.WriteLine(arraydeArrays[1][1]); //accedemos indicando indice array y elemento del array
        }
        public void contenedordeArrays()            //para almacenar arrays multidimensionales o no...
        {
            object[] objdeArrays = new object[3];

            // Definimos arrays de diferentes dimensiones
            objdeArrays[0] = new int[8];          //tenemos dos unidimensionales
            objdeArrays[1] = new int[7];
            objdeArrays[2] = new int[2, 2];       //tenemos uno de dos dimensiones
            //Esto convierte al objeto en una matriz de 3 dimensiones (3D)
            //Para acceder a sus elementos, debemos hacer CAST (conversion), donde no se crea un nuevo array
            int[] arrayUnidimensional1 = (int[])objdeArrays[0];     //sino que una referencia del original
            arrayUnidimensional1[0] = 10;                           //y lo podemos "cargar" de valores
            //lo que es lo mismo que hacer directamente...
            // Asignar valores a los arrays unidimensionales  
            ((int[])objdeArrays[0])[0] = 10;
            ((int[])objdeArrays[1])[1] = 20;
            // Asignar valores al array bidimensional
            ((int[,])objdeArrays[2])[0, 0] = 30;
            ((int[,])objdeArrays[2])[1, 1] = 40;
            Console.WriteLine("Valor: " + ((int[])objdeArrays[1])[5]); //Y accedemos...
            Console.WriteLine("Valor: " + ((int[,])objdeArrays[2])[1, 1]); //Y accedemos...
        }
        static void Main(string[] args)
        {

        }
    }


}
