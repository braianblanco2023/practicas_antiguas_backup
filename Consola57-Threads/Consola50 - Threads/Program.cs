using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consola50___Threads
{ 
    //NO EJECUTAR ESTE CODIGO YA QUE SUSPEND Y RESUME SON AHORA OBSOLETOS
    class Program
    {       
        static void Main(string[] args)
        {
            //Los hilos se crean invocando un ThreadStart que es un inicializador como delegado apuntando
            //al metodo a llamar, y luego un hilo con Thread que se le pasa la referencia a ThreadStart
            /*
            ThreadStart reflejo = new ThreadStart(metodo1);
            Thread hijo3 = new Thread(reflejo);
            */
            //Pero preferimos resumirlo en...
            Thread miHilo1 = new Thread(new ThreadStart(metodo1));
            miHilo1.Name = "Hilo 1";        //luego le damos nombre
            Thread miHilo2 = new Thread(new ThreadStart(metodo2));
            miHilo2.Name = "Hilo 2";
            //lanzaremos el hilo 1 que correra hasta la mitad su método, y se suspenderá, pero tardará entre
            //lapsos de iteracion, por lo que se mesclará la ejecucion de los dos hilos
            miHilo1.Start();
            miHilo2.Start();
            Console.ReadKey();
        }
        public static void metodo1()
        {
            Console.WriteLine("Soy el Thread " + Thread.CurrentThread.Name.ToString());
            for (int i = 0; i < 10; i++)
            {   //lanzaremos el WriteLine del bucle cada 2 segundos
                Console.WriteLine("Hilo {0}: {1}", Thread.CurrentThread.Name.ToString(), i);
                Thread.Sleep(2000); //en milisegundos
                if (i == 5)         //paramos en 5 en la iteracion
                {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                   Thread.CurrentThread.Suspend();                  
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                }
            }
        }
        public static void metodo2()
        {
            Console.WriteLine("Soy el Thread " + Thread.CurrentThread.Name.ToString());
            string[] vocales = { "a", "e", "i", "o", "u" };
            foreach (string s in vocales)
            {
                Console.WriteLine("Hilo {0}: {1}", Thread.CurrentThread.Name.ToString(), s);
            }
        }
        /*Cuando queremos que un hilo tome prioridad y corra hasta finalizarse para luego 
        retormar el hilo anterior, usamos nombreHilo.Join() para el hilo que quiere tomar
        prioridad, incluso pudiendo pasarle como parámetro los milisegundos*/
    }
}