//ex1
using System;

namespace VolumeCaixaRetangular.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa1 = new CaixaRetangular();
            caixa1.largura = 10;
            caixa1.altura = 20;
            caixa1.comprimento = 30;

            Console.WriteLine("volume: " + caixa1.CalcularVolume());

        }
    }
}
