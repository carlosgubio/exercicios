using System;

namespace Gubio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira seu nome:");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insira sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }

            Console.WriteLine("insira seu peso");
            Double Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insira sua altura");
            Double altura = Convert.ToDouble(Console.ReadLine());
            double IMC = (Peso / (altura * altura));

            Console.WriteLine("Seu IMC é " + IMC);
            Console.WriteLine("Se seu IMC estiver Entre 18,5 e 24,9, você está de parabéns!");


        }

    }


}

