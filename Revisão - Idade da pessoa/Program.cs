using System;

namespace Revisão___Idade_da_pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anoNasc;

            Console.WriteLine("Digite o seu ano de nascimento");
            anoNasc = Convert.ToInt32(Console.ReadLine());

            //idade = 2022 - anoNasc;
            //Console.WriteLine($"Você tem {idade} anos de idade.");
            // ou
            int res = DateTime.Now.Year - anoNasc;
            Console.WriteLine($"Você tem {res} anos de idade.");
        }
    }
}
