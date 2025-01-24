using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola19___Polimorfismo___Sobrecarga_de_Operadores
{
    class Complejo
    {   //Imaginemos la suma de dos valores con una parte real y otra imaginaria
        public float ParteReal; 
        public float ParteImaginaria; 
        public Complejo (float parteReal, float parteImaginaria)    //Constructor  
        { 
            this.ParteReal = parteReal; 
            this.ParteImaginaria = parteImaginaria; 
        } 
        //Sobrecarga del operador de + para la suma de dos objetos Complejo
        public static Complejo operator+ (Complejo op1, Complejo op2)  
        { 
            Complejo resultado = new Complejo(0,0); 
            resultado.ParteReal = op1.ParteReal + op2.ParteReal;    
            resultado.ParteImaginaria= op1.ParteImaginaria + op2.ParteImaginaria;
            return resultado;  
        } 
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(3,2);    // c1 = 3 + 2i   
            Complejo c2 = new Complejo(5,2);    // c2 = 5 + 2i   
            Complejo c3 = c1 + c2;              // c3 = 8 + 4i
            //Mostramos por separado
            Console.Write("Resultado de la suma de dos numeros complejos: ");
            Console.Write("{0}+", c3.ParteReal);
            Console.Write("{0}i", c3.ParteImaginaria);       
            Console.ReadKey();
        }
    }
}
