using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o número do usuário
        Console.WriteLine("Digite um número inteiro:");
        int num = int.Parse(Console.ReadLine());

        // Verifica se o número é par ou ímpar
        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}