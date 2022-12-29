using System;

namespace OpAtribuicao
{
    class Programa
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a); // soma a + a =12

            a *= 3;
            Console.WriteLine(a); // pega o valor que já tinha na variável "a"(12) e multiplica por 3

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s); // também funciona com strings, concat a variável "s"(ABC) com "DEF"

            int c = 10;
            a++; // para incrementar o 10 + 1
            Console.WriteLine(c);

            int b = 10;
            b--; // para decrementar o 10 + 1
            Console.WriteLine(b);




        }
    }
}
