using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;

var tipoAnonimo = new { Nome = "Paulo", Sobrenome = "Martins", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);