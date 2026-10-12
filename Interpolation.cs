using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EstudoEmCSharp
{
    internal class Interpolation
    {
        public Interpolation()
        {
            string separator = new string('-', 50);
            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products: ");
            Console.WriteLine($"{product1}, which price is R${price1:F2}");
            Console.WriteLine($"{product2}, which price is R${price2:F2}");
            Console.WriteLine(separator);
            Console.WriteLine($"Register: {age} years old, code {code} and gender {gender}");
            Console.WriteLine();
            Console.WriteLine(separator);
            Console.WriteLine($"Measure with 8 decimal places: {measure:F8}");
            Console.WriteLine($"Measure with 3 decimal places: {measure:F3}");
            Console.WriteLine(
                "Measure with 3 decimal places and invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(separator);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
