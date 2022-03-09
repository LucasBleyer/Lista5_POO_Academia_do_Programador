using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeEsfera.ConsoleApp
{
    internal class Esfera
    {
        public double raio;

        public double CalcularVolume()
        {
            double volume = 1.33 * Math.Pow(raio, 3) * 3.14;
            return Math.Round(volume, 2);
        }
    }
}
