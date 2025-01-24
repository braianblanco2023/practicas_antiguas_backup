using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola01_Variables__Constantes_y_Propiedades_Enum
{
    public class Program
    {
        public void ConstantesYVariables()
        {
            const int miConstante = 10; //constantes: necesitan inicializarse con un valor al declararse
            bool varBooleana;           //variables: no precisan ser inicializadas al declararse...
            varBooleana = true;         //...para luego asignarle y modificar su valor x veces
        }
        public enum Idiomas           //Un 'enum' es un Tipo, y especifica un grupo de constantes...
        {
            Español = 1,
            English = 2,        //aqui el conjunto de constantes y su valor ya declarado
            Français = 3,
            Português = 4,
        }

        static void Main(string[] args)
        {
            //...Y del tipo enum podemos crear objetos o mejor dicho variables:
            Idiomas miLengua;
            int numeroAleatorio = 3;    //variable de prueba
            miLengua = (Idiomas)numeroAleatorio;    //al pasar el valor 3, asignamos 'Français' a miLengua
            Console.WriteLine("Lengua elegida: " + miLengua);
            Console.ReadKey();
        }
    }
}
