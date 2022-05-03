using System;

namespace Ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Insira o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo um número");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número");
            num3 = Convert.ToInt32(Console.ReadLine());

            
            if (num1 > num2 && num1 > num3 && num2 > num3)
            {
                Console.WriteLine("A sequencia do maior para o menor é: " + num1 + num2 + num3);
            }
            if (num1 > num2 && num1 > num3 && num3 > num2)
            {
                Console.WriteLine("A sequencia do maior para o menor é: " + num1 + num3 + num2);
            }
                if (num2 > num1 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine("A sequencia do maior para o menor é: " + num2 + num1 + num3);
            }
            if (num3 > num1 && num3 > num2 && num2 > num1)
            {
                Console.WriteLine("A sequencia do maior para o menor é: " + num3 + num2 + num1);
            }
            
            
        }
            
    }
}
