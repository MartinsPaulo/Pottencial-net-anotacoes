/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosConstrutoresEstruturaDeDados.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quatidade = Alunos.Count();
            return quatidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

    }
}
*/