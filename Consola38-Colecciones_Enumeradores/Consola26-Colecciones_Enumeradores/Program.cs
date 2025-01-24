using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola26_Colecciones_Enumeradores
{   /*
    Tenemos una colección de productos y queremos crear un enumerador personalizado que devuelva solo 
    los productos que están en stock, su nombre en mayusculas y cuyo precio es mayor que un cierto valor.
     */
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool EnStock { get; set; }
    }

    // Clase enumeradora personalizada (implementa la interfaz IEnumerator)
    public class FiltrarYTransformarProductos : IEnumerator<Producto>
    {
        private readonly List<Producto> _productos;     //lista de elementos con los que trabajar
        private readonly decimal _precioMinimo;         //criterio de filtrado
        private int _indiceActual = -1;                 //indice inicial necesario para comenzar a iterar

        //Constructor que recibe los elementos a filtrar, y un criterio de filtrado personalizable
        public FiltrarYTransformarProductos(List<Producto> productos, decimal precioMinimo)
        {
            _productos = productos;
            _precioMinimo = precioMinimo;
        }

        public Producto Current         //PRIMER METODO DE LA INTERFAZ IMPLEMENTADO (elemento actual?)
        {
            get
            {
                var productoActual = _productos[_indiceActual]; //se situa sobre un Producto segun indice
                return new Producto                             //y retorna un Producto
                {
                    Nombre = productoActual.Nombre.ToUpper(),
                    Precio = productoActual.Precio,
                    EnStock = productoActual.EnStock
                };
            }
        }

        object IEnumerator.Current => Current;                  //Situa el elemento actual

        public bool MoveNext()          //SEGUNDO METODO DE LA INTERFAZ IMPLEMENTADO (cómo moverse?)
        {   //Mientras existan mas elementos
            while (++_indiceActual < _productos.Count)  // ---------- SE HACE FILTRADO ----------
            {   //SI esta en Stock y supera el precio minimo...
                if (_productos[_indiceActual].EnStock && _productos[_indiceActual].Precio > _precioMinimo)
                {   //Lo devuelve
                    return true;
                }
            }
            return false;
        }

        public void Reset()             //TERCER METODO DE LA INTERFAZ IMPLEMENTADO (reseteo)
        {
            _indiceActual = -1;
        }

        public void Dispose() { }       //CUARTO METODO DE LA INTERFAZ -no IMPLEMENTADO-
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de productos
            var productos = new List<Producto>
            {
            new Producto { Nombre = "Producto 1", Precio = 50, EnStock = true },
            new Producto { Nombre = "Producto 2", Precio = 150, EnStock = false },
            new Producto { Nombre = "Producto 3", Precio = 200, EnStock = true },
            new Producto { Nombre = "Producto 4", Precio = 10, EnStock = true }
            };

            // Crear el enumerador personalizado, y se le pasa la lista y el criterio (precio minimo)
            var enumerador = new FiltrarYTransformarProductos(productos, 100);

            // Usar el enumerador
            while (enumerador.MoveNext())
            {
                var producto = enumerador.Current;  //traemos el elemento que cumpla 
                Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, En Stock: {producto.EnStock}");
            }

            Console.ReadKey();
        }
    }
}
        
