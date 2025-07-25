using System;
using System.Globalization;

namespace DepositosPOO
{
    internal class ContaBancaria
    {
        //encapsulamento
        private string _numero;
        public string Nome { get; set; }
        
        public double SaldoInicial { get; private set; }//apesar de ser alterável, apenas é alterável por meio de função

        //construtor para deposito == 'n'
        public ContaBancaria(string numero, string nome)
        {
            _numero = numero;
            Nome = nome;
        }

        //construtor para deposito == 's'
        public ContaBancaria(string numero, string nome, double depositoInicial) : this(numero, nome)
        {
            AdicionarValor(depositoInicial); //Lógica de depósito implementada diretamente no depósito inicial
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
