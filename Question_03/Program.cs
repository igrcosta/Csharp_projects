using System;

// Nessa questão, vamos trabalhar com a função linear y = 4x + 5

class Questao03
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int x, result;
        Console.Write("Preciso de ajuda! eu nao sei fazer essa conta aqui:\n");
        Console.Write("y = 4x + 5\n");
        Console.Write("Me fala por favor um valor pra esse X que eu me viro\n");
        x = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("\nPerfeito! Agora vamo substituir esse valor e colocar mais 5!\n");
        result = 4 * x + 5;
        Console.WriteLine("O que resulta no seguinte:\n");
        Console.WriteLine("4 * " + x + "+ 5 =" + result);
    }
}
