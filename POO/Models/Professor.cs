using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }
        //com o "sealed (antes do override - significa que a classe é selada, ou seja nenhuma classe filha pode sobrescrever este método)
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é  {Nome} e tenho {Idade} anos e sou um professor e ganho {Salario}!");
        }
    }
}