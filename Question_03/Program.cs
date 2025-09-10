using System;

// Nessa questão, vamos trabalhar com a função linear y = 4x + 5

class Questao03
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int x, result;
        Console.Write("Digite o valor de x:\n");
        x = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

        result = 4 * x + 5;
        Console.WriteLine("Y="+ result);
    }
}
