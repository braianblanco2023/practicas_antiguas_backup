using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola9
{
    class miClase
    {
        public void MetodoPorCopia(int valor1)              //Pasaje de valor por copia
        {
            valor1 = 100;                                        //se pretende reasignar valor a 100
            Console.WriteLine("Dentro del método por copia vale: " + valor1);
        }
        public void MetodoPorReferencia(ref int valor1)     //Pasaje de valor por referencia
        {
            valor1 = 100;                                        //se pretende reasignar valor a 100
            Console.WriteLine("Dentro del método por referencia vale: " + valor1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();
            int valor2 = 200;                               //valor primario a pasar por copia
            int valor3 = 200;                               //valor primario a pasar por referencia

            miObjeto.MetodoPorCopia(valor2);                //instancia del método por copia 
            Console.Write("Fuera del método por copia vale: ");
            Console.WriteLine(valor2);

            miObjeto.MetodoPorReferencia(ref valor3);       //instancia del método por referencia
            Console.Write("Fuera del método por referencia vale: ");
            Console.WriteLine(valor3);            
            
            Console.ReadKey();
        }
    }
}
