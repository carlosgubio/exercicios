using System;

namespace Vetor___Transação_bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            double saque, deposito, transferencia;
            int[] usuario = new int[] { 1, 2, 3, 4, 5 };
            double[] valor = new double[] { 100, 200, 300, 400, 500 };
            Console.WriteLine("Digite a opção desejada: \n\n 1-Saque \n 2-Deposito \n 3-Transferência \n 0-Sair");
            double opcao = Convert.ToDouble(Console.ReadLine());

            if (opcao == 0)
            {
                Console.WriteLine("Programa Finalizado!");
            }
            if (opcao == 1)
            {
                Console.WriteLine("Insira sua conta.");
                int nome = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < usuario.Length; i++)
                {
                    if (nome == usuario [i])
                    {
                        Console.WriteLine("Qual o valor do saque?");
                        saque = Convert.ToDouble(Console.ReadLine());
                        if (saque > valor[i])
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        if (saque < valor[i] || saque == valor[i])
                        {
                            valor[i] = valor[i] - saque;
                            Console.WriteLine("Saque realizado com sucesso! Seu saldo atual é de R$ " + valor [i]);
                        }
                    }
                }
            }

            if (opcao == 2)
            {
                Console.WriteLine("Conta a receber o depósito.");
                deposito = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < usuario.Length; i++)
                {
                    if (deposito == usuario[i])
                    {
                        Console.WriteLine("Valor a ser depositado.");
                        deposito = Convert.ToDouble(Console.ReadLine());
                        valor[i] = valor[i] + deposito;
                        Console.WriteLine($"A conta {usuario[i]} recebeu um depósito de R$ " + deposito + $".");
                        Console.WriteLine("Deposito realizado com sucesso!");
                        //Console.WriteLine($"Seu saldo atual é de R$ {valor[i]}.");
                    }
                }
            }
            
            if (opcao == 3)
            {
                Console.WriteLine("Insira sua conta.");
                int contadebitada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a conta rebedora.");
                int contacreditada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Valor da transferência.");
                transferencia = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < usuario.Length; i++)
                {
                    if (transferencia > valor[i])
                    {
                        Console.WriteLine("Saldo insuficiente.");
                        break;
                    }
                    else if (contadebitada == usuario[i])
                    {
                        valor[i] = valor[i] - transferencia;
                        Console.WriteLine($"Foi transferido da conta {usuario[i]} um valor de R$ " + transferencia + $". Seu saldo atual é de R$ {valor[i]}.");
                        Console.WriteLine("Transferência realizada com sucesso!");
                    }
                    if (contacreditada == usuario[i])
                    {
                        valor[i] = valor[i] + transferencia;
                        Console.WriteLine($"A conta {usuario[i]} recebeu uma transferência no valor de R$ " + transferencia + $".");
                        //Console.WriteLine($"Seu saldo atual é de R$ {valor[i]}.");
                    }
                }
            }
        }
    }
}
