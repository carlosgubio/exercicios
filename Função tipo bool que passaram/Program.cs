using System;

namespace Função_tipo_bool_que_passaram
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double aprovado = 7;
        }
        static double nota()
        {
            double[] nota = new double[10];
            int contador = 0;

            for (double i = 0; i < nota.Length; i++)
            {
                contador++;
                Console.WriteLine("Insira a nota do " + contador + "º aluno");
                nota[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            return maior;
        }
    }

}
