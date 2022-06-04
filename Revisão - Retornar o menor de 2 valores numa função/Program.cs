using System;

namespace Revisão___Retornar_o_menor_de_2_valores_numa_função
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o 1º número.");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            n2 = Convert.ToInt32(Console.ReadLine());
             
            int resp = MenorNumero(n1, n2);
            Console.WriteLine($"O menor é {resp}");
        }
        static int MenorNumero(int n1, int n2)
        {
            if (n1 < n2)
                return n1;
            else
                return n2;
        }


    }
}
