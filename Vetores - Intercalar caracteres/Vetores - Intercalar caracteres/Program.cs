using System;

namespace Vetores___Intercalar_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] texto = new string[3];
            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine("--> Digite o texto");
                texto[i] = Console.ReadLine();
            }
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write($"{texto[i]} -OU- ");
            }

        }
    }
}
