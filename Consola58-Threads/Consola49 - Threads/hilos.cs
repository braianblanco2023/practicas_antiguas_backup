using System;
using System.Threading;

public class Program
{
    // Inicializamos el semáforo para permitir un máximo de 3 hilos simultáneamente
    private static Semaphore semaphore = new Semaphore(3, 3);

    public static void AccessResource(object id)
    {
        Console.WriteLine($"Hilo {id} está esperando para entrar...");

        // Intentamos entrar en la sección crítica
        semaphore.WaitOne();
        Console.WriteLine($"Hilo {id} ha entrado en la sección crítica.");

        // Simulamos una operación que lleva tiempo
        Thread.Sleep(2000);  

        // Salimos de la sección crítica y liberamos el semáforo
        Console.WriteLine($"Hilo {id} está saliendo de la sección crítica.");
        semaphore.Release();
    }

    public static void Main()
    {
        // Creamos varios hilos que intentarán acceder al recurso compartido
        for (int i = 1; i <= 10; i++)
        {
            Thread thread = new Thread(AccessResource);
            thread.Start(i);
        }
    }
}
