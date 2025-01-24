using System;
using System.Collections.Generic;


namespace Consola35___Colecciones___Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------ASÍ ACCEDEMOS A LOS DICCIONARIOS Y LAS TUPLAS----------

            //Pdemos crear un DICCIONARIO y pasarle los elementos en una misma instrucción
            IDictionary<int, string> miDiccio1 = new Dictionary<int, string>()  //(parentesis y llaves)
            {
                {1, "Uno"},
                {2, "Dos"},
                {3, "Tercero"}
            };
            //O bien podemos crear un diccionario
            IDictionary<int, string> miDiccio2 = new Dictionary<int, string>();
            //y luego agregar asi los elementos...
            miDiccio2.Add(1, "Primero");
            miDiccio2.Add(2, "Segundo");
            miDiccio2.Add(3, "Tercero");
            //Como se ve se puede agregar cuantos elementos con sus varios Items querramos

            //Solo creamos una TUPLA al pasarle los items del elemento en la misma instrucción (parentesis)
            Tuple<int, string, string> miTupla1 = new Tuple<int, string, string>(30, "Braian", "Blanco");
            //Como se ve se puede agregar solo los Items (maximo 8) para un unico elemento (una Tupla)

            //El beneficio del uso de Tuplas radica en que disponemos de un tipo de Tupla estatico, al cual
            //no necesitamos detallarle el tipo ni la cantidad de items que llevará. Así se crea:
            var miTupla2 = Tuple.Create(1, "Braian", "Blanco", 1566278518);
            //Ademas podemos anidar una Tupla a otra (se recomienda al final (elemento 8)) de la Tupla 
            var numeros = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            //siendo el 8vo elemento una nueva tupla con mas elementos
            
            //----------ASÍ ACCEDEMOS A LOS DICCIONARIOS Y LAS TUPLAS----------

            //Accedemos a una TUPLA 
            Console.WriteLine("ACCEDIENDO A UNA TUPLA");
            Console.WriteLine(miTupla2.Item1);
            Console.WriteLine(miTupla2.Item2);
            Console.WriteLine(miTupla2.Item3);
            Console.WriteLine(miTupla2.Item4);
            //Como se ve no se puede usar un bucle foreach para una tupla, pues no es Enumerable

            //Acedemos a una TUPLA Anidada
            Console.WriteLine("ACCEDIENDO A UNA TUPLA Anidada");
            Console.WriteLine(numeros.Item1); // devuelve 1
            Console.WriteLine(numeros.Item7); // devuelve 7
            Console.WriteLine(numeros.Rest.Item1); // devuelve (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numeros.Rest.Item1.Item1); // devuelve 8
            Console.WriteLine(numeros.Rest.Item1.Item2); // devuelve 9
            //Como se ve en el Iem8 llamaremos a la Tupla entera anidada, y lo hacemos con "Rest", que
            //indica al 8vo elemento

            //Accedemos a un DICCIONARIO cpm ForEach
            Console.WriteLine("ACCEDIENDO A UN DICCIONARIO");
            Console.WriteLine("Recorrido con ForEach");
            foreach (KeyValuePair<int, string> elemento in miDiccio2)
            {
                //donde mostramos cada Clave y su Valor
                Console.WriteLine("Clave: {0} - Valor: {1}", elemento.Key, elemento.Value);
            }
            Console.WriteLine("Recorrido con un indexador como si fuere matriz");
            //ACCEDEMOS con For (iniciamos 'i' en 1 porque sabemos que es la primer clave)
            for (int i = 1; i <= miDiccio2.Count; i++)
            {
                Console.WriteLine("Clave: {0} - Valor: {1}", i, miDiccio2[i]);
            }
            Console.WriteLine("Buscamos con un indexador como si fuere matriz");
            Console.WriteLine("La clave 1 tiene valor: " + miDiccio2[1]);


            //Si no conocemos o no estamos seguros si la clave a consultar existe usamos TryGetValue
            string resultado;
            //consultamos por la clave 4
            Console.WriteLine("Buscamos la clave 4");
            if (miDiccio2.TryGetValue(4, out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("No se ha podido encontrar la Clave especificada");
            }

            //Podemos comprobar con Boolean mediante Contains, ContainsKey o ContainsValue
            Console.WriteLine("Existe la clave '5'?: {0}", miDiccio2.ContainsKey(5));
            Console.WriteLine("Existe la clave '1' valor 'Primero'?: {0}", miDiccio2.Contains(new KeyValuePair<int, string>(1, "Primero")));

            //Podemos eliminar elementos con Remove('clave') o Remove con KeyValuePair (como Contains)
            Console.ReadKey();

            //ADEMAS DE TODO LO VISTO TAMBIEN SE PUEDE PASAR COMO PARAMETRO DE UN METODO TANTO A UN
            //DICCIONARIO, UNA TUPLA COMO OTRAS COLECCIONES. ASI MISMO RETORNARLOS CON return
	    /* Usaremos Tuplas convenientemente:
		- Cuando necesitemos devolver múltiples valores de un método sin usar los parámetros 
		ref o out.
		- Cuando queremos pasar múltiples valores a un método a través de un solo parámetro.
		- Cuando necesitemos mantener un registro de la base de datos o algunos valores
		temporalmente sin crear una clase separada.*/
        }
    }
}
