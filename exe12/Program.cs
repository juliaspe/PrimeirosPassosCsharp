using System;

namespace exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que receba 20 números inteiros e ao final escreva quantos estão entre 0 e 100.");

            int i, n, s = 0;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um n°");
                n = int.Parse(Console.ReadLine());

                if (n > 0 && n < 100)
                {
                    s++;
                }
            }

            Console.WriteLine(s+" números estão entre 0 e 100");
           
        }
    }
}
