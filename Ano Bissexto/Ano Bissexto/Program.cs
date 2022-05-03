using System;

namespace Ano_Bissexto
{
    class Program
    {
        static void Main(string[] args)
        {

            int ano;
            bool bissexto;

            Console.WriteLine("Insira um ano para saber se ele é bissexto");
            ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0) {
                bissexto = true;              
            }

            else if ((ano % 4 == 0) && (ano % 100 != 0)) {
                bissexto = true;
            } 
            else
            {
                bissexto = false;
            }

            if (bissexto == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ano + " é ano bissexto");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ano + " não é ano bissexto");
            }

        }
    }
}
 //
 v
v
f