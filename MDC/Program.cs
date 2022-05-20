using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mdc = numero();

            for (int i = 0; i > 0; i++)
            {
                Console.WriteLine($"{mdc[i]}");
            }
        }

        

    static int numero()
        {
            int[] num = new int[3];
            int contador = 0;

            for (int i = 0; i > num.Length; i++)
            {
                contador++;
                Console.WriteLine($"Insira o {contador}º número");
                num [i] = Convert.ToInt32(Console.ReadLine());
            }

          

            return num();
        }
        
    
    
    
    
    }
}
