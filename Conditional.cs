using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class Conditional
    {
        public Conditional()
        {
            while true
            {
                string option;
                int firstNumber;
                int secondNumber;
                
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Par ou impar");
                Console.WriteLine("2 - Positivo ou negativo");
                Console.WriteLine("3 - Multiplos");
                option = Console.ReadLine();

                if (option == "0")
                {
                    break;
                }

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Digite um número interiro: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        if (firstNumber%2== 0)
                        {
                            Console.WriteLine($"O número {firstNumber} é par.");

                        }
                        else
                        {
                            Console.WriteLine($"O número {firstNumber} é impar.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Digite um número inteiro: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        if (firstNumber > 0)
                        {
                            Console.WriteLine($"O número {firstNumber} é positivo.");
                        }
                        else if (firstNumber < 0)
                        {
                            Console.WriteLine($"O número {firstNumber} é negativo.");
                        }
                        else
                        {
                            Console.WriteLine($"O número {firstNumber} é zero.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Digite dois números inteiros: ");
                        string[] numbers = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(numbers[0]);
                        secondNumber = int.Parse(numbers[1]);
                        bool maior = firstNumber >= secondNumber;
                        if (maior)
                        {
                            if (secondNumber% firstNumber == 0 )
                            {
                                Console.WriteLine($"O {secondNumber} e o {firstNumber} são multiplos ");
                            
                            }
                            else
                            {
                                Console.WriteLine($"O {secondNumber} e o {firstNumber} não são multiplos ");
                            }
                        else
                        {
                            if ( firstNumber%secondNumber == 0)
                            {
                                Console.WriteLine($"O {firstNumber} e o {secondNumber} são multiplos ");
                            }
                            else
                            {
                                Console.WriteLine($"O {firstNumber} e o {secondNumber} não são multiplos ");
                            }
                            }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

        }
    }
}
