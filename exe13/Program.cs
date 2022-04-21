using System;

namespace exe13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que leia 20 números e, ao final, escreva quantos estão entre 0 e 100, " +
                "quantos estão entre 101 e 200 e quantos são maiores de 200.");

            int i, n, a = 0, b = 0, c = 0;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um n°");
                n = int.Parse(Console.ReadLine());

                if (n >= 0 && n <= 100)
                {
                    a++;
                }
                else if ( n <= 200)
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }

            Console.WriteLine(a + " números estão entre 0 e 100.");
            Console.WriteLine(b + " números estão entre 101 e 200.");
            Console.WriteLine(c + " números são maiores de 200.");
        }
    }
}
