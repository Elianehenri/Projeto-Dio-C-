using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Moldes
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }

        //encapsulamento
        private decimal saldo;

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console
                    .WriteLine("Valor desejavel é maior que o saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu Saldo disponivel é:" + saldo);
        }
    }
}
