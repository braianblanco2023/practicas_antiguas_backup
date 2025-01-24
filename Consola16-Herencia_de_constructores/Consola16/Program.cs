using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola16
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
    }
    class C : B
    {
        public C()      //constructor
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
