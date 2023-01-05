namespace ExIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            if (Number < 0 )
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não é negativo");
            }
        }
    }
}

// Fazer um programa para ler um número inteiro,
// e depois dizer se este número é negativo ou não.
