using System;

namespace _3_notas_de_10_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aluno = new int[10];
            int contador = 0;

            for (int i = 0; i < aluno.Length; i++)
            {
                contador++;
                Console.WriteLine($"Insira a nota do {contador}º aluno");
                aluno[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int nota()
        {
            int[] notas = new int[10];
            int contador = 0;
            
            for (int i = 0; i < notas.Length; i++)
            {
                contador++;
                Console.WriteLine($"Insira a nota do {contador}º aluno");
                aluno1[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        

            
    }
}
