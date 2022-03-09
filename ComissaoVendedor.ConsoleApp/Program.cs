//ex 7
using System;

namespace ComissaoVendedor.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.salario = 2500;
            vendedor.total_vendas = 200;
            Console.Write("Informe o percentual de vendas: ");
            vendedor.percetual_total_vendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário com a comissão: " + vendedor.CalcularComissao());

        }
    }
}
