//ex 9
using System;

namespace MediaHarmonicaNotas.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 9;
            aluno.nota2 = 10;
            aluno.nota3 = 7;
            aluno.nota4 = 4;

            Console.WriteLine("Media harmônica das notas: " + aluno.CalcularMediaHarmonica());
        }
    }
}
