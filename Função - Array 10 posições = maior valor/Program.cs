using System;

namespace Função___Array_10_posições___maior_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            double teste = num();
            Console.WriteLine("O maior número é: " + teste);

        }
        static double num()
        {
            int[] num = new int[10];
            double maior = 0;
            int contador = 0;


            for (int i = 0; i < num.Length; i++)
            {
                contador++;
                Console.WriteLine("Insira o " + contador + "º número");
                num[i] = Convert.ToInt32(Console.ReadLine());
            if (maior < num[i])
                {
                    maior = num[i];
                }
            }
            return maior;
        }
    }
}
