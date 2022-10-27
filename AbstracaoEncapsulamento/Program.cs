
using System.Security.Cryptography;
using AbstracaoEncapsulamento.Moldes;

//herança
Aluno a1 = new Aluno();
a1.Nome = "Eliane Lima";
a1.Idade = 45;
a1.Email ="eliane@gmail.com";
a1.Nota = 10;
a1.Apresentar();

Professor p = new Professor();
p.Nome = "Joana";
p.Idade = 60;
p.Email = "joana@gmial.com";
p.Salario = 5000M;
p.Apresentar();

 










//abstraçao
//objeto tipo pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Eliane";
p1.Idade = 44;

Pessoa p2 = new Pessoa();
p2.Nome = "Agilson";
p2.Idade = 60;

p1.Apresentar();
p2.Apresentar();


//encapsulamento
ContaCorrente c1 = new ContaCorrente(123,1000);

c1.ExibirSaldo();
c1.Sacar(250);
c1.ExibirSaldo();
