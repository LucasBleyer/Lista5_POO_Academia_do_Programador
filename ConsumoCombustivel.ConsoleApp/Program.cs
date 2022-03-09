//ex 4
using System;

namespace ConsumoCombustivel.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel carro1 = new ConsumoCombustivel();
            //variação de quilometros = 400km
            carro1.km_inicial = 20;
            carro1.km_final = 420;

            //variação de litros = 34L
            carro1.litros_inicial = 36;
            carro1.litros_final = 2;

            Console.WriteLine("Consumo: " + carro1.CalcularConsumo() + "Km/L");

        }
    }
}
