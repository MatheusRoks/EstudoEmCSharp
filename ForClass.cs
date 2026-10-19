using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class ForClass
    {
        public ForClass()
        {
            string choose;
            double number;
            while (true)
            {
                Console.WriteLine("escolha um desses para executar: ");
                Console.WriteLine("0 - sair");
                Console.WriteLine("1 - Impares");
                Console.WriteLine("2 - intervalo");
                choose = Console.ReadLine();

                if (choose == "0")
                {
                    break;
                }
                switch (choose)
                {
                    case "1":

                        Console.WriteLine("Digite um número maior que 1 e menor que 1000: ");
                        number = double.Parse(Console.ReadLine());
                        if (number < 1 || number > 1000)
                        {
                            Console.WriteLine("Número ultrapassa as especificações. emcerrando");
                            Console.ReadLine();
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine(" Digite um número, essa será a quantidade de vezes que o sistema irá executar" +
                            " após isso, digite números e ao final será apresentado quantos estão dentro e fora dos limites");
                        int option = int.Parse(Console.ReadLine());
                        int numberC;
                        int numIn = 0;
                        int numOut = 0;
                        for (int i = 1; i <= option; i++)
                        {
                            Console.WriteLine($"Digite o {i}º número");
                            numberC = int.Parse(Console.ReadLine());
                            if (numberC < 10 || numberC > 20) { numOut++; }
                            else { numIn++; }
                        }
                        Console.WriteLine($"A quantidade de números dentro é {numIn}" +
                            $" A quantidade de números fora é {numOut}");
                        break;

                }
            }
        }
    }
}
