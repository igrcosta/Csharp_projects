using System;

// Nessa questão, vamos trabalhar com uma calculadora de medias,
//ele vai ler três números fornecidos, e fazer a media dessa soma

class Questao05
{
    //método para rodar quando clicar no play
    static void Main()
    {
        float x, y, z, soma, result;
        Console.Write("Digite o 1 Numero:\n");

        x = float.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("Digite o 2 Numero:\n");
        y = float.Parse(Console.ReadLine());

        Console.Write("Digite o 3 Numero:\n");
        z = float.Parse(Console.ReadLine());

        soma = x + y + z;
        result = soma/3;

        Console.Write($"A media dos valores {x:F1},{y:F1} e {z:F1} = { result:F3}");
    }
}
