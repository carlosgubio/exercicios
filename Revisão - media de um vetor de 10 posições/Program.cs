using System;

namespace Revisão___media_de_um_vetor_de_10_posições
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = Media();
            Console.WriteLine($"A média é {soma}");

        static int Media()
        {
                int[] entrada = new int[10];
                int media;
                int soma = 0;
                Random random = new Random();

                for (int i = 0; i < entrada.Length; i++)
                {
                    entrada[i] = random.Next(0,10);
                    Console.WriteLine(entrada[i]);
                }
                for (int i = 0; i < entrada.Length; i++)
                {
                    soma += entrada[i];
                }
                soma /= entrada.Length;
                return soma;
            }
        }
    }
}
