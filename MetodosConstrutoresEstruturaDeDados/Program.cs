using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;


MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);


MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Olha uma string");

Console.WriteLine(arrayString[0]);