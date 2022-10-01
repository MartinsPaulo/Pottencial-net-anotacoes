using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 35.00M,dataAtual);
Venda v2 = new Venda(1, "Material de aula", 40.00M,dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(v1);
string serializadoIdentado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado);
Console.WriteLine(serializadoIdentado); //data é representada no formato ISO 8601

/*Escrevendo um arquivo JSON*/

File.WriteAllText("Arquivos/vendas.json", serializadoIdentado);

/*Escrevendo uma lista de venda*/

string todasVendas = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendasListadas.json", todasVendas);


/*Deserializando um objeto*/

string conteudoArquivo = File.ReadAllText("Arquivos/vendasListadas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

Console.WriteLine("\nVendas Deserializadas: \n");
foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}