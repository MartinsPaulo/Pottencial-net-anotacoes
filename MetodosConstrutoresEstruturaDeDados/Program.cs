using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;

//? transformar é um tipo especial que alem de true e false aceita null
bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber email");
}



/*Deserializando um objeto*/

string conteudoArquivo = File.ReadAllText("Arquivos/vendasNull.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

Console.WriteLine("\nVendas Deserializadas: \n");
foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + 
                      $" {(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}" : "")}");
}