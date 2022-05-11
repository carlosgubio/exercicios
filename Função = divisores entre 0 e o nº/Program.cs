using System;

namespace Função___divisores_entre_0_e_o_nº
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número para saber seus divisores entre 0 e ele mesmo.");
            int num = Convert.ToInt32(Console.ReadLine());
        }

        static int divisor(int num)
        {

            int divisao = 0;

            while (num >= 0)
            {
                divisao = num / num;
                Console.WriteLine("o resultado é:" + divisao);
            }
            return num;



        }
    }
}
