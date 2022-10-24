// See https://aka.ms/new-console-template for more information
using ExemploExplorando.Models;


//decimal valorMonetario = 82.40M;
//Console.WriteLine($"{valorMonetario:C}");//c: coloca R$





//interpoçao
Pessoa p1 = new Pessoa(nome:"eliane","Henriqueta");
Pessoa p2= new Pessoa(nome:"agilson","Henriqueta");
Pessoa p3= new Pessoa(nome:"julia","Henriqueta");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();





/*Pessoa p1 = new Pessoa();
p1.Nome = "eliane";
p1.Sobrenome = "Henriqueta";
p1.Idade = 30;
p1.Apresentar();*/
