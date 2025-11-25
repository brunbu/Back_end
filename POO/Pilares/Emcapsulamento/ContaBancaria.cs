using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emcapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial < 0)
            {
                SaldoInicial = 0;
            }
            else
            {
                Saldo = SaldoInicial;
            }
        }
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }
            System.Console.WriteLine("Valor inválido para depósito");
        }
        public float getSaldo()
        {
            return Saldo;
        }
        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return;
            }
            System.Console.WriteLine("Saldo insuficiente ou valor inválido o para saque");
        }
    }
}