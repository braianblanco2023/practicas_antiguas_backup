using System;
using System.Runtime.InteropServices;

namespace Consola
{
    class Program
    {
        delegate bool Callback(int hWnd, int lParam);

        [DllImport("user32.dll")]
        static extern int EnumWindows(Callback x, int y);

        static bool PrintWindow(int hWnd, int lParam)
        {
            Console.Write("El identificador de ventana es ");
            Console.WriteLine(hWnd);
            return true;
        }
        static void Main()
        {
            Callback myCallBack = new Callback(PrintWindow);
            EnumWindows(myCallBack, 0);
            Console.ReadKey();
        }
    }
}