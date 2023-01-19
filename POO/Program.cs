using System;
using System.Globalization;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InstalledUICulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}