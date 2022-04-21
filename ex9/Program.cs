using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que receba 10 números inteiros e ao final mostre a soma de todos os números digitados.");

            int n, i, soma = 0;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um nº");
                n = int.Parse(Console.ReadLine());

                soma = soma + n;
            }

            Console.WriteLine("A soma dos números é: "+soma);

        }
    }
}
