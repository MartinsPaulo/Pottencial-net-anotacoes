using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MetodosConstrutoresEstruturaDeDados.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime datavenda) //, decimal? desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = datavenda;
            //Desconto = desconto;
        }
    
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        //public decimal? Desconto { get; set; }
    }
}