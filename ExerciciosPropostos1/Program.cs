using System;
using System.Globalization;

namespace ExerciciosPropostos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
// Fórmula da área: area = π.raio2
//  o valor de π = 3.14159