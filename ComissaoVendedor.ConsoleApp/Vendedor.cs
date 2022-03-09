using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissaoVendedor.ConsoleApp
{
    internal class Vendedor
    {
        public double salario;
        public int total_vendas;
        public double percetual_total_vendas;

        public double CalcularComissao()
        {
            double comissao = salario + (total_vendas * (percetual_total_vendas / 100));
            return Math.Round(comissao, 2);
        }
    }
}
