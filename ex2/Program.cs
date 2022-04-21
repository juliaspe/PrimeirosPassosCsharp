using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pos = 0, neg = 0, zero = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite um n°:");
                n = (int)int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    pos++;
                }
                else if (n < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }
            
            Console.WriteLine("Foram digitados: "+pos+" números positivos, "+neg+" negativos e "+zero+" zeros");
        }
    }
}
