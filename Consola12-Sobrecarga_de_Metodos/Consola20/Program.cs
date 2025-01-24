using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola20
{
    class Sobrecarga
    {
        public void Imprimir(int num)
        {
            Console.WriteLine("Imprime el entero: {0}", num);
        }
        public void Imprimir(double num)
        {
            Console.WriteLine("Imprime el doble: {0}", num);
        }
        public void Imprimir(string num)
        {
            Console.WriteLine("Imprime la cadena: {0}", num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sobrecarga miObjeto = new Sobrecarga();
            miObjeto.Imprimir(1);           //se pasa un int
            miObjeto.Imprimir(1.0);         //se pasa un double
            miObjeto.Imprimir("a");         //se pasa un string
            Console.ReadKey();
        }
    }
}
