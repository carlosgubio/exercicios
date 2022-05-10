using System;

namespace Função_tipo_bool_que_passaram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota = ArrayNota();
                       
        }
        static int[] ArrayNota()
        {
            int[] nota = new int[10];
            int contador = 0;

            for (int i = 0; i < nota.Length; i++)
            {
                contador++;
                Console.WriteLine("Insira a nota do " + contador + "º aluno");
                nota[i] = Convert.ToInt32(Console.ReadLine());
            }
            return nota;
        }
        static int CompararNota(nota)
        {
            int[] Nota = new int[10];
            bool aprovado, reprovado;
            int retorno;

            for (int i = 0; i < nota.Length; i++)
            {
                aprovado = Nota[i] >= 7;
                reprovado = Nota[i] < 7;
            }
            retorno = Nota[];
            return Console.WriteLine(retorno);
        }
    }

}
