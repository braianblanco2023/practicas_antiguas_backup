using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola06_Modificadores_de_Acceso
{
    class miClase                   //CREACION DE UNA CLASE
    {
        public int a;               //variable publica
        protected int b;            //variable protegida
        private int c;              //variable privada
        public const int d = 4;     //creacion de una constante publica
        public static int e = 5;    //variable estatica
        public void Imprimir()
        {
            b = 2;
            c = 3;
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        public static void metodoStatic()       //un método estático solo puede acceder a una variable estática, no a las demás
        {
            e = 5;                              //variable estática
        }
    }
    class miClaseHija : miClase
    {                                           // En una clase heredada...
        public void OtroMetodo()
        {
            a = 10;             // la variable publica es accesible dentro de sus metodos
            b = 20;             // la variable protected es heredada como private, pero inaccesible en la proxima clase heredada
                                //c = 30;                miClase.c private no es accesible debido a su nivel de proteccion
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            miClase miObjeto = new miClase();   //para acceder a la variable publica de una clase hay que crear un objeto de ella
            miObjeto.a = 1;
            Console.WriteLine(miObjeto.a);

            miObjeto.Imprimir();                //para acceder a las protegidas y privadas solo a traves de métodos del objeto

            Console.WriteLine(miClase.d);       //se puede acceder a la constante sin crear un objeto de la clase 
            Console.WriteLine(miClase.e);       //se puede acceder a la variable estática publica sin crear un objeto de la clase

            miClase.metodoStatic();             //los métodos estáticos públicos se invocan desde el nombre de la clase

            Console.ReadKey();
        }
    }
}
