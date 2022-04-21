using System;

namespace exe15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uma loja de animais vende gatos e cachorros. Escreva um algoritmo que leia a " +
                "quantidade de animais da loja e, para cada animal, leia a informação do tipo do animal (se é gato ou cachorro)." +
                "Ao final, exiba a quantidade de animais que são gatos e a quantidade de animais que são cachorros existentes na loja");

            int i, q, dog = 0, cat = 0;
            string tipo;

            Console.WriteLine("Digite a quantidade de animais:");
            q = int.Parse(Console.ReadLine());

            for (i = 0; i < q; i++)
            {
                Console.WriteLine("Digite G para gato e C para cachorro");
                tipo = Console.ReadLine();

                switch (tipo)
                {
                    case "G":
                        cat++;
                        break;
                    case "C":
                        dog++;
                        break;
                }
            }
            Console.WriteLine(dog + " cachorros | " + cat + " gatos");

        }
    }
}
