using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola22
{
    class Juego
    {
        public void ComenzarJuego(Jugador j1, Jugador j2)
        {
            j1.RealizarMovida();
            j2.RealizarMovida();
        }
    }
    abstract class Jugador
    {
        public abstract void RealizarMovida();  //método abstracto padre
    }
    class Jugador1 : Jugador					//uso de la herencia
    {
        public override void RealizarMovida()	//este método anula el de la clase padre
        {
            Console.WriteLine("Movida Realizada por jugador 1");
        }
    }
    class Jugador2 : Jugador					//uso de la herencia
    {
        public override void RealizarMovida()	//este método anula el de la clase padre
        {
            Console.WriteLine("Movida Realizada por jugador 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jugador1 jug1 = new Jugador1();
            Jugador2 jug2 = new Jugador2();
            Juego miJuego = new Juego();
            miJuego.ComenzarJuego(jug2, jug2);		//se pasan el tipo de jugador deseado
            Console.ReadKey();
        }
    }
}
