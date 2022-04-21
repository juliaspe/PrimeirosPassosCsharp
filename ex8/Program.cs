using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um algoritmo que leia o nome de uma pessoa e um número N e escreva o nome na tela N vezes.");

            int i, n;
            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite um nº:");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
