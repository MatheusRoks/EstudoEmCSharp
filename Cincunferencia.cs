using System;
using System.Collections.Generic;
using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Cincunferencia
    {
        static double Pi = 3.14;

        public static void Main2()
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double vol = Volume(raio);
            Console.WriteLine($"A circunferencia de um raio {raio} é {circ.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"e o volume é {vol.ToString("F2", CultureInfo.InvariantCulture)}");

        }
        static double Circunferencia(double r)
        {
            return 2.00 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.00 / 3.00 * Pi * Math.Pow(r, 3);
        }
    }
}
