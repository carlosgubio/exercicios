using System;

namespace _3_notas_de_10_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas1 = new double[10];
            double[] notas2 = new double[10];
            double[] notas3 = new double[10];
            double[] notaSala = new double[30];
            double nota;
            int contador = 1;
            int p = 0;
            

            for (int i = 0; i < notas1.Length; i++)
            {

                Console.WriteLine($"Insira a primeira nota do {contador}º aluno.");
                nota = Convert.ToDouble(Console.ReadLine());
                notaSala[p] = nota;
                notas1[i] = nota;
                p++;


                Console.WriteLine($"Insira a segunda nota do {contador}º aluno.");
                nota = Convert.ToDouble(Console.ReadLine());
                notaSala[p] = nota;
                notas2[i] = nota;
                p++;


                Console.WriteLine($"Insira a terceira nota do {contador}º aluno.");
                nota = Convert.ToDouble(Console.ReadLine());
                notaSala[p] = nota;
                notas3[i] = nota;
                p++;
                contador++;
            }
            media(notas1, notas2, notas3);
        }
        static void media(double[] notas1, double[] notas2, double[] notas3)
        {
            double media;
            double notaMaior;
            double notaMenor;
            double total;
            int contador = 1;

            for (int i = 0; i < notas1.Length; i++)
            {
                notaMenor = 10;

                if (notaMenor > notas1[i])
                {
                    notaMenor = notas1[i];
                }
                if (notaMenor > notas2[i])
                {
                    notaMenor = notas2[i];
                }
                if (notaMenor > notas3[i])
                {
                    notaMenor = notas3[i];
                }

                notaMaior = 0;

                if (notaMaior < notas1[i])
                {
                    notaMaior = notas1[i];
                }
                if (notaMaior < notas2[i])
                {
                    notaMaior = notas2[i];
                }
                if (notaMaior < notas3[i])
                {
                    notaMaior = notas3[i];
                }

                total = notas1[i] + notas2[i] + notas3[i];
                media = (total - notaMenor) / 2;
                Console.WriteLine($"A maior nota do {contador}º aluno é {notaMaior}, a menor nota é {notaMenor} e a média é {media}");
                contador++; 
            
            }

         }

       

    }
}
