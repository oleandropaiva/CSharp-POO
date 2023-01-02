using System;

namespace ExerciciosPropostos1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}

// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.