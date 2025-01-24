using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola13
{
    class Vehículo                  //clase madre
    {
        public void Arrancar() 
        {
            Console.WriteLine("Arrancando");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }
    }
    class Auto : Vehículo           //clase hija que hereda Arrancar() y Frenar()
    {
        public void Levantar_Vidrio()
        {
            Console.WriteLine("Levantando Vidrio");
        }
        public void Bajar_Vidrio()
        {
            Console.WriteLine("Bajando Vidrio");
        }
    }
    class Grua : Vehículo           //clase hija que hereda Arrancar() y Frenar()
    {
        public void Levantar_Pala() 
        {
            Console.WriteLine("Levantando Pala");
        }
        public void Bajar_Pala()
        {
            Console.WriteLine("Bajando Pala");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grua miGrua = new Grua();
            miGrua.Arrancar();              //metodo heredado de clase madre
            miGrua.Levantar_Pala();
            miGrua.Bajar_Pala();
            miGrua.Frenar();                //metodo heredado de clase madre
            Console.ReadKey();
        }
    }
}
