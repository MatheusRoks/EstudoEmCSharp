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
            int employeeId;
            int fistItemId;
            int secondItemId;
            int firstItemQuantity;
            int secondItemQuantity;

            double firstItemPrice;
            double secondItemPrice;
            double hoursWorked;
            double hourPrice;
            double radius;
            const double pi = 3.14159;
            double firstData;
            double secondData;
            double thirdData;





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
            Console.WriteLine("Difference in products of 4 numbers");
            Console.WriteLine("Insert four numbers without commas: ");
            string[] numbers = Console.ReadLine().Split(' ');
            sum = int.Parse(numbers[0]) * int.Parse(numbers[1]) - int.Parse(numbers[2]) * int.Parse(numbers[3]);
            Console.WriteLine($"The difference between the products of {numbers[0]} * {numbers[1]} and {numbers[2]} * {numbers[3]} is: {sum}");
            Console.WriteLine(separator);
            Console.WriteLine("Calculator of salary");
            Console.WriteLine("Insert the employee ID: ");
            employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the hours worked: ");
            hoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the price per hour: ");
            hourPrice = double.Parse(Console.ReadLine());
            double salary = hoursWorked * hourPrice;
            Console.WriteLine($"The salary of employee {employeeId} is: {salary:F2}");
            Console.WriteLine(separator);
            Console.WriteLine("Lets calculate a sum of items");
            Console.WriteLine("Insert the first item ID, quantity and price separated by space: ");
            string[] firstItem = Console.ReadLine().Split(' ');
            fistItemId = int.Parse(firstItem[0]);
            firstItemQuantity = int.Parse(firstItem[1]);
            firstItemPrice = double.Parse(firstItem[2]);
            Console.WriteLine("Insert the second item ID, quantity and price separated by space: ");
            string[] secondItem = Console.ReadLine().Split(' ');
            secondItemId = int.Parse(secondItem[0]);
            secondItemQuantity = int.Parse(secondItem[1]);
            secondItemPrice = double.Parse(secondItem[2]);
            double sumItens = (firstItemQuantity * firstItemPrice) + (secondItemQuantity * secondItemPrice);
            Console.WriteLine($"The total value to pay is: {sumItens:F2}");
            Console.WriteLine(separator);
            Console.WriteLine("Lets calculate the shape's area");
            Console.WriteLine("Insert three numbers separated by space: ");
            string[] datas = Console.ReadLine().Split(' ');
            firstData = double.Parse(datas[0]);
            secondData = double.Parse(datas[1]);
            thirdData = double.Parse(datas[2]);
            Console.WriteLine("Triangle area: ");
            double triangleArea = (firstData * thirdData) / 2;
            Console.WriteLine($"{triangleArea:F3}");
            Console.WriteLine("Area of a circle: ");
            double circleArea = pi * Math.Pow(thirdData, 2);
            Console.WriteLine($"{circleArea:F3}");
            Console.WriteLine("Area of a trapezoid: ");
            double trapezoidArea = ((firstData + secondData) * thirdData) / 2;
            Console.WriteLine($"{trapezoidArea:F3}");
            Console.WriteLine("Area of a square: ");
            double squareArea = Math.Pow(secondData, 2);
            Console.WriteLine($"{squareArea:F3}");
            Console.WriteLine("Area of a rectangle: ");
            double rectangleArea = firstData * secondData;
            Console.WriteLine($"{rectangleArea:F3}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
