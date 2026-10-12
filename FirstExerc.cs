using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EstudoEmCSharp
{
    internal class FirstExerc
    {
        public FirstExerc()
        {
            string separator = new string('-', 50);
            int firstNumber;
            int secondNumber;
            double radius;
            const double pi = 3.14159;



            Console.WriteLine("Lets start!");
            Console.WriteLine("Sum");
            Console.WriteLine("Insert a first INT number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a second INT number: ");
            secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of {firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine(separator);
            Console.WriteLine("Circle Area");
            Console.WriteLine("Insert the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());
            double area = pi * (radius*radius);
            Console.WriteLine($"The area of the circle with radius {radius} is: {area:F4}");
            Console.WriteLine(separator);

        }
    }
}
