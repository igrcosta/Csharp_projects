using System;

class Exercicio04_IgorCosta
{
    static void Main()
    {
        int negocio = 1;
        int num;
        int result = 1;

        Console.WriteLine("Digite um numero:");
        num = int.Parse(Console.ReadLine());

        while (negocio <= num)
        {
            result = result * negocio;
            negocio++;
        }

        Console.WriteLine("O fatorial de " + num + " = " + result);
    }
}
