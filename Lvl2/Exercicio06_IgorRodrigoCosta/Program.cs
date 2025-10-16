using System;

class Exercicio05_IgorCosta
{
    static void Main()
    {
        float num = 0;
        float soma = 0;
        float counter = 0;

        while (num != -1)
        {
            Console.WriteLine("Digite um numero (-1 para terminar):");
            num = float.Parse(Console.ReadLine());
            if (num != -1)
            {
                soma += num;
                counter++;
            }
        }
        float media = soma / counter;
            Console.WriteLine($"A media dos numeros fornecidos = {media:F2}");
        
    }
}
