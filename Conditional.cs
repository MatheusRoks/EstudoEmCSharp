using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class Conditional
    {
        public Conditional()
        {
            while (true)
            {
                string option;
                int firstNumber;
                int secondNumber;
                double number;

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Par ou impar");
                Console.WriteLine("2 - Positivo ou negativo");
                Console.WriteLine("3 - Multiplos");
                Console.WriteLine("4 - Duração jogo");
                Console.WriteLine("5 - Tabela de produtos");
                Console.WriteLine("6 - intervalo");
                Console.WriteLine("7 - Cartesiano");
                Console.WriteLine("8 - IR");
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
                        if (firstNumber % 2 == 0)
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
                            if (secondNumber % firstNumber == 0)
                            {
                                Console.WriteLine($"O {secondNumber} e o {firstNumber} são multiplos ");

                            }
                            else
                            {
                                Console.WriteLine($"O {secondNumber} e o {firstNumber} não são multiplos ");
                            }
                        }
                        else
                        {
                            if (firstNumber % secondNumber == 0)
                            {
                                Console.WriteLine($"O {firstNumber} e o {secondNumber} são multiplos ");
                            }
                            else
                            {
                                Console.WriteLine($"O {firstNumber} e o {secondNumber} não são multiplos ");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Digite a hora de inicio e final do jogo, separado por espaços: ");
                        string[] options = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(options[0]);
                        secondNumber = int.Parse(options[1]);
                        int timeTotal = (24 - firstNumber) + secondNumber;
                        if (firstNumber>24||firstNumber<0||secondNumber>24 || secondNumber < 0)
                        {
                            Console.WriteLine("Horário invalido, favor reiniciar o sistema");
                        }
                        else if (timeTotal <= 0)
                        {
                            Console.WriteLine("O tempo de jogo deve ser maior que 1h");
                        }
                        else if (timeTotal > 24)
                        {
                            Console.WriteLine("O tempo de jogo deve ser menor que 24h");
                        }
                        else
                        {
                            Console.WriteLine($"O tempo de jogo foi de {timeTotal} horas");
                        }
                        break;
                    case "5":
                        List<List<object>> cardapio =
                            [
                            [01, "Cachorro-quente", 4.00],
                            [02, "X-salada", 4.50],
                            [03, "X-bacon", 5.00],
                            [04, "Torrada", 2.00],
                            [05, "Refrigerante", 1.50],
                            ];
                        foreach (List<object> optionX in cardapio)
                        {
                            Console.WriteLine($"{optionX[0]} - {optionX[1]}: R${optionX[2]:2F}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Digite o número do pedido e a qauntidade");
                        string[] choose = Console.ReadLine().Split(' ');
                        int index = int.Parse(choose[0]);
                        List<object> optionC = cardapio[index - 1];
                        double amount = Convert.ToDouble(optionC[2]) * int.Parse(choose[1]);
                        Console.WriteLine($"Total a ser pago {amount:2F}");
                        break;
                    case "6":
                        Console.WriteLine("Digite um número e eu exibirei em qual dos seguinte intervalos ele se encontra");
                        Console.WriteLine("0-25, 25-50, 50-75, 75-100");
                        number = double.Parse(Console.ReadLine());
                        if (number > 0 && number <= 25) { Console.WriteLine("Dentro do intervalo 0-25"); }
                        else if (number <= 50) { Console.WriteLine("Dentro do intervalo 26-50"); }
                        else if (number <= 75) { Console.WriteLine("Dentro do intervalo 51-75"); }
                        else if (number <= 100) { Console.WriteLine("Dentro do intervalo 76-100"); }
                        else { Console.WriteLine("Fora dos intervalos registrados"); }
                        break;
                    case "7":
                        Console.WriteLine("Irei dizer qual o quadrante das coordenadas informadas");
                        Console.WriteLine("Informe a primeira coordenada");
                        double first = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a segunda coordenada");
                        double second = double.Parse(Console.ReadLine());
                        if (first ==0 && second == 0) { Console.WriteLine("Origem"); }
                        else if (first == 0 && second != 0) Console.WriteLine("Eixo y");
                        else if (first != 0 && second == 0) Console.WriteLine("Eixo X");
                        else if (first>0 && second > 0) Console.WriteLine("Q1");
                        else if (first > 0 && second < 0) Console.WriteLine("Q4");
                        else if (first < 0 && second > 0) Console.WriteLine("Q2");
                        else { Console.WriteLine("Q3"); }
                        break;
                    case "8":
                        Console.WriteLine("Informe o salario e direi a quantidade de imposto de renda");
                        double amountS = double.Parse(Console.ReadLine());
                        if (amountS < 0) Console.WriteLine("O vaalor deve ser superior a 0");
                        else if (amountS <=2000) Console.WriteLine("Isento");
                        else if (amountS <= 3000)
                        {
                            double calc = amountS - 2000;
                            double imp = (calc * 0.08);
                            Console.WriteLine($"O total a ser pago é {imp:F2}");
                        }
                        else if(amountS< 4500)
                        {
                            double calc = amountS - 3000;
                            double imp = (calc * 0.18) + (1000*0.08);
                            Console.WriteLine($"O total a ser pago é {imp:F2}");
                        }
                        else
                        {
                            double calc = amountS - 4500;
                            double imp = (calc * 0.28) + (1500*0.18) + (1000*0.08);
                            Console.WriteLine($"O total a ser pago é {imp:F2}");
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
