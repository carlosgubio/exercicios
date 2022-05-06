using System;

namespace Gubio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1;

            bool resultadoInt;

            Console.WriteLine("insira o primeiro número");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira a operação");
            String operacao = Console.ReadLine();

            Console.WriteLine("insira o segundo número");
            b1 = Convert.ToInt32(Console.ReadLine());

            if (operacao == "+")
            {
                int result = a1 + b1;
                Console.WriteLine("O resultado da operação é = " + result);
            }

            if (operacao == "-")
            {
                int result = a1 - b1;
                Console.WriteLine("O resultado da operação é = " + result);
            }

            if (operacao == "*")
            {
                int result = a1 * b1;
                Console.WriteLine("O resultado da operação é = " + result);
            }
            if (operacao == "/")
            {
                int result = a1 / b1;
                Console.WriteLine("O resultado da operação é = " + result);

            }
        }
    }
}
