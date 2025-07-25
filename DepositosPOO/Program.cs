using System;
using System.Globalization;

namespace DepositosPOO
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            string conta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opc = Console.ReadKey().KeyChar;
            Console.WriteLine();

            ContaBancaria c;

            if (opc == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(conta, titular, deposito);
                Console.WriteLine("");
            }
            else if(opc == 'n')
            {
                c = new ContaBancaria(conta, titular);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Digite uma opção válida");
                return;
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");

            Console.Write("Entre um valor para depósito: ");
            double segundodeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.AdicionarValor(segundodeposito);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.Saque(saque);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());
        }
    }
}