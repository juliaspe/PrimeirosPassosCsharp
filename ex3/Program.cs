using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, par = 0, imp = 0, i;

            for(i = 0;i < 10; i++)
            {
                Console.WriteLine("Digite um n°:");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    par++;
                }
                else
                {
                    imp++;
                }
            }
            
            Console.WriteLine(par + " números pares e " + imp + " números impares.");
        }
    }
}
