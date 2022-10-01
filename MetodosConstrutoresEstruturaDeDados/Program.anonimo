using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;

var tipoAnonimo = new { Nome = "Paulo", Sobrenome = "Martins", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);


/*Deserializando um objeto*/

string conteudoArquivo = File.ReadAllText("Arquivos/vendasNull.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });


foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto {venda.Produto} e Preço {venda.Preco}");
}