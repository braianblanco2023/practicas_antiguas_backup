using System;
using System.IO;

namespace Consola47___Directorios
{
    class Program
    {
        static void Main(string[] args)
        {
            //El metodo GetDirectories devuelve un arreglo con todas los rutass de las carpetas de la ruta indicada
            string[] carpetas = Directory.GetDirectories(@"G:\Programacion - Manuales\");
            Console.WriteLine("Los directorios hallados son:");
            foreach (string carpeta in carpetas)
            {
                Console.WriteLine(carpeta);
            }
            //El metodo GetFiles devuelve un arreglo con todos los nombres de los archivos dentro de la ruta indicada
            string[] archivos = Directory.GetFiles(@"G:\Programacion - Manuales\_C#");
            Console.WriteLine("Los archivos hallados son:");
            foreach (string archvo in archivos)
            {
                Console.WriteLine(archvo);
            }
            //Tambien podemos utilizar las clases DirectoryInfo y FileInfo que tienen mas metodos

            //CREAMOS PREVIAMENTE UN DIRECTORIO PARA PODER ELIMINARLO
            //podemos crear
            Directory.CreateDirectory(@"G:\Carpeta1");
            Directory.CreateDirectory(@"G:\Carpeta2");
            Directory.CreateDirectory(@"G:\Contenedor");
            //crear archivos dentro y mover la carpeta sin que su contenido se vea afectado
            //PARA LOS ARCHIVOS USAMOS TAMBIEN EXISTS, CREATE, MOVE Y DELETE
            //podemos comprobar si existe
            if (Directory.Exists(@"G:\Carpeta2"))
            {   //y eliminar
                Directory.Delete(@"G:\Carpeta2");
                //si la carpeta a eliminar posee algo dentro debemos usar Delete("<carpeta>", true);
            }

            //para renombrar usamos (quitar forma de comentario para utilizar:)
            /*
            Directory.Move(@"G:\Carpeta1", @"G:\MiCarpeta");
            //para mover
            Directory.Move(@"G:\MiCarpeta", @"G:\Contenedor\MiCarpeta");
            */
            Console.ReadKey();
        }
    }
}
