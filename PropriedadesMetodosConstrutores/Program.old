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

//Formatações
Console.WriteLine("\nFormatações:");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//pt-BR e etcs

decimal valorMonetario = 1232.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C1")); //c(n) n= numero de casa decimais

double porcentagem = .3421;

Console.WriteLine($"Porcentagem: {porcentagem.ToString("P")}");

int numero = 96296042;
Console.WriteLine($"Numero telefone: {numero.ToString("#####-####")}");

//Tipo datetime é uma struct 

DateTime data1 = DateTime.Now;
Console.WriteLine("\nDateTime:");
Console.WriteLine(data1);
Console.WriteLine(data1.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data1.ToShortTimeString());


string dataString = "2022-04-17 18:00";
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}












/*Pessoa p1 = new Pessoa();

p1.Nome = "Paulo";
p1.Sobrenome = "Martins";
p1.Idade = 20;
p1.Apresentar();*/