using System;

// Nessa questão, vamos trabalhar com uma calculadora de volume de Cilindros,
//ele vai ler o valor da altura(h) e o raio da base(r) e aplicar a formula
// formula do cilindro (pi * raio ao quadrado * altura)

class Questao06
{
    //método para rodar quando clicar no play
    static void Main()
    {
        float h, r, pi, result;

        pi =3.14159f;

        Console.Write("Digite o valor da altura:\n");

        h = float.Parse(Console.ReadLine());
        // Parse serve para converter formatos, no caso, temos uma string 
        //(texto do usuário) que vai virar int, por estar escrito int.Parse

        Console.Write("Digite o valor do raio:\n");
        r = float.Parse(Console.ReadLine());

        result = pi * r * r * h;

        Console.Write($"O Volume do cilindro:{result:F3}");
    }
}
