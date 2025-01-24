using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Consola24
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }
    }
    class Lista
    {
        public ArrayList ALpersonas = new ArrayList();  //El ArrayList es de tamaño dinámico,...
        public void AgregaPersona(Persona px)
        {
            ALpersonas.Add(px);
        }
        public void MuestraGrupo()                      //...por eso es facil recorrer sus elementos:
        {
            foreach (Persona p in ALpersonas)
                Console.WriteLine(p.nombre + p.apellido);
        }
    }
    class Array
    {
        public Persona[] arrayP = new Persona[50];      //Mientras que le damos un máximo de 50 elementos al Array...
        int i = 0; 
        public void AgregaPersona(Persona px)
        {
                arrayP[i] = px;                         //...le vamos aumentando el tamaño del indice del elemento...
                i++;
        }
        public void MuestraArray()                      //...y vamos recorriendo hasta llegar al tamaño del indice i
        {
            for (int x = 0; x < i; x++)
                Console.WriteLine(arrayP[x].nombre + arrayP[x].apellido);
        }
        //Esto estaría mal pues foreach quiere iterar en los 50 elementos del array:
        /*
        public void MuestraArray2()
        {
            foreach (Persona p in arrayP)
                Console.WriteLine(p.nombre + p.apellido);
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Braian ", "Blanco");
            Persona p2 = new Persona("Fulano ", "Fulgencio");
            Persona p3 = new Persona("Mengano ", "Mendez");
            Lista l = new Lista();
            l.AgregaPersona(p1);
            l.AgregaPersona(p2);
            l.AgregaPersona(p3);
            l.MuestraGrupo();
            Array a = new Array();
            a.AgregaPersona(p1);
            a.AgregaPersona(p2);
            a.AgregaPersona(p3);
            a.MuestraArray();

            //Tambien disponemos del tipo System.Collections.Generic llamado List<>
            List<int> enteros = new List<int>();
            enteros.Add(1); //Asi agregamos elementos
            enteros.Add(2);
            enteros.Add(3);
            enteros.Add(4);
            enteros.Remove(2);

            for (int i = 0; i<enteros.Count; i++)
            {
                Console.WriteLine("Elemento de la lista: " + enteros[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
