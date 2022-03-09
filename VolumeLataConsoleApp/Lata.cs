using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeLataConsoleApp
{
    internal class Lata
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            double volume = 3.14 * Math.Pow(raio, 2) * altura;
            return Math.Round(volume, 2);
        }
    }
}
