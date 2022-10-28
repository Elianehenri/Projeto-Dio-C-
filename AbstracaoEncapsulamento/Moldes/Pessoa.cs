using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Moldes
{
    public class Pessoa
    {
//abstraçao
        public string Nome { get; set; }    
        public int Idade { get; set; } 
        public string Email { get; set; }
         public Pessoa()
        {
           
        }
         public Pessoa(string nome )
        {
            Nome = nome;
        }

        /*public Pessoa(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = Email;
        }*/

        //polimorfismo (virtual)
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos.");
        }

    }
}
