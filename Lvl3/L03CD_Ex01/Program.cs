using System;
using System.Security.Cryptography.X509Certificates;
class L03CD_Ex01
{
    static void Main()
    {
        int n1 = 2;
        int n2 = 2;
        int winner = 0;

        bool Stop = false;

        while (!Stop)
        {
            Console.WriteLine("Digite o primeiro numero competidor:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero competidor:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 < 0 && n2 < 0)
            {
                Stop = true;
                Console.WriteLine("Numero maior de todos:" + winner);
                return;
            }

            if (n1 < n2)
            {
                Console.WriteLine("O numero " + n2 + " e o vencedor!");
                if (winner < n2)
                {
                    winner = n2;
                }
            }
            else
            {
                Console.WriteLine("O numero " + n1 + " e o vencedor!");
                if (winner < n1)
                {
                    winner = n1;
                }
            }
        }
    }
}