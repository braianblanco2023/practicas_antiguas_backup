using System;
using System.IO;

namespace Consola46___Buscar_en_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            string linea;                       //esto captura la linea entera leida
            string[] dato = new string[2];      //este Array guardará los 2 datos por separado en el array (alumno y nota)
            char separador = ',';               //Este caracter separador de coma solo se usará como parámetro para Split
            bool encontrado = false;            //este booleano establece si hallamos o no lo buscado
            string alumno, nota;                //variables que alojan al alumno buscado y su nota hallada

            //Capturamos el nombre solicitado
            Console.WriteLine("Ingrese el nombre de un alumno a mostrar sus calificaciones: ");
            alumno = Console.ReadLine();
            //Se abre el archivo de calificaciones
            StreamReader sr = File.OpenText(@"F:\Programacion - Practicas\Projects\Consola46 - Buscar_en_Archivos\Consola46 - Buscar_en_Archivos\calificaciones.txt");
            //para buscar en él capturando la primer línea, luego en while las demás
            linea = sr.ReadLine();
            while (linea!= null && encontrado == false) //mientras halla algo en la linea y no hallemos aun lo buscado
            {
                dato = linea.Split(separador);  //Split divide cada línea a partir del caracter indicado por parametro
                if(dato[0].Trim() == alumno)    //Si el dato sin espacios en blanco (Trim) es igual al alumno buscado...
                {
                    nota = dato[1].Trim();      //guardamos la nota sin espacios
                    Console.WriteLine("El alumno {0} tiene la calificacion {1}", alumno, nota);      //se muestra el dato
                    encontrado = true;          //se halló lo buscado por tanto se sale del bucle while
                }
                else
                {
                    linea = sr.ReadLine();      //Si no lo hallamos en esa línea continuamos leyendo y se repite el bucle
                }
            }
            if (linea == null)                  //si no hay mas lineas donde buscar y no se halló se avisa
            {                                   //o bien podría decirse if(encontrado == false)
                Console.WriteLine("No se halló el alumno");
            }
            Console.ReadKey();
        }
    }
}
