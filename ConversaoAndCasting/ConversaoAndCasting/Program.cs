namespace ConversaoAndCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;

            a = 5.1;
            b = (int)a; // isso é o casting

            Console.WriteLine(b);
        }
    }
}