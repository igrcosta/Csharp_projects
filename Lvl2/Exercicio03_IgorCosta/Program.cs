using System;

class Exercicio03_IgorCosta
{
    static void Main()
    {
        int num, soma = 0;

        Console.WriteLine("Digite um numero:");
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= num; i++)
        {
            soma += i;
        }

        Console.WriteLine("A soma de todos os numeros de 1 ate " + num + " = " + soma);
    }
}
