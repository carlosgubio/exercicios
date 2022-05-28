﻿using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, resultado;

            Console.WriteLine("Digite 3 numeros inteiros para descobrir o MDC.");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            resultado = Numero(n1, n2, n3);
            Console.WriteLine($"O MDC é: {resultado}");
        }
        static int Numero(int n1, int n2, int n3)
        {
            int contador = 2, resultado = 1;

            while (n1 > 1 || n2 > 1 || n3 > 1)
            {
                if (n1 % contador == 0 && n2 % contador == 0 && n3 % contador == 0)
                {
                    resultado *= contador;
                }
                if (n1 % contador == 0)
                {
                    n1 /= contador;
                }
                if (n2 % contador == 0)
                {
                    n2 /= contador;
                }
                if (n3 % contador == 0)
                {
                    n3 /= contador;
                }

                else contador++;
            }
            return resultado;
        }
    }
}
