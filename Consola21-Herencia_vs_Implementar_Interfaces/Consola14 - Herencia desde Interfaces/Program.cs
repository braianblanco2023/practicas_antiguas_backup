using System;

namespace Consola14___Herencia_desde_Interfaces
{
    class Program
    {
        public interface IOrganismo
        {
            void respirar();
            void mover();
        }
        public interface IAnimal
        {
            void mover();
            void viviparo();
        }
        class Perro : IOrganismo, IAnimal
        {
            public void respirar()
            {
                Console.WriteLine("Este Organismo respira");
            }
            /*Todo método de la interfaz de la que se hereda, debe ser implementado, y en este caso, las 
             dos interfaces poseen el mismo método, por lo cual sinó implementamos solo uno o ninguno, 
            dará error, y si implementamos ambos dará error por repetición (ambiguedad)
            Por tanto es obligatorio implementarlos pero como privados, de modo explícito*/
            //Ha de declararse explícitamente
            void IOrganismo.mover()
            {
                Console.WriteLine("Este Organismo se mueve");
            }
            //Ha de declararse explícitamente
            void IAnimal.mover()
            {
                Console.WriteLine("Este Animal se mueve");
            }
            //Este es un método propio de la clase, no una implementación de interfaz
            public void mover()
            {
                Console.WriteLine("Este Perro se mueve");
            }
            public void viviparo()
            {
                Console.WriteLine("Este Animal es Vivíparo");
            }
        }
        static void Main(string[] args)
        {
            Perro perros = new Perro();
            perros.respirar();
            perros.viviparo();
            perros.mover();
            //Para invocar los métodos ambiguos heredados de las interfaces, las instanciamos
            IOrganismo organismo = perros;
            IAnimal animal = perros;
            //pero como sus métodos no estan implementados, claro, las llamadas son a los de la clase
            organismo.mover();  //pero a través de las llamadas explícitas
            animal.mover();

            Console.ReadKey();
        }
    }
}
