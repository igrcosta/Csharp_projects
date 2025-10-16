using System;

class Exercicio07_IgorCosta
{
    static void Main()
    {
        int n;

        // laço para validar a entrada
        do
        {
            Console.WriteLine("Digite um numero maior que 2:");
            n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine("Numero invalido! Deve ser maior que 2.");
            }

        } while (n <= 2);

        // gera a sequência de Fibonacci
        int a = 1, b = 1;
        Console.Write("A sequencia de Fibonacci ate o {0} termo: {1},{2}", n, a, b);

        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.Write("," + c);
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}
