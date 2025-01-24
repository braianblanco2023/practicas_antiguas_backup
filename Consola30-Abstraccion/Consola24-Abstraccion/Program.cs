using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola24_Abstraccion
{
    abstract class Pago
    {
        // Propiedades comunes
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        // Método abstracto
        public abstract void RealizarPago();

        // Método concreto
        public void MostrarInfo()
        {
            Console.WriteLine("Monto: {0:C}", Monto);
            Console.WriteLine("Fecha: {0}", Fecha);
        }
    }
    class PagoConTarjeta : Pago
    {
        // Propiedades específicas
        public string NumeroTarjeta { get; set; }
        public string TitularTarjeta { get; set; }

        // Implementación del método abstracto
        public override void RealizarPago()
        {
            Console.WriteLine("Realizando pago con tarjeta de crédito...");
            Console.WriteLine("Número de Tarjeta: {0}", NumeroTarjeta);
            Console.WriteLine("Titular de la Tarjeta: {0}", TitularTarjeta);
            MostrarInfo();
        }
    }
    class PagoConPayPal : Pago
    {
        // Propiedades específicas
        public string EmailCuentaPayPal { get; set; }

        // Implementación del método abstracto
        public override void RealizarPago()
        {
            Console.WriteLine("Realizando pago con PayPal...");
            Console.WriteLine("Email de la Cuenta PayPal: {0}", EmailCuentaPayPal);
            MostrarInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de PagoConTarjeta
            Pago pagoConTarjeta = new PagoConTarjeta
            {
                Monto = 100.00m,
                Fecha = DateTime.Now,
                NumeroTarjeta = "1234 5678 9012 3456",
                TitularTarjeta = "John Doe"
            };
            pagoConTarjeta.RealizarPago();

            Console.WriteLine();

            // Crear una instancia de PagoConPayPal
            Pago pagoConPayPal = new PagoConPayPal
            {
                Monto = 50.00m,
                Fecha = DateTime.Now,
                EmailCuentaPayPal = "john.doe@example.com"
            };
            pagoConPayPal.RealizarPago();

            Console.ReadKey();
        }
    }

}
