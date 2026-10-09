using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class Conversion
    {
        public Conversion()
        {
            string separator = new string('-', 50);
            float number1 = 10.5f;
            double number2 = number1;
            Console.WriteLine(separator);
            Console.WriteLine($"Number 1 a float number: {number1}");
            Console.WriteLine($"Number 2 a double number: {number2}");
            Console.WriteLine(separator);
            Console.WriteLine("Now, trying to atribuate a double for a int");
            //int number3 = number2;
            // Console.WriteLine($"Number 3 a int number: {number3}");
            Console.WriteLine("Well, we can't directly atribuate a double for a int, so we need to use a cast");
            int number3 = (int)number2;
            Console.WriteLine($"Number 3 a int number: {number3}");
            Console.WriteLine(separator);
            Console.WriteLine();
            Console.WriteLine("If u try make a division with 2 int number, the result ALWAYS will be a int," +
                "so, if you try devide a 5 for 2, and the result need be exact, is necessary make the casting. see");
            int a = 5;
            int b = 2;
            Console.WriteLine($"a = {a} and b = {b}");
            Console.WriteLine($"a/b = {a / b}");
            Console.WriteLine();
            Console.WriteLine("now making a cast");
            double result = (double)a / b;
            Console.WriteLine($"a/b with cast = {result}");
        }
    }
}
