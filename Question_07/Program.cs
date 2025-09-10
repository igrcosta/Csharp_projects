using System;

// Nessa questao, vamos trabalhar com uma progressao aritmetica (PA).
// O programa vai pedir o primeiro termo (a1), o segundo termo (a2)
// e a quantidade de termos (n). Depois, ele vai calcular a soma dos n termos (Sn).

class Questao07
{
    // metodo para rodar quando clicar no play
    static void Main()
    {
        int a1, a2, n, an, Sn, r;
        Console.Write("Digite o valor do 1 termo:\n");
        a1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do 2 termo:\n");
        a2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero de termos:\n");
        n = int.Parse(Console.ReadLine());

        // Calcula a razao
        r = a2 - a1;

        // Calcula o n-esimo termo: an = a1 + (n-1)*r
        an = a1 + (n - 1) * r;

        // Calcula a soma Sn = n * (a1 + an) / 2
        Sn = n * (a1 + an) / 2;
        Console.Write($"Soma = {Sn}");
    }
}
