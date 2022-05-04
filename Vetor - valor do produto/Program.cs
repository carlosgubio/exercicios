using System;

namespace Vetor___valor_do_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] produto1 = new int[5];
            int[] produto2 = new int[5];
            int[] produto3 = new int[5];

            for (int i = 0; i < produto1.Length; i++)
            {
                Console.WriteLine("Valor do primeiro produto");
                produto1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < produto2.Length; i++)
            {
                Console.WriteLine("Valor do segundo produto");
                produto2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < produto3.Length; i++)
            {
                produto3[i] = produto1[i] * produto2[i];
                Console.WriteLine("O valor dos produtos multiplicados é: " + produto3[i]);
            }
        }
    }
}

