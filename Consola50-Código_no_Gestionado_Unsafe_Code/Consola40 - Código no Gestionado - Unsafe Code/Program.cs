using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola40___Código_no_Gestionado___Unsafe_Code
{
    //NO ejecutar directamente este código, compilarlo como /unsafe primero.
    //El resultante será Program.exe que se encuentra en la misma carpeta que Program.cs
    class Program
    {
        public static unsafe void GetValues(int* x, int* y)
        {
            *x = 6;
            *y = 42;
        }
        static unsafe void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("Antes de llamar a GetValues() : a ={0}, b ={1}", a, b);
            GetValues(&a, &b);
            Console.WriteLine("Despues de llamar a GetValues() : a ={0}, b ={1}", a, b);
            Console.ReadKey();
        }
    }
}
