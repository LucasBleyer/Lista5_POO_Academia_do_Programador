//ex 5
using System;

namespace VolumeEsfera.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 5;

            Console.WriteLine("Volume: " + esfera.CalcularVolume());

        }
    }
}
