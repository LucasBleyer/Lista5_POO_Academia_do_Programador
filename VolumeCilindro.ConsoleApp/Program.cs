using System;

namespace VolumeCilindro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 2;
            cilindro.altura = 12;

            Console.WriteLine("Volume: " + cilindro.CalcularVolume());

        }
    }
}
