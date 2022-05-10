using System;

namespace Função___Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double n1, n2, result;
            while (i > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o número referente à operação desejada: \n\n 1 - para adição \n 2 - para subtração \n 3 - para multiplicação \n 4 - para divisão \n 0 - para sair");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    Console.WriteLine("Programa Finalizado!");
                }
                if (i == 1)
                {
                    Console.WriteLine("Insira o primeiro número");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = adicao(n1, n2);
                    Console.WriteLine("O resultado da operação é: " + result);

                }
                if (i == 2)
                {
                    Console.WriteLine("Insira o primeiro número");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = subtracao(n1, n2);
                    Console.WriteLine("O resultado da operação é: " + result);

                }
                if (i == 3)
                {
                    Console.WriteLine("Insira o primeiro número");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = multiplicacao(n1, n2);
                    Console.WriteLine("O resultado da operação é: " + result);

                }
                if (i == 4)
                {
                    Console.WriteLine("Insira o primeiro número");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 <= 0)
                    {
                        Console.WriteLine("Não é permitido divisão por zero");
                        break;
                    }
                    result = divisao(n1, n2);
                    Console.WriteLine("O resultado da operação é: " + result);
                }
            }
        }
        static double adicao (double n1, double n2)
        {
            return n1 + n2;
        }
        static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
