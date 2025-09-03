using System;

// Nessa questão, fiz uma calculadora para área de triângulos

class Questao02
{
    //método para rodar quando clicar no play
    static void Main()
    {
        int a, b, area;
        Console.Write("Olá! Vamos calcular a área de um triangulo?\nDigite S para sim e N para nao\n");
        String answer = Console.ReadLine();
        if (answer == "S" || answer == "s")
        {
            Console.Write("Perfeito!\nMe diga o tamanho dessa base por favor!\n");
            a = int.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            Console.Write("Certo, decorei o " + a + " para a base\nAgora, me diga o valor da altura dele!\n");
            b = int.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            area = a * b / 2;

            Console.Write("Agora, vamos pegar esses valores e calcular!\n" + a + " * " + b + " /2  = " + area + "\n");
        }
        if (answer == "N" || answer == "n")
        {
            Console.Write("Então tchau!\n");
        }
    }
}