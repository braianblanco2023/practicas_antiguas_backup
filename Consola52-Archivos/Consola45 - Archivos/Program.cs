using System;
using System.IO;
using System.Text;

namespace Consola45___Archivos
{
    class Program
    {
        //VAMOS A TRABAJAR CON LA CLASE SYSTEM.IO.FILE Y CON SYSTEM.IO.STREAM
        static void Main(string[] args)
        {
            //Se crea un archivo y se lo lleva al stream de escritura paea escribir en él
            StreamWriter sw = File.CreateText("C:\\Users\\Braian\\Downloads\\archivo.txt");
            sw.Write("Hola Mundo");
            //Se escribe y luego se cierra
            sw.Close();
            Console.WriteLine("Se escribió la línea Hola Mundo");

            //Se usa File para abrir un existente y se lo lleva a un stream de lectura para usarlo
            StreamReader sr = File.OpenText(@"C:\Users\Braian\Downloads\archivo.txt");  //una ruta tambien se escribe así con @
            Console.WriteLine("Contenido del documento:");
            //Se lee el stream y se cierra para liberar el recurso
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

            //Se abre un archivo para agregar texto con Append
            StreamWriter sw2 = File.AppendText("C:\\Users\\Braian\\Downloads\\archivo.txt");
            sw2.WriteLine(" agregamos texto seguido");
            sw2.WriteLine("Otra línea de código");
            sw2.Close();

            //Ahora para escribir en una posición específica del txt haremos uso de FileStream
            FileStream fs = new FileStream("C:\\Users\\Braian\\Downloads\\archivo.txt", FileMode.Append);
            //creamos nuestra cadena de texto a agregar
            String cadena = "- ESTE TEXTO LO INGRESAMOS ENTRE MEDIO DEL CONTENIDO -";
            //la escribimos en el archivo byte por byte desde la posicion 3 hasta su longitud
            Console.WriteLine("Se agregarán {0} caracteres", cadena.Length);
            //Pero antes de ingresar la cadena debemos pararnos en una posicion...
            fs.Write(Encoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Seek(-20, SeekOrigin.End);   //esto es a 40 caracteres antes del final
            cadena = "------";
            fs.Write(Encoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Close();

            //Se vuelve a hacer un Read para ver otros atributos de StreamReader
            StreamReader sr2 = File.OpenText("C:\\Users\\Braian\\Downloads\\archivo.txt");
            //Se lee el stream pero solo una linea esta vez
            Console.WriteLine("Linea del documento");
            Console.WriteLine(sr2.ReadLine());
            //Se lee todo para ver la diferencia (se muestra desde donde quedamos en el stream, el resto)
            Console.WriteLine("Contenido de todo el documento:");
            Console.WriteLine(sr2.ReadToEnd());
            sr2.Close();

            //PERO LA MEJOR FORMA DE TRABAJAR CON DIRECTORIOS ES MENOS ENGORROSA, DEL MODO:

            //Mejor un Stream de archivo, con modo de Apertura o Creacion si no existe, y en LeerEscribit
            FileStream F = new FileStream("archivo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //creamos una cedana de texto y la transformamos a Byte para FileStream
            string texto = "Texto en el documento";
            F.Write(Encoding.ASCII.GetBytes(texto));
            F.Position = 0;
            F.Write(Encoding.ASCII.GetBytes("Cadena"));
            F.Close();
            //Reeabrimos sin reescribirlo
            //Si vamos a usar modo Agregar (Append) solo podemos usar FileAccess Write
            FileStream F2 = new FileStream("archivo.txt", FileMode.Append, FileAccess.Write);
            F2.Write(Encoding.ASCII.GetBytes(texto.ToUpper()));
            F2.Close();

            //O BIEN

            //para leer capturamos directo a una variable
            string contenido = File.ReadAllText("archivo.txt");
            Console.WriteLine("El contenido es: ");
            Console.WriteLine(contenido);
            //para escribir especificamos el archivo y luego el contenido
            string nuevoContenido = "ESTO LO INGRESAMOS";
            //File.WriteAllText para sobreescribir el archivo, AppenAllText para agregar
            File.AppendAllText("archivo.txt", nuevoContenido);
            Console.WriteLine("El nuevo contenido es: ");
            contenido = File.ReadAllText("archivo.txt");
            Console.WriteLine(contenido);
            //ESTE MODO NO NOS PERMITE MOVER EL CURSOR POR EL DOC

            //O USAMOS STREAM READERS Y WRITERS

            StreamWriter sWriter = new StreamWriter("archivo2.txt");
            sWriter.WriteLine("Una linea");
            sWriter.WriteLine("Otra linea");
            sWriter.Close();

            StreamReader sReader = new StreamReader("archivo2.txt");
            string linea;
            Console.WriteLine("Contenido de Archivo 2:");
            while ((linea = sReader.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
            sReader.Close();

            Console.ReadKey();
        }
    }
}
