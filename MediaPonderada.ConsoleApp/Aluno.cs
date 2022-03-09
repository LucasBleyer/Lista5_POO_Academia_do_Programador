using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPonderada.ConsoleApp
{
    internal class Aluno
    {
        public double nota1;
        public double nota2;

        public double CalcularMediaPonderada()
        {
            double media_ponderada = (nota1 + nota2) / 2;
            return Math.Round(media_ponderada, 2);
        }
    }
}
