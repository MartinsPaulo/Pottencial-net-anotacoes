using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Paulo", "Martins");

(string nome, String sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

//IF TERNARIO

int numero = 14;
bool ehPar = numero % 2 == 0;

Console.WriteLine($"O número é {numero} é " + (ehPar ? "par" : "ímpar"));