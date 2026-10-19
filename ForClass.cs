using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
                Console.WriteLine("3 - Média ponderada");
                Console.WriteLine("4 - divisão");
                Console.WriteLine("5 - Fatorial");
                Console.WriteLine("6 - Divisores");
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
                    case "3":
                        string[] notas;
                        string[] notasF;
                        double media = 0;
                        Console.WriteLine("Média ponderada");
                        Console.WriteLine("Digite quantos estudantes serão avalados");
                        int estudantes = int.Parse(Console.ReadLine());
                        notasF = new string [estudantes];
                        for (int i = 1; i <= estudantes; i++)
                        {

                            Console.WriteLine("Digite 3 notas, separadas por espaço e com ponto");
                            notas = Console.ReadLine()!.Split(' ');

                            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);



                            if (n1 >= 0 && n1 <= 10
                                && n2 >= 0 && n2 <= 10
                                && n3 >= 0 && n3 <= 10)
                            {
                                media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                                notasF[i - 1] = media.ToString("F1", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                Console.WriteLine("Valores inválidos");
                                continue;
                            }

                        }
                        foreach (string resultado in notasF)
                        {
                            Console.WriteLine(resultado);
                        }
                        break;
                    case "4":
                        int vezes;
                        string[] pares;

                        Console.WriteLine("Digite quantas vezes iremos exibir");
                        vezes = int.Parse(Console.ReadLine());

                        for (int i = 1; i<=vezes; i++)
                        {
                            Console.WriteLine($"Digite a {i}ª divisão, com espaço separqando o numerador do divisor: ");
                            pares = Console.ReadLine().Split(' ');
                            double num1 = double.Parse(pares[0]);
                            double num2= double.Parse(pares[1]);
                            if ( num2 == 0)
                            {
                                Console.WriteLine("Divisão impossível");
                                
                            }
                            else {
                                double divisao = num1 / num2;
                                Console.WriteLine($"O resultado é: {divisao}");
                            }

                        }
                        break;
                    case "5":
                        double numeroFat;
                        double resultado3 = 1;
                        Console.WriteLine("Digite um número: ");
                        numeroFat = int.Parse(Console.ReadLine());
                        for (double i = numeroFat; i>0; i--)
                        {
                            resultado3 = resultado3 * i;
                        }
                        Console.WriteLine($"O fatorial de {numeroFat} é {resultado3}");
                        break;
                    case "6":
                        int divisor;
                        Console.WriteLine("Digite um númeroe e mostraremos os divisores");
                        divisor = int.Parse(Console.ReadLine());
                        for (int i = 1; i<=divisor; i++)
                        {
                            if (divisor % i == 0)
                            {
                                Console.WriteLine($"O {i} é um divisor de {divisor}");
                            }
                        }
                        break;
                }
            }
        }
    }
}
