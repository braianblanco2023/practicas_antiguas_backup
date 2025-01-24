using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola23_Polimorfismo_explicado
{
    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class DrawingManager
    {
        public void DrawShape(IShape shape) //Polimorfismo en accion... se comporta según el objeto recibido
        {
            shape.Draw(); // Este método funciona con cualquier implementación de IShape (tiene forma polimorfica)
        }
    }

    class Program
    {
        static void Main()
        {
            IShape circle = new Circle();
            IShape square = new Square();

            DrawingManager manager = new DrawingManager();
            manager.DrawShape(circle); // Llama a Circle.Draw()
            manager.DrawShape(square); // Llama a Square.Draw()
        }
    }

}
