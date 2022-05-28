using System;

namespace MMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, resultado;

            Console.WriteLine("Digite 3 numeros inteiros para descobrir o MMC");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            resultado = Numero(n1, n2, n3);
            Console.WriteLine($"O MMC é {resultado}");
        }
        static int Numero(int n1, int n2, int n3)
        {
            int contador = 2, resultado = 1;

            while (n1 > 1 || n2 > 1 || n3 > 1)
            {
                if (n1 % contador == 0 || n2 % contador == 0 || n3 % contador == 0)
                {
                    if (n1 % contador == 0)
                    {
                        n1 = n1 / contador;
                    }
                    if (n2 % contador == 0)
                    {
                        n2 = n2 / contador;
                    }
                    if (n3 % contador == 0)
                    {
                        n3 = n3 / contador;
                    }

                    resultado = resultado * contador;
                }
                else contador++;
            }
            return resultado;
        }
    }
}
