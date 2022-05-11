using System;

namespace Vetores_Elementos_repetidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho do vetor");
            int tamanhovetor = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[tamanhovetor];
            int[] num1 = new int[tamanhovetor];
            int[] contarNumerosRepetidos = new int[tamanhovetor];
            int[] marcarEntradasRepetidas = new int[tamanhovetor];


            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Insira o valor: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
                num1[i] = num[i];
            }

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (i != j)
                    {
                        if (num[i] == num1[i] && marcarEntradasRepetidas[j] == 0)
                        {
                            contarNumerosRepetidos[i]++;
                            marcarEntradasRepetidas[i] = 1;
                            marcarEntradasRepetidas[j] = -1;
                        }
                    }
                }
            }

            for (int i = 0; i < contarNumerosRepetidos.Length; i++)
            {
                if (contarNumerosRepetidos[i] > 0 && marcarEntradasRepetidas[i] > 0)
                {
                    Console.WriteLine($"O elemento {num[i]} na posição {i} repete {contarNumerosRepetidos[i]} vezes.");
                }
            }
        }
    }
}
