using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Consola27
{	//HASHTABLE
    public class Mes
    {
        public Hashtable ht = new Hashtable(31);    //creacion del diccionario
        public void Meses()
        {
            ht.Add("Enero", 31);
            ht.Add("Febrero", 28);
            ht.Add("Marzo", 31);
            ht.Add("Abril", 30);
            ht.Add("Junio", 30);
            ht.Add("Julio", 31);
            ht.Add("Agosto", 31);
            ht.Add("Septiembre", 30);
            ht.Add("Octubre", 31);
            ht.Add("Noviembre", 30);
            ht.Add("Diciembre", 31);
        }
        public void ConsultaDias(string mes)
        {
            Console.WriteLine("El mes de {0} tiene {1} dias", mes, ht[mes]);
        }
    }
	//SORTED LIST
    public class Ordenado
    {
        public SortedList sl = new SortedList();
        public void cargaLista()
        {
            //Vamos a agregar desordenadamente para dejar trabajar al SortedList
            sl.Add(5, "Viernes");
            sl.Add(2, "Martes");
            sl.Add(4, "Jueves");
            sl.Add(1, "Lunes");
            sl.Add(3, "Miércoles");
        }
        public void ListaOrdenada()
        {
            foreach(object clave in sl.Keys)
            {
                Console.WriteLine("{0} - {1}", clave.ToString(), sl[clave].ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mes Consulta = new Mes();
            Consulta.Meses();
            Console.WriteLine("Aquí dejamos el resultado de la búsqueda por índice en Hashtable");
            Consulta.ConsultaDias("Enero");

            Ordenado Consulta2 = new Ordenado();
            Consulta2.cargaLista();
            Console.WriteLine("Aquí dejamos la lista ordenada automáticamente con SortedList");
            Consulta2.ListaOrdenada();
            
            Console.ReadKey();
        }
    }
	//OTRAS COLECCIONES
    public class OtrasColecciones
    {
        public void Hashsets()          //para conjunto de elementos irrepetibles
        {
            HashSet<int> conjunto = new HashSet<int> { 1, 2, 3, 4, 5 }; //en este caso de enteros
            conjunto.Add(5); // No se añadirá, porque ya existe
            Console.WriteLine(conjunto.Contains(3)); // Muestra: True y se accede por el valor en concreto
        }
        public void DiccionarioConcurrente()
        {
            var diccionarioConcurrente = new ConcurrentDictionary<string, int>();
            diccionarioConcurrente.TryAdd("clave1", 1);
            diccionarioConcurrente["clave1"] = 2;
            Console.WriteLine(diccionarioConcurrente["clave1"]); // Muestra: 2

        }
    }
}
