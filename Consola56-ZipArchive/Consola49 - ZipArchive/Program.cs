using System;
using System.IO;
using System.IO.Compression;

namespace Consola49___ZipArchive
{
    class Program
    {
        //NOTA: ----EL USO DE USING ABAJO SE DEBE A GARANTIZAR QUE LAS DES/COMPRESIONES SE REALICEN
        //Y SE LIBEREN LOS RECURSOS (SE CIERREN, ETC), SINO FALLARAN
        static void Main(string[] args)
        {
            //hemos creado previamente un directorio con archivos y lo hemos comprimido (comprimida.zip)

            string siComprimir, siAgregar, siDeshacer;

            //EXTRAER ARCHIVOS DE UN ZIP

            //Indica que abrimos (Open) un ZipFile para tratarlo como ZipArchive y trabajar su contenido
            using (ZipArchive carpetaZip = ZipFile.Open("comprimida.zip", ZipArchiveMode.Read)) //Lectura
            {   //ahora de nuestra carpeta zip obtenemos dos entrada (GetEntry), dos archivos dentro suyo
                ZipArchiveEntry miArchivo1 = carpetaZip.GetEntry("archivo3.txt");
                ZipArchiveEntry miArchivo2 = carpetaZip.GetEntry(@"carpeta1/archivo1.txt");
                //ahora solo resta indicar donde extraer y estos archivos (y el nombre que le daremos)
                miArchivo1.ExtractToFile("archivo3.txt");   //queremos mantener el nombre, en carpeta bin
                miArchivo2.ExtractToFile("archivo1.txt");

                //Esto es para darle un orden a la app
                Console.WriteLine("Archivos Extraidos exitosamente: archivo1.txt y archivo3.txt");
                Console.WriteLine("Observe los cambios y confirme para comprimirlos con la tecla s");
                siComprimir = Console.ReadLine();
            }

            //CREAR UN ZIP A PARTIR DE ARCHIVOS ESPECIFICOS Y NO DE UN DIRECTORIO COMPLETO

            if (siComprimir == "s")
            {
                //al usar el modo Create, la ruta indicada será la del archivo .zip a crear (Mode Create)
                using (ZipArchive miZip = ZipFile.Open("miComprimida.zip", ZipArchiveMode.Create))
                {
                    //el proceso de incluir archivos para la carpeta a comprimir es mas sencillo (1 solo paso)
                    //creamos la entrada indicando la fuente, el nombre que tomará en el zip, y tipo de compresion
                    miZip.CreateEntryFromFile("archivo1.txt", "miArchivo1.txt", CompressionLevel.Optimal);
                    miZip.CreateEntryFromFile("archivo3.txt", "dir/miArchivo3.txt", CompressionLevel.Optimal);

                    //Esto es para darle un orden a la app
                    Console.WriteLine("Archivos Comprimidos exitosamente: en miComprimida.zip");
                    Console.WriteLine("Observe los cambios y confirme para agregar mas txt al zip con s");
                }
            }
            //ACTUALIZAR ZIP AGREGANDO ARCHIVOS (Update)

            siAgregar = Console.ReadLine();
            if (siAgregar == "s")
            {
                using (ZipArchive miZip2 = ZipFile.Open("miComprimida.zip", ZipArchiveMode.Update))
                {
                    miZip2.CreateEntryFromFile("agregado.txt", "miAgregado.txt");

                    //Esto es para darle un orden a la app
                    Console.WriteLine("Aechivos Agregados exitosamente: en miComprimida.zip");
                    Console.WriteLine("Observe los cambios y confirme para deshacer los cambios con s");
                }
            }
            //LO SIGUIENTE ES PARA DESHACER LOS CAMBIOS EN ESTA APP PARA PODER EJECUTARLA NUEVAMENTE

            siDeshacer = Console.ReadLine();
            if (siDeshacer == "s")
            {
                File.Delete("archivo1.txt");
                File.Delete("archivo3.txt");
                File.Delete("miComprimida.zip");
                Console.WriteLine("Cambios deshechos exitosamente, Adios!");
            }
            Console.ReadKey();
        }
    }
}
