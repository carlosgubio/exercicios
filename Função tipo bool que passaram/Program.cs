using System;

namespace Função_tipo_bool_que_passaram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota = ArrayNota();
            bool[] retornar = CompararNota(nota);
            mostrarNota(nota, retornar);

            //for (int i = 0; i < retornar.Length; i++)
            //{
            //    Console.WriteLine($"Nota: {retornar[i]} {nota[i]}");
            //}

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
        static bool[] CompararNota(int[] nota)
        {
            bool aprovado;
            //int retorno;
            bool[] retornar = new bool[10];

            for (int i = 0; i < retornar.Length; i++)
            {
                //retorno = nota[i];
                aprovado = nota[i] >= 7;
                retornar[i] = aprovado;
            }
            return retornar;
        }
        static void mostrarNota(int[] nota, bool[] retornar)
        {
            for (int i = 0; i < retornar.Length; i++)
            {
                Console.WriteLine($"Nota: {retornar[i]} {nota[i]}");
            }
        }
    }

}
