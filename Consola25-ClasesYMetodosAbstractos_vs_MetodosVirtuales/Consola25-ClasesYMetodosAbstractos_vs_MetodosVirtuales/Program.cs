using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola25_ClasesYMetodosAbstractos_vs_MetodosVirtuales
{
    //Ahora veamos un poco de clases y metodos abstractos
    /*Una clase abstracta no puede crear objetos de ella, y solo definir metodos abstractos o virtuales
     solo que aunque un metodo abstracto solo se pueda crear en una clase abstracta, un metodo virtual si 
     puede definirse en cualquier clase. Los virtual son para redefinirse*/
    public abstract class Hablar
    {
        public abstract void charla();     //sus metodos deben ser obviamente publicos para implementarse
        public virtual void conversa()
        {
            Console.WriteLine("Sere redefinido o complementado");
        }
    }
    class Dialogar : Hablar
    {
        public override void charla()      //override sobreescribe el metodo abstracto (tambien publico)
        {
            Console.WriteLine("Sou el metodo heredado e implementado de la clase abstracta padre");
        }
        public override void conversa()     //override tambien sobreescribe o redefine el metodo virtual
        {
            base.conversa();            //Esto reutiliza el metodo virtual de la clase padre
            Console.WriteLine("Y yo la complementacion");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dialogar dialogar = new Dialogar();
            dialogar.conversa();                //vemos como base.conversa incluyó el metodo virtual en padre
            Console.ReadKey();
        }
    }

}
