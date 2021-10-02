using System;

namespace exercicios_etec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o capital: ");
            string Capital = Console.ReadLine();

            Console.WriteLine("Digite a taxa de juros: ");
            string Taxa_Juros = Console.ReadLine();
            double Taxa_juros = Convert.ToDouble(Taxa_Juros) / 100;

            Console.WriteLine("Digite a quantidade de meses");
            string Meses = Console.ReadLine();

            double Juros = Convert.ToDouble(Capital) * Taxa_juros* Convert.ToDouble(Meses);
            double Montante = Convert.ToDouble(Capital) + Juros;

            Console.WriteLine($"Juros (R$) = {Juros:C2}");
            Console.WriteLine($"Montante (R$) = {Montante:C2}");


        }
    }
}
