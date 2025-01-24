using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola30
{   //Clase que contiene los métodos para el delegado
    public class ClaseDeMetodos
    {
        public void miMetodo1()   //método señalado por el delegado
        {
            Console.WriteLine("Se lanzó miMetodo1 a través del Evento");
        }
        public void miMetodo2()   //método señalado por el delegado
        {
            Console.WriteLine("Se lanzó miMetodo2 a través del Evento");
        }
    }
    //Delegado que apuntará a miMetodo1() y miMetodo2()
    public delegate void Del_miMetodo();

    public class ClaseDelEvento
    {
        //Evento que controla el Delegado
        public event Del_miMetodo Ev_miDel;
        //método que recibe objeto de clase
        public void AñadirMetodos(ClaseDeMetodos objDeMetodos)
        {
            //...y se asigna sus métodos al Delegado...
            this.Ev_miDel += new Del_miMetodo(objDeMetodos.miMetodo1);
            this.Ev_miDel += new Del_miMetodo(objDeMetodos.miMetodo2);    	//...y el Delegado al Evento
        }
        public void LanzarEvento()  //método lanzador del Evento
        {
            Console.WriteLine("Se lanza Evento...");
            this.Ev_miDel();        //ejecución del Evento
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ClaseDelEvento objDelEvento = new ClaseDelEvento();
            ClaseDeMetodos objDeMetodos = new ClaseDeMetodos();
            //se pasa objeto de clase por parámetro al método
            objDelEvento.AñadirMetodos(objDeMetodos); 
            Console.WriteLine("Si desea lanzar el evento pulse Enter");
            Console.ReadLine();
            //se llama al método lanzador el Evento
            objDelEvento.LanzarEvento();
            Console.ReadKey();
        }
    }
}
/* Bien podríamos haber colocado la línea "this.Ev_miDel();" del método "LanzarEvento()" dentro del método 
 * "AñadirMetodos(...)", pero esta ejecución se realiza aparte, debido a que LanzarEvento() representa 
 * lo mas similar a un On_Click() de ejecución en un formulario, evento de ratón que no recibe parámetros.
 */