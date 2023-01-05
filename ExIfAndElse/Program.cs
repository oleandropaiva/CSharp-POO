using System.Runtime.Intrinsics.Arm;

namespace ExIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0 )
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}

// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.