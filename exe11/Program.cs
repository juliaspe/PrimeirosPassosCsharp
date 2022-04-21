using System;

namespace exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que receba 20 números inteiros e exiba quantos são maiores que 8.");

            int i, n, s = 0;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um n°:");
                n = int.Parse(Console.ReadLine());

                if (n > 8)
                {
                    s++;
                }
            }
            
            Console.WriteLine(s+" números são maiores que 8.");

        }
    }
}
