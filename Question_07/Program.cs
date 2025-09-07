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

        Console.Write("Vamos calcular a soma de uma PA:\n");

        Console.Write("Digite o primeiro termo (a1):\n");
        a1 = int.Parse(Console.ReadLine());

        Console.Write("\nAgora digite o segundo termo (a2):\n");
        a2 = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o numero de termos (n):\n");
        n = int.Parse(Console.ReadLine());

        // Calcula a razao
        r = a2 - a1;

        // Calcula o n-esimo termo: an = a1 + (n-1)*r
        an = a1 + (n - 1) * r;

        // Calcula a soma Sn = n * (a1 + an) / 2
        Sn = n * (a1 + an) / 2;

        Console.Write($"\nTemos a1 = {a1}, a2 = {a2}, razao r = {r}, n = {n}.\n");
        Console.Write($"O ultimo termo (an) eh: {an}\n");
        Console.Write($"\nAplicando a formula da soma: Sn = n * (a1 + an) / 2\n");
        Console.Write($"\nResultado final: A soma dos {n} primeiros termos eh {Sn}!");
    }
}
