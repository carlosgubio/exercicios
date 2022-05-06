using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int nota;
            int soma = 0;
            int contador = 0;
            int media;
            int menor;
            int maior;

            while (contador < 10)
            {
                contador++;
                Console.WriteLine("Introduza a nota do aluno" + contador + ": ");
                linha = Console.ReadLine();
                nota = Int32.Parse(linha);
                soma = soma + nota;
            }
            media = soma / contador;
            Console.WriteLine("media das notas é =  " + media);

            for (nota = 0; nota < 10; nota++) ;




        }
    }
}
