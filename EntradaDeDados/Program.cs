using System;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
        }
    }
}