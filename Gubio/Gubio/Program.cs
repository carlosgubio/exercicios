using System;

namespace Gubio
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("insira o seu nome primeiro");
            String nome = Console.ReadLine();

            Console.WriteLine("insira o seu último sobrenome");
            String sobrenome = Console.ReadLine();
            
            Console.WriteLine("Seu nome e sobrenome é: " + nome + " " + sobrenome);


        }
    }
}
