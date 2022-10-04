using System.IO;
using System.Linq;
using System;

class DIO {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (String.Equals(a.Substring(a.Length-b.Length, b.Length), b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}