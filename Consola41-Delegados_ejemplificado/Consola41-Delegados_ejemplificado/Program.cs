using System;
using System.Collections.Generic;

namespace Consola41_Delegados_ejemplificado
{
    public delegate void ProcesarNumeros(List<int> numeros);

    class OperacionesNumericas
    {
        public void Duplicar(List<int> numeros)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                numeros[i] *= 2;
            }
            Console.WriteLine("Duplicar: " + string.Join(", ", numeros));
        }

        public void Incrementar(List<int> numeros)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                numeros[i] += 1;
            }
            Console.WriteLine("Incrementar: " + string.Join(", ", numeros));
        }

        public void Ordenar(List<int> numeros)
        {
            numeros.Sort();
            Console.WriteLine("Ordenar: " + string.Join(", ", numeros));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 3, 1, 4, 1, 5 };

            OperacionesNumericas operaciones = new OperacionesNumericas();

            // Crear el delegado y asociar los métodos
            ProcesarNumeros procesarNumeros = operaciones.Duplicar;
            procesarNumeros += operaciones.Incrementar;
            procesarNumeros += operaciones.Ordenar;

            // Ejecutar el delegado con la lista de números
            Console.WriteLine("Antes del procesamiento: " + string.Join(", ", numeros));
            procesarNumeros(numeros);
            Console.WriteLine("Después del procesamiento: " + string.Join(", ", numeros));

            Console.ReadKey();
        }
    }
    /* EN ESTE EJEMPLO, SE UTILIZA UN DELEGADO PARA QUE UNA LISTA DE NUMEROS SEA TRATADA POR VARIOS 
    * PROCESOS. ESTOS NOS MUESTRA COMO PODRIAMOS TENER VARIOS DELEGADOS QUE SEGÚN NECESITEMOS, PASEN
    * EL CONJUNTO DE DATOS POR ALGUNO, VARIOS O TODOS LOS METODOS, PARA DIFERENTES TRATAMIENTOS*/
}
