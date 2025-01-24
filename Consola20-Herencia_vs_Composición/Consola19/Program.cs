using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola19
{
    class A
    {
        public void MetodoA()               //metodo para objetos A
        {
            Console.WriteLine("Metodo de clase A");
        }
    }
    class B                                 //Clase COMPUESTA por un Objeto DE OTRA Clase
    {
        public A objetoA = new A();         //objeto derivado de otra clase, dentro de una clase
    }
    class Program
    {
        static void Main(string[] args)
        {
            B objetoB = new B();
            objetoB.objetoA.MetodoA();      //objetoB se compone por un objetoA, que contiene MetodoA()
            Console.ReadKey();
        }
    }
}
