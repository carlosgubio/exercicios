using System;

namespace Array_de_10_posições_em_ordem_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema para retornar a ordem inversa dos números digitados");
            Console.WriteLine();
            int[] retorno = num();

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{retorno[i]}");
            }
        }
        static int[] num()
        {
            int[] num = new int[10];
            int contador = 0;
            
            for (int i = 0; i < num.Length; i++)
            {
                contador++;
                Console.WriteLine($"Insira o {contador} º número");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A ordem inversa dos números digitados é:");

            //Outra forma de fazer sem utilizar o return (retira int[] retorno = e retira o for na função main, apagando o return
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine($"{num[i]}");
            //}
            return num;
        }
    }
}


