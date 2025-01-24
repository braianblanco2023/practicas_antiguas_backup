using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola17
{
    class A
    {
        public A()      //constructor
        {
            Console.WriteLine("Constructor A");
        }
    }
    class B : A
    {
        public B()      //constructor
        {
            Console.WriteLine("Constructor B");
        }
        public B(int a) //constructor con parámetro
        {
            Console.WriteLine("Salteo a Constructor B con parámetro");
        }
    }
    class C : B
    {
        public C() : base(1)
        {
            Console.WriteLine("Constructor C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C miObjetoC = new C();      //miObjetoC hereda y desencadena los 3 constructores
            Console.ReadKey();
        }
    }
}
