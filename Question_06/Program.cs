using System;

// Nessa questão, vamos trabalhar com uma calculadora de volume de Cilindros,
//ele vai ler o valor da altura(h) e o raio da base(r) e aplicar a formula
// formula do cilindro (pi * raio ao quadrado * altura)

class Questao06
{
    //método para rodar quando clicar no play
    static void Main()
    {
        double h, r, pi, result;

        pi = 3.14159;

        Console.Write("Preciso de ajuda! Vamo calcular o volume de um cilindro:\n");
        Console.Write("Me fala a altura dele\n");

        h = int.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("\nPerfeito! vc escolheu " + h + "\nAgora me fala o raio da base dele:\n");
        r = int.Parse(Console.ReadLine());

        Console.Write("\nCerto, temos\n" + h + " e " + r + "\nAgora, deixa comigo!\n");

        result = pi * r * r * h;

        Console.Write("\nVamos pegar pi, multiplicar pelo raio ao quadrado, depois multiplicar pela altura...\nIsso daria o resultado de: " + result);
    }
}
