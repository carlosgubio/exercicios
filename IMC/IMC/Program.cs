using System;

namespace Gubio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("insira seu peso em Kg");

            Double Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insira sua altura em M");

            Double altura = Convert.ToDouble(Console.ReadLine());
            double IMC = (Peso / (altura * altura));

            Console.WriteLine("Seu IMC é " + IMC);
            
            if (IMC <= 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (IMC <= 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (IMC <= 25)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (IMC <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (IMC <= 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }

            //Console.WriteLine("Se seu IMC estiver Entre 18,5 e 24,9, você está de parabéns!");


        }

    }


}
