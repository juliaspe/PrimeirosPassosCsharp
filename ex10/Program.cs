using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que receba um número inteiro e mostre sua tabuada");

            int i, n, result;

            Console.WriteLine("Digite um nº");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
                result = 0;
            }
        }
    }
}
