using System;
using System.IO;
using System.IO.Compression;    //Trabajamos con este namespace para la clase ZipFile

namespace Consola48___ZipFile_ZipArchive
{
    class Program
    {
        //ESTA APP VA A COMPRIMIR O DESCOMPRIMIR UN ARCHIVO CADA VEZ QUE SE EJECUCTE (se halla en 'bin')
        static void Main(string[] args)
        {
            //comprobamos si la carpeta está comprimida (es un archivo zip) o no (es un directorio)
            if (Directory.Exists("sinComprimir"))
            {
                Console.WriteLine("Cmprimiendo la carpeta");
                comprimir();
                Directory.Delete("sinComprimir", true); //true para eliminar también sus archivos dentro
                Console.ReadKey();
            }
            else if (File.Exists("comprimida.zip"))
            {
                Console.WriteLine("Decomprimiendo el archivo ZIP");
                descomprimir();
                File.Delete("comprimida.zip");
                Console.ReadKey();
            }
        }
        public static void comprimir()
        {
            //se comprime indicando el directorio a comprimir, luego el destino, el tipo de compresion 
            //(que puede ser Optimal o el mejor, Fastest o el mas rapido y NoCompression o solo zippar)
            ZipFile.CreateFromDirectory("sinComprimir", "comprimida.zip", CompressionLevel.Optimal, false);
            //lo que hace el cuarto argumento true o false es comprimir o no la raiz o solo sus archivos
        }
        public static void descomprimir()
        {
            //modo contrario, descomprimimos indicando la ruta de archivo y el directorio destino (lo crea)
            ZipFile.ExtractToDirectory("comprimida.zip", "sinComprimir");
        }
    }
}
