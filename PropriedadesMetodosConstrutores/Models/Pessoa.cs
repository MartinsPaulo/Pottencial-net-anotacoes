using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome 
        {

            get => _nome.ToUpper(); //body expression
            /*
            get
            {
                return _nome.ToUpper();
            }*/

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }
        public int Idade 
        {
            get => _idade;

            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} , Idade: {Idade}");
        }
    }
}