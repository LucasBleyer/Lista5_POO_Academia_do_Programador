//ex 8
using System;

namespace VolumeLata.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lata lata = new Lata();
            lata.raio = 5;
            lata.altura = 20;

            Console.WriteLine("Volume da Lata: " + lata.CalcularVolume());
        }
    }
}
