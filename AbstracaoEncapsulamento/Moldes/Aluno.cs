using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//herança
namespace AbstracaoEncapsulamento.Moldes
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {

        }
        public Aluno( )
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos, meu email é : {Email} e sou um aluno nota {Nota}.");
        }
    }
}
