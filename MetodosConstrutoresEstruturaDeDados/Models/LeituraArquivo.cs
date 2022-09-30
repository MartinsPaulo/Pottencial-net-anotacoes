using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosConstrutoresEstruturaDeDados.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso,string[] Linhas,int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try{
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }catch (Exception)
            {
                return (false, new String[0],0);
            }

        }
    }
}