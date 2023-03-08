//Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),escreva um programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE:
//Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;


using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê um número inteiro informado pelo usuário
        Console.Write("Informe um número inteiro: ");
        int n = int.Parse(Console.ReadLine());

        // Inicializa as variáveis da sequência
        int a = 0;
        int b = 1;

        // Realiza o cálculo da sequência até o número informado
        while (b <= n)
        {
            if (b == n)
            {
                Console.WriteLine(n + " pertence à sequência de Fibonacci!");
                break;
            }
            int c = a + b;
            a = b;
            b = c;
        }

        // Caso o número não pertença à sequência
        if (b > n)
        {
            Console.WriteLine(n + " não pertence à sequência de Fibonacci.");
        }
    }
}
