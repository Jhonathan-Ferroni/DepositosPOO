using System;
using System.Globalization;

namespace DepositosPOO
{
    internal class ContaBancaria
    {
        //encapsulamento
        private string _numero;
        public string Nome { get; set; }
        public char Deposito { get; private set; }
        public double SaldoInicial { get; private set; }

        //construtor para deposito == 's'
        public ContaBancaria(string numero, string nome, char deposito, double valor)
        {
            _numero = numero;
            Nome = nome;
            Deposito = deposito;
            SaldoInicial = valor;
        }

        //construtor para deposito == 'n'
        public ContaBancaria(string numero, string nome, char deposito)
        {
            _numero = numero;
            Nome = nome;
            Deposito = deposito;
            SaldoInicial = 0;

        }

        //Propertie
        public string Numero
        {
            get { return _numero; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _numero = value;
                }
            }
        }

        //funções

        public void AdicionarValor(double valor)
        {
            SaldoInicial += valor;
        }

        public void Saque(double valor)
        {
            SaldoInicial -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "+ _numero + ", Titular: " + Nome + ", Saldo: $ " + SaldoInicial;
        }
    }
}
