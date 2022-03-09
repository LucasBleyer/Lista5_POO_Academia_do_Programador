using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeCaixaRetangular.ConsoleApp
{
    internal class CaixaRetangular
    {
        public double largura;
        public double altura;
        public double comprimento;

        public double CalcularVolume()
        {
            double volume = largura * altura * comprimento;
            return Math.Round(volume, 2);
        }

    }
}
