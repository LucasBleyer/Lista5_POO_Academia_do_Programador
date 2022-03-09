using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoCombustivel.ConsoleApp
{
    internal class ConsumoCombustivel
    {
        public double km_inicial;
        public double km_final;
        public double litros_inicial;
        public double litros_final;

        public double CalcularConsumo()
        {
            double consumo = (km_final - km_inicial) / (litros_inicial - litros_final);
            return Math.Round(consumo, 2);
        }
    }
}
