using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola19
{
/*
    class A
    {
        public void MetodoA()               //metodo para objetos A
        {
            Console.WriteLine("Metodo de clase A");
        }
    }
    class B
    {
        public A objetoA = new A();         //objeto derivado de otra clase, dentro de una clase
    }
    class Program
    {
        static void Main(string[] args)
        {
            B objetoB = new B();
            objetoB.objetoA.MetodoA();      //objetoB hereda objetoA, heredando su metodo MetodoA() 
            Console.ReadKey();
        }
    }
*/
//Ejemplo mejorado de composicion:
	class A
	{		|				
	    public void MetodoA()
	    {
	        Console.WriteLine("Metodo de clase A");
	    }
	}

	class B
	{
	    private A objetoA = new A(); // Encapsula el objeto A

	    public void MetodoA()
	    {
	        objetoA.MetodoA(); // Proporciona acceso al método de A
	    }
	}

	class Program
	{
	    static void Main(string[] args)
	    {
	        B objetoB = new B();
	        objetoB.MetodoA(); // Ahora accedemos al método de A a través de B
	        Console.ReadKey();
	    }
	}
}
