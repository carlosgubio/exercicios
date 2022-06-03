using System;

namespace Revisão___multiplicar_cada_posição_pelo_seu_indice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int cont = 0;

            for (int i = 0; i < num.Length; i++)
            {
                cont++;
                Console.WriteLine($"digite o {cont}º número");
                num[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num[i] * i);
                
            }
        }
    }
}
