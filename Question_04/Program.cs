using System;

// Nessa questão, vamos trabalhar com uma calculadora de somas, ele vai ler três números fornecidos e dar a soma

class Questao04
{
    //método para rodar quando clicar no play
    static void Main()
    {
        float x, y, z, result;
        Console.Write("Digite o 1 Valor:");

        x = float.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("\nDigite o 2 Valor:");
        y = float.Parse(Console.ReadLine());

        Console.Write("\nDigite o 3 Valor:\n");
        z = float.Parse(Console.ReadLine());

        result = x + y + z;

        Console.Write($" Soma de {x:F1}+{y:F1}+{z:F1}={ result:F1}");
    } 
}
