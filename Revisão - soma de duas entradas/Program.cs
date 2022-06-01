using System;

namespace Revisão___soma_de_duas_entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
                        
            Console.WriteLine("Digite um número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine($"A soma dos dois números digitados é: {soma}");
        }
    }
}
