using System;

class Exercicio05_IgorCosta
{
    static void Main()
    {
        int num = 0;
        int soma = 0;

        while (num != -1)
        {
            Console.WriteLine("Digite um numero (-1) para ternimar:");
            num = int.Parse(Console.ReadLine());
            if (num != -1)
            {
                soma += num;
            }
        }
            Console.WriteLine("A soma dos numeros fornecidos = " + soma);
        
    }
}
