using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola14
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
    class Grua : Vehículo           //clase hija que hereda Arrancar() y Frenar()
    {
        public void Arrancar()      //redefinición del método Arrancar()
        {
            base.Arrancar();        //llamado al código del método Arrancar()
            Console.WriteLine("...de un modo diferente");
        }
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