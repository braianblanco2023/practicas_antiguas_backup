using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola22bis___CualUsarSegun
{
    /*CUANDO QUEREMOS PODER CREAR TANTO OBJETOS DE UNA CLASE PADRE COMO DE SU HIJA (ADEMÁS DE AHORRAR CODIGO CON LA 
     * HERENCIA), USAR UN METODO VIRTUAL NOS PERMITE DIFERENCIAR UNA FUNCIONALIDAD QUE AMBAS CLASES COMPARTEN PERO 
     * LA HACEN DIFERENTE. EN EL EJEMPLO PADRE E HIJO PUEDEN caminar() IGUAL, PERO correr() A DIFERENTE VELOCIDAD*/
    class Padre {
        public void Caminar()
        {
            Console.WriteLine("Puedo Caminar");
        }
        public virtual void Correr()
        {
            Console.WriteLine("Puedo Correr");
        }
    }
    class Hijo : Padre {
        //VA A HEREDAR DEL PADRE PODER Caminar(), PERO QUEREMOS QUE PUEDA CORRER MÁS RAPIDO
        public override void Correr()
        {
            base.Correr();
            Console.WriteLine("...pero mas rápido que mi padre");
        }
    }
    /*CUANDO QUEREMOS CREAR VARIOS TIPOS DE UNA MISMA COSA O GENERO (EJ: AUTOS Y MOTOS SON VEHICULOS), LOS CUALES
     COMPARTEN MUCHAS FUNCIONES, PERO NO TODAS, Y NO DESEADOS CREAR OBJETOS DE LA CLASE GENERAL (VEHICULO), USAMOS 
     LA CLASE ABSTRACTA, EN LA CUAL PODEMOS CREAR METODOS O FUNCIONALIDADES COMUNES A SUS CLASES HIJAS (PARA AHORRAR
     CODIGO CON LA HERENCIA), PERO TAMBIEN METODOS ABSTRACTOS (SIN DEFINIR) A HACER DIFERENTE EN SUS CLASES HIJAS*/
    abstract class Vehiculo
    {
        public void acelerar() //no se creará vehiculos, pero motos y autos pueden acelerar() y frenar() igual...
        {
            Console.WriteLine("Como vehiculo, puede Acelerar");
        }
        public void frenar()
        {
            Console.WriteLine("Como vehiculo, puede Frenar");
        }
        public abstract void marchar(); //... mientras que (motos y autos) van a marchar() de diferente modo
    }
    class Moto : Vehiculo
    {
        public override void marchar() {
            Console.WriteLine("Marcha solo hacia adelante");
        }
    }
    class Auto: Vehiculo
    {
        public override void marchar() {
            Console.WriteLine("Marcha hacia adelante y atras");
        }
    }
    /*USAR UNA CLASE ABSTRACTA NOS PERMITE DEFINIR METODOS (ABSTRACTOS) O FUNCIONES QUE SUS CLASES HIJAS HACEN 
     DE MODO DIFERENTE, Y HEREDAR A SU VEZ LO QUE HACEN IGUAL. AHORA, SI NO VAMOS A CREAR OBJETOS DE LA CLASE PADRE,
     Y LAS CLASES HIJAS REALIZARÁN ESTAS FUNCIONES PERO TODAS DE DIFERENTE MANERA, NO NECESITAREMOS DEFINIR NADA 
     EN LA CLASE PADRE, POR TANTO TAMPOCO NECESITAMOS HERENCIA (NO VAMOS A AHORRAR CÓDIGO): USAREMOS INTERFACES
     LA INTERFEZ SIRVE COMO ESQUELETO, LA CUAL NOS OBLIGA A DEFINIR TODOS SUS METODOS, COMO RECORDANDONOS QUE
     UNA CLASE QUE LA IMPLEMENTE DEBE CUMPLIR CON ESA ESTRUCTURA BÁSICA GENERAL (Ej: Todos los animales repiran)*/
    interface IAnimales
    {   //Todos los animales pueden y DEBEN cazar() y respirar(). Estan obligados a DEFINIR estos metodos
        void cazar();
        void respirar();
    }
    class Aves : IAnimales {
        public void cazar() {
            Console.WriteLine("Las aves cazan mientras vuelan");
        }
        public void respirar() {
            Console.WriteLine("Las aves respiran por el pico");
        }
        //pero un ave puede ademas volar()
        public void volar() { }
    }
    class Peces : IAnimales{
        public void cazar() {
            Console.WriteLine("Los peces cazan mientras nadan");
        }
        public void respirar() {
            Console.WriteLine("Los peces respiran por las branquias");
        }
        //pero un pez puede ademas nadar()
        public void nadar() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ASI FUNCIONA EL USO DE METODOS VIRTUALES
            Padre padre = new Padre();
            Hijo hijo = new Hijo();
            Console.WriteLine("El padre dice:");
            padre.Caminar();
            padre.Correr();
            Console.WriteLine("El hijo dice:");
            hijo.Caminar();
            hijo.Correr();
            //ASI FUNCIONA EL USO DE METODOS (y clases) ABSTRACTOS
            Moto moto = new Moto();
            Auto auto = new Auto();
            Console.WriteLine("Una MOTO...");
            moto.acelerar();
            moto.frenar();
            moto.marchar();
            Console.WriteLine("Un AUTO...");
            auto.acelerar();
            auto.frenar();
            auto.marchar();
            Console.ReadKey();
        }
    }
}
