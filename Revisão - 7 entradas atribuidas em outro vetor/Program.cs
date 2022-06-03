using System;

namespace Revisão___7_entradas_atribuidas_em_outro_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[7];
            int[] vetor2 = new int[7];
            int cont = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                cont++;
                Console.WriteLine($"Digite o {cont} numero");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor2[i] = vetor1[i];
                Console.WriteLine(vetor2[i]);
            }
        }
    }
}
