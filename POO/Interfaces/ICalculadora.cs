using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        //implementação padrão de interface deixa o método condicional,
        //você não é obrigado implementar ele pois ele pega o padrão
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}