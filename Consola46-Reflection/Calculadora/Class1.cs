using System;

//SE COMPILÓ ESTO AL TERMINAR DE ESCRIBIR EL CODIGO, DESDE EL MENU COMPILAR_ COMPILAR SOLUCION
namespace Calculadora
{
    public class Class1
    {
        private int num1 = 0;
        private int num2 = 0;

        public int Sumar(int a, int b)
        {
            num1 = a;
            num2 = b;

            return num1 + num2;
        }
        public int Restar(int a, int b)
        {
            num1 = a;
            num2 = b;

            return num1 - num2;
        }

    }
}
