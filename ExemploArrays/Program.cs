//using ExemploArrays.Common.Models;

int [] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;

for (int contador = 0; contador < arrayInteiros.Length; contador ++) {
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");

foreach (int valor in arrayInteiros) 
{
    Console.WriteLine(valor);
}

///Array.Resize Altera o tamanho maximo do array
// Na verdade por baixo dos panos ele cria um novo array com a capacidade que você acabou de passar
// e copia os elementos que você criou e passa para o outro.
//Array.Resize(ref arrayInteiros, arrayInteiros.Length*2);


// Array.Copy (); // copia um array para outro.
