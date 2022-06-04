using System;

namespace Revisão___função_com_a_soma_de_2_nº
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resp;
            
            Console.WriteLine("Insira o 1º número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Insira o 2º número");
            num2 = Convert.ToInt32(Console.ReadLine());
            resp = Soma(num1, num2);
            Console.WriteLine($"A soma é {resp}");
            
        }
        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
