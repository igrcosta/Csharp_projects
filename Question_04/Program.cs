using System;

// Nessa questão, vamos trabalhar com uma calculadora de somas, ele vai ler três números fornecidos e dar a soma

class Questao04
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int x, y, z, result;
        Console.Write("Preciso de ajuda! Vamo calcular uma soma de tres numeros:\n");
        Console.Write("Me fala o primeiro dessa soma:\n");

        x = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("Perfeito! vc escolheu " + x + "\nAgora o segundo:\n");
        y = int.Parse(Console.ReadLine());

        Console.Write("\nCerto, temos\n" + x + " e " + y + "\nVamo pro último:\n");
        z = int.Parse(Console.ReadLine());

        result = x + y + z;

        Console.Write("\nAgora, vamos somar!\nE deu o resultado...\n" + result);
    }
}
