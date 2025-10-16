using System;

class Exercicio10_IgorCosta
{
    static void Main()
    {
        Console.WriteLine("Digite o tamanho do lado do quadrado:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um caractere para formar o quadrado:");
        char c = char.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(c);
                if (j < n - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
