using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que receba um número e mostre uma contagem de 0 até o número recebido.");

            int i, n;
            Console.WriteLine("Digite um n°:");
            n = int.Parse(Console.ReadLine());

            for(i = 0;i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
