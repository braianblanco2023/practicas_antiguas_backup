using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola29
{
    public delegate void MiDelegado(int num);
    class MiClase
    {
        public void MiMetodo1(int n1)
        {
            Console.WriteLine("Número en Metodo1: " + n1);
        }
        public void MiMetodo2(int n2)
        {
            Console.WriteLine("Número en Metodo2: " + n2);
        }
        public void MiMetodo3(int n3)
        {
            Console.WriteLine("Número en Metodo3: " + n3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MiClase objMiClase = new MiClase();                                 //Se crea objeto de la clase
            MiDelegado objMiDelegado = new MiDelegado(objMiClase.MiMetodo1);    //Se crea delegado y...
            objMiDelegado += objMiClase.MiMetodo2;                              //...se le asocian los métodos
            objMiDelegado += objMiClase.MiMetodo3;
            //Finalmente le pasamos el parámetro al Delegado
            Console.WriteLine("Resultados del Delegado 1:");
            objMiDelegado(6);

            /*También, un delegado puede implementar un método anónimo, que por no tener nombre, lo
            definimos al crear una instancia del mismo delegado, de modo que nos aporta la funcionalidad
            de poder ejecutar más código*/
            MiDelegado objMiDelegado2 = delegate (int i) {
                Console.WriteLine("Número en Método anónimo: {0}", i);
            };
            //Solo luego de definir el método anónimo se le puede pasar un llamado a un método
            objMiDelegado2 += objMiClase.MiMetodo1;
            Console.WriteLine("Resultados del Delegado 2 con método anónimo:");
            objMiDelegado2(10);
            //e incluso un delegado puede contener otro delegado
            objMiDelegado2 += objMiDelegado;
            Console.WriteLine("Resultados del Delegado 2 conteniendo Delegado 1");
            objMiDelegado2(20);
            Console.ReadKey();
        }
    }
}
