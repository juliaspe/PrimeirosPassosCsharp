using System;

namespace exe14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um algoritmo que leia a quantidade de alunos em uma turma. " +
                "Em seguida, para cada aluno, leia a informação de suas 2 notas, calcule a média " +
                "e informe se o aluno está aprovado ou reprovado.O aluno está aprovado apenas se a sua média for maio ou igual a 6.");


            int n, n1, n2;
            double med;


            Console.WriteLine("Digite a quantidade de alunos:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a nota 1:");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota 2:");
                n2 = int.Parse(Console.ReadLine());

                med = (n1 + n2) / 2;
                if(med >= 6)
                {
                    Console.WriteLine("Aluno Aprovado. Parabens!!");
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado.");
                }

                n1 = 0;
                n2 = 0;
                med = 0;
            }
        }
    }
}
