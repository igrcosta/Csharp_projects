using System;

class Exercicio08_IgorCosta
{
    static void Main()
    {
        Console.WriteLine("Digite um numero para ver sua tabuada:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($" {n} x  {i} =   {n * i}");
        }
    }
}
