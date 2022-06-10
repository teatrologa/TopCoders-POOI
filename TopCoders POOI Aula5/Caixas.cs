using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoders_POOI_Aula5
{
    public class Caixa
    {
        public DateTime DataCaixa { get; private set; }

        public decimal Saldo { get; private set; }

        public void AbrirCaixa(decimal saldoInicial = 0)
        {
            DataCaixa = DateTime.Now;
            Saldo = saldoInicial;
        }
        public void Deposita(decimal valor)
        {
            Saldo += valor;
        }

        public void Saca(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficente");
                Console.WriteLine($"O saldo atual é de R$ {Saldo}");
            }
        }

    }
}
