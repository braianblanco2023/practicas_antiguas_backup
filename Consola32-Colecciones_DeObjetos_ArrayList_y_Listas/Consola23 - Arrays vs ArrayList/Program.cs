using System;
using System.Collections.Generic; //Para utilizar List
using System.Linq;
using System.Text;
using System.Collections;   //Para utilizar un ArrayList se agregó esta linea

namespace Consola23
{
    class Persona
    {
        public string nombre;
        public Persona(string unNombre) //constructor para insertar nombre a la persona creada
        {
            nombre = unNombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {//Diferencia entre Array(tamaño fijo) con ArrayList (tamaño dinámico):

            //COMENZAMOS POR EL USO DE ARRAY DE OBJETOS

            Persona miPersona1 = new Persona("Braian");
            Persona miPersona2 = new Persona("Cynthia");
            Persona[] arrayPersonas = new Persona[2];    //Array de Objetos
            arrayPersonas[0] = miPersona1;
            arrayPersonas[1] = miPersona2;
            Console.WriteLine("Objetos encontrados en coleccion ArrayPersonas");
            foreach (Persona p in arrayPersonas)
            {
                Console.WriteLine(p.nombre);
            }

            //AHORA UTILIZAREMOS UN ARRAYLIST DE OBJETOS

            Persona miPersona3 = new Persona("Sofia");
            Persona miPersona4 = new Persona("Ambar");
            ArrayList arrayListPersonas = new ArrayList();  //ArrayList de Objetos
            arrayListPersonas.Add(miPersona3);
            arrayListPersonas.Add(miPersona4);
            //Incluso agregamos el Array anterior a nuestro ArrayList
            arrayListPersonas.AddRange(arrayPersonas);
            //Recorremos con bucle Foreach
            Console.WriteLine("Objetos encontrados en coleccion ArrayListPersona");
            foreach (Persona p in arrayListPersonas)
            {
                Console.WriteLine(p.nombre);
            }
	//lo cual es los mismo pero mas simple que utilizar el bucle For:
            for (int i = 0; i < arrayListPersonas.Count; i++)
            {
                Console.WriteLine(((Persona)arrayListPersonas[i]).nombre);  //requiere la conversion a Persona
            }
            //Para obtener el indice de un objeto en el arrayLlist, usamos su método IndexOf():
            Console.Write("{0} esta en el indice: ", miPersona1.nombre);
            Console.WriteLine(arrayListPersonas.IndexOf(miPersona1));

            //Y Finalmente, se pueden eliminar los elementos de los siguientes modos:
            arrayListPersonas.Remove(miPersona3);   //...pasando el objeto
            arrayListPersonas.RemoveAt(2);          //...o el índice entre paréntesis
            //NOTA: recordar que al eliminar un elemento, el siguiente ocupará su lugar en ese indice

            //También podemos recorrer el ArrayList con bucle For usando Count:
            Console.WriteLine("Objetos en coleccion ArrayListPersona con For");
            for (int i = 0; i < arrayListPersonas.Count; i++)
            {   //Aunque nótese que debemos convertir a Persona de nuevo cada elemento
                Console.WriteLine(((Persona)arrayListPersonas[i]).nombre);
            }

            //Y POR ÚLTIMO USAREMOS UN LIST<>
            //Podemos crear así directamente los elementos
            IList<string> cadenas = new List<string>() { "Uno", "Dos", "Tres" };
            cadenas.Add("Cuatro");  //O podemos agregar con Add() 
            cadenas.Add("Cinco");
            cadenas.Add("Seis");
            List<int> enteros = new List<int>() { 1,2,3 };
            //También podemos crear List a la que agregarle otro List en el rango final de su lista:
            //Primeros creamos otra List...
            IList<int> enteros2 = new List<int>();
            enteros2.Add(4);     
            enteros2.Add(5);
            enteros2.Add(6);
            //Primero revisamos...
            Console.WriteLine("Ahora List<> enteros contiene: ");
            foreach (int i in enteros)
            {
                Console.WriteLine("Valor: " + i.ToString());
            }
            //...luego le agregamos como un nuevo rango (pero AddRange solo lo implementa List, no IList)
            enteros.AddRange(enteros2);
            Console.WriteLine("Agregamos un rango nuevo... List<> enteros2");
            Console.WriteLine("Ahora List<> enteros contiene: ");
            foreach (int i in enteros)
            {
                Console.WriteLine("Valor: " + i.ToString());
            }
            //tambien podemos hacer un Insert en una posicion específica:
            enteros.Insert(0, 9);   //esto es: en la posicion 0 agregamos el valor 9
            //revisamos con for para variar
            Console.WriteLine("Hay valores agregados que desplazaron los existentes");
            for (int i = 0; i< enteros.Count(); i++)
            {
                if (enteros[i] == 9)    //me avisa del cambio realizado
                {
                    Console.Write("Esto es nuevo: ");
                }
                Console.WriteLine("Valor: " + enteros[i].ToString());
            }
            //Luego eliminamos (de dos modos):
            //Con Remove() eliminamos el valor especificado
            enteros.Remove(9);      //Eliminará 9 en la posición 0
            //Con RemoveAt() eliminamos el valor según el índice especificado
            enteros.RemoveAt(3);    //Eliminará la posición 3 que ahora sin 9, la ocupa 4
            Console.WriteLine("Finalmente quedaron: ");
            foreach (int i in enteros)
            {
                Console.WriteLine("Valor: " + i.ToString());
            }
            //y con RemoveAll quitamos todo
            Console.ReadKey();
        }
    }
}
