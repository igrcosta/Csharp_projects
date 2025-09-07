using System;

// Nessa questão, vamos trabalhar com uma calculadora de medias,
//ele vai ler três números fornecidos, e fazer a media dessa soma

class Questao05
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int x, y, z, soma, result;
        Console.Write("Preciso de ajuda! Vamo calcular uma media de tres numeros:\n");
        Console.Write("Me fala o primeiro numero:\n");

        x = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("Perfeito! vc escolheu " + x + "\nAgora o segundo:\n");
        y = int.Parse(Console.ReadLine());

        Console.Write("\nCerto, temos\n" + x + " e " + y + "\nVamo pro último:\n");
        z = int.Parse(Console.ReadLine());

        soma = x + y + z;
        result = soma/3;

        Console.Write("\nAgora, vamos somar isso tudo e dividir por 3!\nE deu o resultado...\n" + result);
    }
}
