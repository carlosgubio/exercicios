using System;

namespace Array_de_10_posições_em_ordem_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int inversa = num();
        }
        static int num()
        {
            int[] num = new int[10];
            int contador = 0;
            int inversa = 0;

            for (int i = 0; i < num.Length; i++)
            {
                contador++;
                Console.WriteLine($"Insira o {contador} º número");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int num2 = 10; num2 > 0; num2--)
            {
                Console.WriteLine(num2);
            }
            return inversa;
        }
    }
}


