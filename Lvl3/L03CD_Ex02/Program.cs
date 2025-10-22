using System;
using System.Collections.Generic;
//agora posso usar lista oia que legal

class L03CD_Ex02
{
    static void Main()
    {
        List<int> actualArray = new List<int>();
        //criamos uma lista dinâmica de inteiros 

        int ActualNumber = 2;

        Console.WriteLine("Digite o numero de series:");
        int ArrayQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i != ArrayQuantity; i++)
        {
            while (ActualNumber > 0)
            {
                int ArrayPosition = 0;

                if (ArrayPosition == 0)
                {
                    Console.WriteLine("Digite o " + ArrayPosition + 1 + " numero da " + i + 1 + " serie:");
                    ActualNumber = int.Parse(Console.ReadLine());
                    if (ActualNumber < 0)
                    {
                        Console.WriteLine("Nao existem numeros para essa serie!");
                        i++;
                    }
                    actualArray.Add(ActualNumber);
                    ArrayPosition++;
                }

                else if (ArrayPosition > 0)
                {
                    Console.WriteLine("Digite o " + ArrayPosition + 1 + " numero da " + i + 1 + " serie  (Flag valor negativo):");
                    ActualNumber = int.Parse(Console.ReadLine());
                    actualArray.Add(ActualNumber);
                    ArrayPosition++;
                }

            }

            int MinorNumber = 999999;
            foreach (var num in actualArray)
            {
                if (num < MinorNumber)
                {
                    MinorNumber = num;
                }
            }

        }
    }
}

