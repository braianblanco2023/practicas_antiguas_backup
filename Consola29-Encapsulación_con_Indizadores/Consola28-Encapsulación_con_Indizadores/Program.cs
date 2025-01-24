using System;
using System.Collections.Generic;

namespace Consola28_Encapsulación_con_Indizadores
{    /*
     * Un indizador permite que una instancia de una clase se comporte como un arreglo, 
     * permitiendo acceder y modificar sus elementos utilizando la sintaxis de corchetes 
     */
    //EJEMPLO SIMPLE utlizando Arrays
    class Indizado
    {
        //en este ejemplo, usamos un arreglo, el cual ya cargaremos con valores por simplicidad
        protected string[] cadena = new string[5] { "A", "B", "C", "D", "F" };

        //Indizador
        public string this[int indice]
        {
            get //Lectura
            {
                return cadena[indice];  //return retorna el valor
            }
            set //Escritura
            {
                cadena[indice] = value; //value es lo recibido
            }
        }
    }
    //EJEMPLO MAS COMPLEJO utilizando Dictionary
    class RegistroDeEstudiantes
    {
        //en este ejemplo, usamos un diccionario vacio, el cual cargaremos luego
        private Dictionary<int, string> estudiantes = new Dictionary<int, string>();

        //Indizador
        public string this[int matricula]
        {
            get
            {
                if (estudiantes.ContainsKey(matricula))
                {
                    return estudiantes[matricula];
                }
                else
                {
                    return "Estudiante no encontrado";
                }
            }
            set
            {
                estudiantes[matricula] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //---------- ANALISIS DE EJEMPLO SIMPLE ----------

            Indizado cadena = new Indizado();

            //Agregamos y accedemos a los valores usando su indice
            Console.WriteLine(cadena[0]);          //esta lectura desencadena Get
            cadena[0] = "Hola";                    //esta escritura desencadena Set
            Console.WriteLine(cadena[0]);          //Aquí vemos la modificacion hecha

            //---------- ANALISIS DE EJEMPLO MAS COMPLEJO ----------

            RegistroDeEstudiantes registro = new RegistroDeEstudiantes();

            // Agregamos algunos estudiantes
            registro[1001] = "Ana Pérez";
            registro[1002] = "Carlos Gómez";
            registro[1003] = "Lucía Martínez";

            // Accedemos a los nombres de los estudiantes usando sus números de matrícula
            Console.WriteLine(registro[1001]); // Imprime "Ana Pérez"
            Console.WriteLine(registro[1002]); // Imprime "Carlos Gómez"
            Console.WriteLine(registro[1004]); // Imprime "Estudiante no encontrado"

            // Modificamos el nombre de un estudiante
            registro[1002] = "Carlos Rodríguez";
            Console.WriteLine(registro[1002]); // Imprime "Carlos Rodríguez"

            Console.ReadKey();
        }
    }

}
