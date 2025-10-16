using System;

class Exercicio09_IgorCosta
{
    static void Main()
    {
        Console.WriteLine("Digite a altura do triangulo de estrelas:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
