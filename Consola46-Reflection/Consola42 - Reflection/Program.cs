using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;        //USAMOS ESTE NAMESPACE PARA LA REFLECCION

namespace Consola42___Reflection
{
    public class Ejemplo1
    {
        protected static string GetAssemblyName(string[] args)
        {
            string assemblyName;
            if (0 == args.Length)
            {
                Process p = Process.GetCurrentProcess();
                assemblyName = p.ProcessName + ".exe";
            }
            else
            {
                assemblyName = args[0];
            }
            return assemblyName;
        }
        public static void Main(string[] args)
        {

            /*Vamos ahora a acceder a tipos de otra solucion, pero sin invocar el archivo, sin importar 
             * la libreria desde using, sino desde el ensamblado (exe's o dll's) creado de su compilacion*/
            //HEMOS CREADO OTRA CLASE .DLL COMO BIBLIOTECA DE CLASE, PARA CREAR UNA INSTANCIA DE UNA CLASE EN ELLA
            //cargamos la dll del ensamblaje (usamos LoadFile)
            Assembly miEnsamblaje = Assembly.LoadFile(@"G:/Programacion - Practicas/Projects/Consola42 - Reflection/Calculadora/bin/Debug/netstandard2.0/Calculadora.dll");
            //obtenemos el tipo de la clase dentro del ensamblaje
            Type tipo = miEnsamblaje.GetType("Calculadora.Class1");
            //luego activamos esta instancia con Activator sobre el tipo
            object instancia = Activator.CreateInstance(tipo);  //este hace la magia de la Reflexion
            //ahora disponemos de la instancia de un tipo (una referencia a un objeto) sin 'importarla'
            Type miTipo = instancia.GetType();      //y ahora si obtenemos nuestro objeto 
            //Ahora podemos recorrer sus miembros (por ejemplo)
            foreach (MemberInfo objeto in miTipo.GetMembers())
            {
                Console.WriteLine(objeto.Name);
            }
            
            Console.ReadKey();
        }
    }
}