using System;

namespace Equação
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            
            Console.WriteLine("insira o valor de a");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
             Console.WriteLine("A tem que ser maior que 0");
                return;
            }

            Console.WriteLine("insira o valor de b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o valor de c");
            c = Convert.ToInt32(Console.ReadLine());

            Double delta = (b * b) - (4 * a * c);
            Double raiz = Math.Sqrt(delta);
            if (delta < 0)
            {
                Console.WriteLine("Resultado negativo não há raiz real");
            }
            if (delta == 0)
            {
                Console.WriteLine("Delta = 0, só terá uma raiz" );
                Double x1 = (-b + raiz) / 2 * a;
                Console.WriteLine("o resultado x1 = " + x1);
            }

            if (delta > 0)
            {
                Double x1 = (-b + raiz) / 2 * a;
                Double x2 = (-b - raiz) / 2 * a;
                Console.WriteLine("o resultado x1 = " + x1);
                Console.WriteLine("o resultado x2 = " + x2);
            }







            // a 2    b 6   c  4












        }
    }
}
