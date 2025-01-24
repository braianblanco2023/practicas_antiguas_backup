using System;
using System.Threading;

namespace Consola50___Threads_Manejo
{
    //NO EJECUTAR ESTE CODIGO YA QUE SUSPEND Y RESUME SON AHORA OBSOLETOS
    class Program
    {
        //Creamos dos thread con nombre, pero seran estaticos para poder llamarlos desde otro metodo
        static Thread miHilo1 = null;
        static Thread miHilo2 = null;
        static void Main(string[] args)
        {
            miHilo1 = new Thread(new ThreadStart(metodo1));
            miHilo1.Name = "Hilo 1";
            miHilo2 = new Thread(new ThreadStart(metodo2));
            miHilo2.Name = "Hilo 2";
            //lanzaremos el hilo 1 que correra hasta la mitad su método, se suspenderá hasta para que el segundo hilo arranque
            //luego volverá a hilo1 a terminar su método (a recorrer su iteracion)
            miHilo1.Start();
            miHilo2.Start();
            Console.ReadKey();
        }

        public static void metodo1()
        {
            Console.WriteLine("Soy el Thread " + Thread.CurrentThread.Name.ToString());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hilo {0}: {1}", Thread.CurrentThread.Name.ToString(), i);
                if (i == 5) 
                {
                    Thread.CurrentThread.Suspend();
                }
            }
        }

        public static void metodo2()
        {
            Console.WriteLine("Soy el Thread " + Thread.CurrentThread.Name.ToString());
            string[] vocales = { "a", "e", "i", "o", "u"};
            foreach (string s in vocales)
            {
                Console.WriteLine("Hilo {0}: {1}", Thread.CurrentThread.Name.ToString(), s);
            }
            miHilo1.Resume();
        }
	/*Cuando queremos que un hilo tome prioridad y corra hasta finalizarse para luego 
	retormar el hilo anterior, usamos nombreHilo.Join() para el hilo que quiere tomar
	prioridad, incluso pudiendo pasarle como parámetro los milisegundos*/
    }
}
