using MetodosConstrutoresEstruturaDeDados.Models;
using System.Globalization;
using Newtonsoft.Json;


List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 35.00M);
Venda v2 = new Venda(1, "Material de aula", 40.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(v1);
string serializadoIdentado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado);
Console.WriteLine(serializadoIdentado);

/*Escrevendo um arquivo JSON*/

File.WriteAllText("Arquivos/vendas.json", serializadoIdentado);

/*Escrevendo uma lista de venda*/

string todasVendas = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendasListadas.json", todasVendas);
