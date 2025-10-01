
using System;

class Exercicio01_IgorCosta
{
    static void Main()
    {
        int num;
        //número que vou utilizar


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string 
            // (texto do usuário) que vai virar int, por estar escrito int.Parse

            Console.WriteLine("O triplo de " + num + " = " + 3 * num);
        }
    }
}
