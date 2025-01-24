using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola41___Código_no_Gestionado___Unsafe_Code_Fixed
{
    class Foo
    {
        public int x;
    }
    class Program
    {
        unsafe static void SetFooValue(int* x)
        {
            Console.WriteLine("Usando la referencia del puntero para modificar foo.x");
            *x = 42; 
        }
        unsafe static void Main(string[] args)
        {
            //Crea una instancia de la estructura
            Console.WriteLine("Creando el objeto de clase Foo");
            Foo foo = new Foo();

            Console.WriteLine("foo.x inicializado con el valor {0}", foo.x);

            //La instrucción Fixed marca el objeto foo hasta que la instrucción entre llaves termine
            Console.WriteLine("Asignando un puntero a foo.x");
            //Asigna la dirección del objeto foo a Foo*
            fixed (int* f = &foo.x)
            {
                Console.WriteLine("Llamando a SetFooValue pasando un puntero a foo.x");
                SetFooValue(f);
            }
            //Mostramos que realmente cambiamos el valor del miembro vía su puntero
            Console.WriteLine("Despues de volver de SetFooValue, foo.x = {0}", foo.x);
            Console.ReadKey();
        }
    }
}
