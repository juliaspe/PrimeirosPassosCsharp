using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que mostre a soma de todos os números de 0 até 50.");

            int i, soma = 0;

            for (i = 0; i <= 50; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("A soma dos números são: "+soma);
        }
    }
}
