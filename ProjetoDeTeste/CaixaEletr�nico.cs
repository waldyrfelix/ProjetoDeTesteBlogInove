using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDeTeste
{
    class CaixaEletrônico
    {
        public decimal Saldo { get; private set; }

        public void Depositar(int valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor a ser depositado não pode ser negativo.");
            }

            this.Saldo += valor;
        }

        public void Sacar(int valor)
        {
            this.Saldo -= valor;
        }
    }
}
