using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola8
{
    class miClase
    {
        public int numero;                                    //método que retorna un valor
        public int Duplicar1()
        {
            return numero + numero;
        }

        public void Duplicar2(int x)                        //método que recibe parámetros
        {
            int numero2 = x + x;
            Console.WriteLine(numero2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();

            miObjeto.numero = 50;
            Console.WriteLine(miObjeto.Duplicar1());

            miObjeto.Duplicar2(50);
            Console.ReadKey();
        }
    }
}
