using System;

// Nessa questão, fiz uma calculadora para área de quadrados

class Questao01
{
    //método para rodar quando clicar no play
    static void Main()
    {
        double a, area;
            Console.Write("Digite o valor do lado: ");
            a = double.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            area = a * a;
            Console.WriteLine("Area: = " + area);
    }
}