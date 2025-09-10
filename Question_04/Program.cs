using System;

// Nessa questão, vamos trabalhar com uma calculadora de somas, ele vai ler três números fornecidos e dar a soma

class Questao04
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int x, y, result;
        Console.Write("Digite o 1 valor:");

        x = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("\nDigite o 2 valor:");
        y = int.Parse(Console.ReadLine());

        result = x + y;

        Console.Write("\n Soma = " + result);
    }
}
