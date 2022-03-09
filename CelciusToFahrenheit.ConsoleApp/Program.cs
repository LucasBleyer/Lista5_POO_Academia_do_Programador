using System;

namespace CelciusToFahrenheit.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.celcius = 16;

            Console.WriteLine("Fahrenheit: " + temperatura.ConverterCelciusToFahrenheit());
        }
    }
}
