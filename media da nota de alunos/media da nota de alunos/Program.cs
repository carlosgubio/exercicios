using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nota = new int[10];
            int soma = nota[0];
            int media;
            int menor = 10;
            int maior = 0;
            int i = 0;
                       
           
            while (i < nota.Length)
            {
                Console.WriteLine("Introduza a nota do aluno");
                nota[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + nota[i];
               

                if (menor > nota[i])
                {
                    menor = nota[i];
                }
                 
                if (maior < nota[i])
                {
                    maior = nota[i];
                }
                i++;
            }
            media = soma / nota.Length;
            Console.WriteLine("media das notas é = " + media);
            Console.WriteLine("A menor nota é: " + menor);
            Console.WriteLine("A maior nota é: " + maior);

        }
    }
}