using System;

namespace Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sal;

            Console.WriteLine("Qual o salário?");
            sal = Convert.ToInt32(Console.ReadLine());

              if (sal <= 1200)
            {
                Double aumento = (sal * 20 / 100);
                Double reajuste = sal + aumento;
                Double Dolar = (reajuste * 4.75);
                Double Euro = (reajuste * 5.20);
                Console.WriteLine("O salário foi reajustado para: " + reajuste);
                Console.WriteLine("seu salário em Dólar é de: " + Dolar);
                Console.WriteLine("seu salário em Euro é de: " + Euro);

            }

            if (sal > 1200 && sal < 2000)
            {
                Double aumento = (sal * 13 / 100);
                Double reajuste = sal + aumento;
                Double Dolar = (reajuste * 4.75);
                Double Euro = (reajuste * 5.20);
                Console.WriteLine("O salário foi reajustado para: " + reajuste);
                Console.WriteLine("seu salário em Dólar é de: " + Dolar);
                Console.WriteLine("seu salário em Euro é de: " + Euro);
            }

            if (sal > 2000 && sal < 2500)
            {
                Double aumento = (sal * 10 / 100);
                Double reajuste = sal + aumento;
                Double Dolar = (reajuste * 4.75);
                Double Euro = (reajuste * 5.20);
                Console.WriteLine("O salário foi reajustado para: " + reajuste);
                Console.WriteLine("seu salário em Dólar é de: " + Dolar);
                Console.WriteLine("seu salário em Euro é de: " + Euro);
            }

            if (sal > 2500)
            {
                Double aumento = (sal * 5 / 100);
                Double reajuste = sal + aumento;
                Double Dolar = (reajuste * 4.75);
                Double Euro = (reajuste * 5.20);
                Console.WriteLine("O salário foi reajustado para: " + reajuste);
                Console.WriteLine("seu salário em Dólar é de: " + Dolar);
                Console.WriteLine("seu salário em Euro é de: " + Euro);
            }


        }
    }
}
