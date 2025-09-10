using System;

// Nessa questão, fiz uma calculadora para área de triângulos

class Questao02
{
    //método para rodar quando clicar no play
    static void Main()
    {
        float a, b, area;
            Console.Write("Digite o valor da base:\n");
            a = float.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            Console.Write("Digite o valor da altura:\n");
            b = float.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            area = a * b / 2;
            

            Console.Write($"Area do triangulo = {area:F2}");
        }
    }
