using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola18
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
        public B(int a)             //el valor pasado en C(int a) ingresa a esta variable int "a"
        {
            Console.WriteLine("Constructor B con parámetro de valor: {0}", a);
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor C");
        }
        public C(int a) : base(a)  //el valor 50 ingresa en la variable int "a", que pasa a B(int a)     
        {
            Console.WriteLine("Constructor C con parámetro de valor: {0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estos constructores se desencadenan al crear objeto sin parámetro");
            C miObjetoC = new C();      //miObjetoC hereda y desencadena los 3 constructores
            Console.WriteLine("Estos constructores se desencadenan al crear objeto con parámetro");
            C otroObjetoC = new C(50);  //otroObjetoC hereda los constructores con parámetro, que toman el valor
            Console.ReadKey();
        }
    }
}
