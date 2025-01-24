using System;
using System.Reflection;

namespace Consola43___Reflection_en_Objetos
{
    class Clientes
    {
        public string Nombre { set; get; }
        public int DNI { set; get; }
        public int Telefono { set; get; }
        public string Email { set; get; }
    }
    class Program
    {
        public static object comparaClientes(object clienteA, object clienteB)
        {
            //debemos crear una instancia de uno de los dos tipos a comparar (para retornar el mismo tipo
            object miCliente = Activator.CreateInstance(clienteA.GetType());
            //ahora para continuar comprobamos si los dos tipos a comprar son del mismo tipo
            if (clienteA.GetType() != clienteB.GetType())
            {
                Console.WriteLine("Está intentando comparar distintos tipos");
            }
            else
            {   //por cada propiedad entre las propiedades del tipo (de la clase Cliente)
                foreach(PropertyInfo p in clienteA.GetType().GetProperties())
                {
                    //pasamos a las propiedades (segun sus nombres) sus valores a dos objetos tipo A y B creados
                    //de los objetos pasados por parametro A y B respectivamente
                    object miClienteA = clienteA.GetType().GetProperty(p.Name).GetValue(clienteA);
                    object miClienteB = clienteB.GetType().GetProperty(p.Name).GetValue(clienteB);
                    //ahora hacemos la comparacion y guardamos la fusion en un nuevo objeto
                    //decimos si la propiedad de A es nula o esta vacia le pasamos la propiedad de B, sino de A
                    object miclienteAB = 
                    //y luego le damos todos los valores de miclienteAB a miCliente mediante un setValue()
                        (miClienteA == null || miClienteA.ToString() == "" ? miClienteB : miClienteA);
                    miCliente.GetType().GetProperty(p.Name).SetValue(miCliente, miclienteAB);
                }
            }
            return miCliente;
        }

        static void Main(string[] args)
        {
            Clientes cliente1 = new Clientes()
            {
                Nombre = "Braian",
                DNI = 43249057,
                Telefono = 123456789
            };
            Clientes cliente2 = new Clientes()
            {
                Nombre = "Braian Blanco",
                DNI = 43249057,
                Email = "soam@gmail.com"
            };
            Object clienteCompleto = new Clientes();

            //le pasamos dos objetos que pueden representar a los bases de datos, archivos a clases, etc
            clienteCompleto = comparaClientes(cliente1, cliente2);
            foreach (PropertyInfo p in clienteCompleto.GetType().GetProperties())
            {
                Console.WriteLine(p.Name + ": " + p.GetValue(clienteCompleto));
            }
            Console.ReadKey();
        }
    }
}
