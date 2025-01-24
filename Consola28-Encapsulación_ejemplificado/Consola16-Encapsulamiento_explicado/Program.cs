using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola16_Encapsulamiento_explicado
{
    class BankAccount
    {
        // Campos privados
        private int accountNumber;
        private string owner;
        private decimal balance;

        // Propiedad para AccountNumber (solo lectura)
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        // Propiedad para Owner (lectura y escritura con validación)
        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Owner name cannot be empty.");
                }
                owner = value;
            }
        }

        // Propiedad para Balance (lectura y escritura con lógica adicional)
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Balance cannot be negative.");
                }
                balance = value;
            }
        }

        // Constructor
        public BankAccount(int accountNumber, string owner, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.Owner = owner;  // Usa la propiedad para aplicar validación
            this.Balance = initialBalance; // Usa la propiedad para aplicar lógica adicional
        }

        // Método para depositar dinero
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
            Console.WriteLine("Deposited {0:C}. New balance: {1:C}", amount, Balance);
        }

        // Método para retirar dinero
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
            Console.WriteLine("Withdrew {0:C}. New balance: {1:C}", amount, Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una nueva cuenta bancaria
            BankAccount account = new BankAccount(12345, "John Doe", 1000.00m);

            // Mostrar información de la cuenta
            Console.WriteLine("Account Number: {0}", account.AccountNumber);
            Console.WriteLine("Owner: {0}", account.Owner);
            Console.WriteLine("Initial Balance: {0:C}", account.Balance);

            // Realizar depósitos y retiros
            account.Deposit(500.00m);
            account.Withdraw(200.00m);

            // Intentar realizar operaciones inválidas para ver las validaciones
            try
            {
                account.Deposit(-100.00m);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                account.Withdraw(2000.00m);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Intentar establecer un propietario inválido
            try
            {
                account.Owner = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Mostrar el saldo final
            Console.WriteLine("Final Balance: {0:C}", account.Balance);

            Console.ReadKey();
        }
    }

}
