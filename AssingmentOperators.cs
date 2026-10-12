using System;

namespace EstudoEmCSharp
{
    internal class AssingmentOperators
    {
        public AssingmentOperators()
        {
            string separator = new string('-', 50);
            int a = 10;

            Console.WriteLine(a);
            a += 2;
            Console.WriteLine($"a+=2: {a}");
            a -= 2;
            Console.WriteLine($"a-=2: {a}");
            a *= 2;
            Console.WriteLine($"a*=2: {a}");
            a/=2;
            Console.WriteLine($"a/=2: {a}");
            a %= 2;
            Console.WriteLine($"a%=2: {a}");
            Console.WriteLine(separator);
            string alphabet = "ABC";
            Console.WriteLine(alphabet);
            alphabet += "DEF";
            Console.WriteLine($"alphabet+=DEF: {alphabet}");
            Console.WriteLine(separator);
            int number1 = 20;
            Console.WriteLine(number1);
            number1++;
            Console.WriteLine($"number1++: {number1}");
            Console.WriteLine(separator);
            int number2 = 20;
            int number3 = number2++;
            int number4 = ++number2;
            Console.WriteLine(number2);
            Console.WriteLine($"number3 with number2++: {number3}");
            Console.WriteLine($"number4 with ++number2: {number4}");
            Console.WriteLine(separator);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
