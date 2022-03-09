using System;

namespace FahrenheitToCelcius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temp1 = new Temperatura();
            temp1.fahrenheit = 48;

            Console.WriteLine("Celsius: " + temp1.ConverterFahrenheitToCelcius());
        }
    }
}
