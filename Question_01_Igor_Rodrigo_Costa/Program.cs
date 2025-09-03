using System;
class Questao01 {
    //método para rodar quando clicar no play
    static void Main()
    {
        int a, area;
        Console.Write("Olá! Vamos calcular a área de um quadrado?\nDigite S para sim e N para nao\n");
        String answer = Console.ReadLine();
        if (answer == "S" || answer == "s")
        {
            Console.Write("Perfeito! me diga o primeiro lado desse quadrado por favor!\n");
            a = int.Parse(Console.ReadLine());
            // Parse serve para converter formatos, no caso, temos uma string (texto do usuário) que vai virar int, por estar escrito int.Parse

            Console.Write("Agora que sei que " + answer + " é o valor do lado, basta fazer ele ao quadrado!\n");
            area = a * a;
            Console.WriteLine("O que resulta no seguinte:\n");
            Console.WriteLine(a + " * " + a + " = " + area);
        }
        if (answer == "N" || answer =="n")
        {
            Console.Write("Então tchau!\n");
        }
    }
}