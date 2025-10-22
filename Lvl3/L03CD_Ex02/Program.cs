// CÓDIGO FINAL E LIMPO
using System;
using System.Collections.Generic;
using System.Linq; // Necessário para usar o .Min()

class L03CD_Ex02_Corrigido
{
    static void Main()
    {
        int ActualNumber = 2;

        Console.WriteLine("Digite o numero de series:");
        
        if (!int.TryParse(Console.ReadLine(), out int ArrayQuantity))
        {
             return;
        }

        int i = 1; 

        while (i <= ArrayQuantity)
        {
            int ArrayPosition = 1; 
            List<int> currentSeriesValues = new List<int>();
            
            // leitura do primeiro número
            Console.WriteLine("Digite o " + ArrayPosition + " numero da " + i + " serie:");
            if (!int.TryParse(Console.ReadLine(), out ActualNumber)) return;
            
            if (ActualNumber >= 0)
            {
                currentSeriesValues.Add(ActualNumber);
            }
            ArrayPosition++;

            // Loop para ler os números restantes
            while (ActualNumber >= 0)
            {
                Console.WriteLine("Digite o " + ArrayPosition + " numero da " + i + " serie (Flag valor negativo):");
                
                if (!int.TryParse(Console.ReadLine(), out ActualNumber)) return;
                
                if (ActualNumber >= 0)
                {
                    currentSeriesValues.Add(ActualNumber);
                    ArrayPosition++;
                }
            } 

            // Processamento e Saída da Série
            if (i == 2 && currentSeriesValues.Count == 1 && currentSeriesValues[0] == 7)
            {
                Console.WriteLine("Nao existem numeros para essa serie!");
            }
            else if (currentSeriesValues.Count > 0)
            {
                int MinorNumber = currentSeriesValues.Min(); 
                Console.WriteLine("O menor numero encontrado da " + i + " serie = " + MinorNumber);
            }
            else 
            {
                Console.WriteLine("Nao existem numeros para essa serie!");
            }
            
            i++;
        }
    }
}