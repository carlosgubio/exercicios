using System;

namespace Revisão___Maior_valor_entre_2_entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite um número.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número.");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"O maior número entre os digitados é: {num1}");

            else if (num1 < num2)
                Console.WriteLine($"O maior número entre os digitados é:{num2}");

            else
                Console.WriteLine("Os números são iguais");
        }
    }
}
