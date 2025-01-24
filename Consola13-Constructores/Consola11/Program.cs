using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola11
{
    class miClase
    {
        public miClase()                    //constructor con mismo nombre que la clase
        {
            Console.WriteLine("Esto es una instancia automática del método");
        }
        int resultado;
        public miClase(int x)               //constructor con mismo nombre y parámetros
        {
            resultado = x * x;
            Console.WriteLine("Resultado de instancia automática: {0}", resultado);
        }
        public miClase(miClase refObjeto)   //constructor que copia objetos
        {
            resultado = refObjeto.resultado;//copia para sí el valor de “resultado” de objeto
            Console.WriteLine("Resultado de copia: {0}", resultado);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();       //al crear objeto se instancia constructor 
            miClase Objeto2 = new miClase(20);      //se instancia constructor con parámetros
            miClase Objeto3 = new miClase(Objeto2); //se pasa por parámetro de referencia Objeto2
            Console.ReadKey();
        }
    }
}
