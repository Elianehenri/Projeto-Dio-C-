using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Moldes
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
            //polimorfismo
           public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos, meu email é : {Email} e sou professor com salario R$: {Salario}.");
        }
    }
}
