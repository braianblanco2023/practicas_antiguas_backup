using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola15
{
    class miClase
    {
        protected int valor;
        public int Valor        //el nombre similar no es algo arbitrario
        {
            get //Lectura
            {
                Console.WriteLine("Esto hace al leer la variable con valor {0}", valor);
                return valor;   //return retorna el valor (permite leer) ahora 0
            }
            set //Asignación
            {
                valor = value;  //value oficiará de parámetro de entrada
                Console.WriteLine("Esto hace al escribir la variable con valor {0}", valor);
            }
        }
    }
	/*De hecho, la diferencia entre usar un campo (ejemplo: int i;) de propiedades (con get y set), es que
	estos tienen la ventaja de poder definir un código, sea en su implementacion base o en las clases derivadas*/
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();
            Console.WriteLine(miObjeto.Valor);  //esta lectura desencadena Get
            miObjeto.Valor = 50;                //esta escritura desencadena Set
            Console.WriteLine(miObjeto.Valor);  //Aquí vemos la modificacion hecha
            Console.ReadKey();
        }
    }
}
