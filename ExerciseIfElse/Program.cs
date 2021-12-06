using System;
using System.Globalization;

namespace ExerciseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double cod1 = 4.00, cod2 = 4.50, cod3 = 5.00, cod4 = 2.00, cod5 = 1.50, total = 0;

            Console.WriteLine("CODIGO   ESPECIFICAÇÃO      PREÇO");
            Console.WriteLine("1       Cachorro Quente     R$ " + cod1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("2       X-Salada            R$ " + cod2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("3       X-Bacon             R$ " + cod3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("4       Torrada simples     R$ " + cod4.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("5       Refrigerante        R$ " + cod5.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Digite o código e a quantidade que deseja separado por um espaço");

            string[] entradas = (Console.ReadLine().Split(' '));
            int escolha = int.Parse(entradas[0]);
            int qtde = int.Parse(entradas[1]);

            if (escolha == 1)
            {
                total = cod1 * qtde;
            }
            else if (escolha == 2)
            {
                total = cod2 * qtde;
            }
            else if (escolha == 3)
            {
                total = cod3 * qtde;
            }
            else if (escolha == 4)
            {
                total = cod4 * qtde;
            }
            else
            {
                total = cod5 * qtde;
            }

            Console.WriteLine("Total a pagar R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
//resolved by lima-luciano on 11/14/2021