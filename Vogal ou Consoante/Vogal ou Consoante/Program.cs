using System;

namespace Vogal_ou_Consoante
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;   
            
            Console.WriteLine("Insira uma letra e descubra se ela é uma vogal ou uma consoante");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("A letra " + letra + " é uma vogal");
            }
            else if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("A letra " + letra + " é uma vogal");
            }
            else
            {
                Console.WriteLine("A letra " + letra + " é uma consoante");
            }
        }
    }
}
