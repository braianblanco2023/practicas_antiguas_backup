using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola21
{
    class Boxeo
    {
        Boxeador boxeador1 = new Boxeador();
        Boxeador boxeador2 = new Boxeador();

        public void ComenzarRound(Boxeador b1, Boxeador b2)	//Polimorfismo en accion... puede recibir cualquier boxeador para golpear
        {
            boxeador1 = b1;
	    boxeador2 = b2;
            boxeador1.Golpear();
            boxeador2.Golpear();
        }
    }
    class Boxeador
    {
        public virtual void Golpear()		//método virtual padre
        {
            Console.WriteLine("Golpe Realizado");
        }
    }
    class BoxeadorRojo : Boxeador 					//uso de la herencia
    {
        public override void Golpear()	//este método reescribe el de la clase padre
        {
            Console.WriteLine("Golpe Realizado por boxeador de short Rojo");
        }
    }
    class BoxeadorAzul : Boxeador 					//uso de la herencia
    {
        public override void Golpear()	//este método reescribe el de la clase padre
        {
            Console.WriteLine("Golpe Realizado por boxeador de short Azul");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BoxeadorRojo box1 = new BoxeadorRojo();
            BoxeadorAzul box2 = new BoxeadorAzul();
            Boxeo miPelea = new Boxeo();
            miPelea.ComenzarRound(box2, box2);		//se pasan el tipo de boxeador deseado (en este caso el de azul pega dos veces)
            Console.ReadKey();
        }
    }
}
