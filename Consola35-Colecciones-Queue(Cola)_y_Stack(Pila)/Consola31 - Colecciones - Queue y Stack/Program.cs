using System;
using System.Collections;

namespace Consola31___Colecciones___Queue_y_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //implementacion de la clase Queue
            Queue miCola = new Queue();
            miCola.Enqueue(1);
            miCola.Enqueue(2);
            miCola.Enqueue(3);
            miCola.Enqueue(4);

            Console.WriteLine("Los elementos de la cola son: ");
            foreach(int i in miCola)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Ahora los elementos son: " + miCola.Count);
            Console.WriteLine("Los eliminamos en el orden: ");

            while (miCola.Count > 0)
            {
                //Los mostramos a medida que los eliminamos
                Console.WriteLine(miCola.Dequeue());
            }
            Console.WriteLine("Ahora los elementos son: " + miCola.Count);

            //implementación de la clase Stack
            Stack miPila = new Stack();
            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);
            miPila.Push(4);

            Console.WriteLine("Los elementos de la pila son: ");
            foreach (int i in miPila)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Ahora los elementos son: " + miPila.Count);
            Console.WriteLine("Los eliminamos en el orden: ");

            while(miPila.Count > 0)
            {
                Console.WriteLine(miPila.Pop());
            }
            Console.WriteLine("Ahora los elementos son: " + miPila.Count);
            Console.ReadKey();
        }
    }
}
