//ex 10
using System;

namespace MediaPonderada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 9;
            aluno.nota2 = 7;

            Console.WriteLine("Media Ponderada: " + aluno.CalcularMediaPonderada());
        }
    }
}
