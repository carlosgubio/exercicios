using System;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            Console.WriteLine("Para criar um triângulo e saber que tipo ele é, siga as instruções abaixo:");
            Console.WriteLine("digite o primeiro lado");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo lado");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o terceiro lado");
            lado3 = Convert.ToDouble(Console.ReadLine());

            var triangulo = (lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2);

            if (triangulo)
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isóceles");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
            
        }
    }   
}
