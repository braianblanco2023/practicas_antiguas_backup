using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola10
{
    class miClase
    {
        public void SenoCoseno(double numero, out double seno, out double coseno)
        {
            seno = Math.Sin(numero);            //funcion que calcula el seno
            coseno = Math.Cos(numero);          //funcion que calcula el coseno
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();
            
            double miNumero;                    //creación de variables a utilizar
            double miSeno;
            double miCoseno;
            
            Console.Write("Calcular Seno y Coseno de: ");
            miNumero = Convert.ToDouble(Console.ReadLine());
            
            miObjeto.SenoCoseno(miNumero, out miSeno, out miCoseno);    //uso de método
            
            Console.WriteLine("Seno: {0} \nCoseno: {1}", miSeno, miCoseno);
            Console.ReadKey();
        }
    }
}
