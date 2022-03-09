using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelcius.ConsoleApp
{
    internal class Temperatura
    {
        public double fahrenheit;
        public double ConverterFahrenheitToCelcius()
        {
            double celcius = fahrenheit - 32 / 1.8;
            return Math.Round(celcius, 2);
        }
    }
}
