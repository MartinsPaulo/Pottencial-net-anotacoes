using PropriedadesMetodosConstrutores.Models;
using System.Globalization;

(int Id, string Nome, string Sobrenome,decimal Altura) tupla = (1, "Paulo", "Martins", 1.83M);
ValueTuple<int,string, string, decimal> outroExemploTupla = (1, "Paulo", "Martins", 1.83M);
var outroExemploTupla2 = Tuple.Create(1, "Paulo", "Martins", 1.83M);

Console.WriteLine($"Id: {outroExemploTupla.Item1}");
Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
Console.WriteLine($"Altura: {outroExemploTupla.Item4}");

Console.WriteLine("------------------------------------");

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");