using System;
using System.Threading;         //Usaremos esta clase para manejar varios hilos

namespace Consola49___Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Le damos nombre al hilo principal para distinguirlo de nuestro hilo
            Thread.CurrentThread.Name = "Principal";
            //Se crea un nuevo hilo
            Thread miHilo = new Thread(new ThreadStart(miProceso)); //llamada al proceso por delegado ThreadStart
            //Le damos nombre al nuevo hilo
            miHilo.Name = "Nuevo Hilo";
            miHilo.Start();         //se lanza el hilo
            miProceso();            //llamada al proceso por el hilo principal (en Main)
            Console.ReadKey(); 
        }
        public static void miProceso()
        {
            Console.WriteLine("Ejecución del hilo " + Thread.CurrentThread.Name.ToString());
            for (int i = 1; i < 1000; i++)
            {
                Console.WriteLine("Iteracion {0} del hilo {1}", i, Thread.CurrentThread.Name.ToString());
            }
        }
        //Como se observa, los threads se lanzan con un tiempo (miliseg) repartido de modo intercalado 
        //por eso veremos en la ejecucion iteraciones de un hilo y otro intercalados (simulando ejecuciones simultaneas)
        //y no un hilo despues del otro
    }
}
