using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar ()
        {
            Console.WriteLine($"Olá, meu nome é  {Nome} e tenho {Idade} anos!");
        }
    }
}