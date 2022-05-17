using System;

namespace Função___divisores_entre_0_e_o_nº
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número para saber seus divisores.");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] divisor = numdivisor(num);

            for (int i = 0; i < divisor.Length; i++)
            {
                if (divisor[1] != 0)
                {
                    Console.WriteLine($"O divisor de {num} é {divisor[i]}");
                }
            }
        }

        static int[] numdivisor(int num)
        {
            int divisor, contador = 1;
            int[] divisor1 = new int[num];
            int[] divisor2 = new int[num];

            for (int i = 0; i < divisor1.Length; i++)
            {
                divisor1[i] = i;
                divisor = num % contador;

                if (divisor == 0)
                {
                    divisor2[i] = contador;
                }
                contador++;
            }
            return divisor2;
        }

    }
}
