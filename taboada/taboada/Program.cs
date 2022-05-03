using System;
namespace Tabuada
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Números
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            int NUM, CONT, TAB;
            // Inicialização de Variáveis
            CONT = 1;
            TAB = 0;
            // Solicita e lê o número fornecido pelo usuário
            Console.Write("Informe o número desejado: ");
            NUM = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            // Estrutura de repetição while executando a tabuada
            while (CONT <= 10)
            {
                TAB = NUM * CONT;
                Console.WriteLine("A Tabuada do número {0} X {1} é: {2} \n", NUM, CONT, TAB);
            CONT = CONT + 1;
            }
        } // Fim do Método Main
    } // Fim da Classe Números
}

