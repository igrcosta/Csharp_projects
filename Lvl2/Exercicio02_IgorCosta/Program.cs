using System;

class Exercicio02_IgorCosta
{
    static void Main()
    {
        int num;
        int counter = 0;

        Console.WriteLine("Digite o valor inicial:");
            num = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        // (texto do usuário) que vai virar int, por estar escrito int.Parse


        while (counter < 10)
        {
            if (num % 2 == 0)
            {

            }
            else
            {
                Console.Write(num + ",");
                counter++;
            }
            num++;
        }
    }
}
