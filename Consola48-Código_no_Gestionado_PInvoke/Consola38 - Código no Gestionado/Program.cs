using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class PInvoke
    {
        [DllImport("user32.dll")]
        static extern int MessageBoxA(int hWnd, string msg, string caption, int type);

        //Invocamos la misma función pero con otra signatura con 'EntryPoint'
        [DllImport("user32.dll", EntryPoint="MessageBoxA")]
        static extern int Msg(int hWnd, string msg, string caption, int type);
        
        static void Main(string[] args)
        {
            MessageBoxA(0, "Hola", "Llamado a la DLL desde C#", 0);
            Msg(0, "Hola", "Otro llamado con EntryPoint", 0);
        }
    }
}
