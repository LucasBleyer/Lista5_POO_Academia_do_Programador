using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFahrenheit.ConsoleApp
{
    internal class Temperatura
    {
        public double celcius;
        public double ConverterCelciusToFahrenheit()
        {
            double fahrenheit = (celcius * 1.8) + 32;
            return Math.Round(fahrenheit, 2);
        }
    }
}
