using System;

namespace Numero_indefinido_de_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0; 
            double soma = 0;
            double med;
            double contador = 0;

            Console.WriteLine("Para saber a média, insira um número negativo");
            num = Convert.ToDouble(Console.ReadLine());
           
            while (num >= 0)
            {
                soma = soma + num;
                //contador = contador + 1;
                contador++;
                Console.WriteLine("Para saber a média, insira um número negativo");
                num = Convert.ToDouble(Console.ReadLine());
            }
            med = soma / contador;
            Console.WriteLine("A média é: " + med);
                       
        }
    }
}
