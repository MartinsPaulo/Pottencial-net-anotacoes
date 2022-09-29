using PropriedadesMetodosConstrutores.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Paulo","Martins");
//Pessoa p1 = new Pessoa(nome: "Paulo", sobrenome: "Martins");

Pessoa p2 = new Pessoa();
p2.Nome = "Giovanna";
p2.Sobrenome = "Biazotto";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
Console.WriteLine($"Alunos do curso de: {cursoDeIngles.Nome}");
cursoDeIngles.ListarAlunos();

//Valor monetario
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//pt-BR e etcs

decimal valorMonetario = 1232.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(valorMonetario.ToString("C1")); //c(n) n= numero de casa decimais















/*Pessoa p1 = new Pessoa();

p1.Nome = "Paulo";
p1.Sobrenome = "Martins";
p1.Idade = 20;
p1.Apresentar();*/