using System;
using System.Globalization;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            

            Console.Write("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo );
    
        }
    }
}
