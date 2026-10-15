using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class WhileExerc
    {
        public WhileExerc()
        {
            string option;
            int senha = 2002;
            int tentativa;
            bool conclusao = false;

            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Entrada com senha");
                Console.WriteLine("2 - Quadrante");
                Console.WriteLine("3 - Posto");
                Console.WriteLine("0 - para sair");
                option = Console.ReadLine();
                conclusao = false;

                if (option == "0") break;
                switch (option)
                {
                    case "1":
                        while (!conclusao)
                        {
                            Console.WriteLine("Entrada de senha (4 dígitos): ");
                            tentativa = int.Parse(Console.ReadLine());
                            if (tentativa == senha)
                            {
                                Console.WriteLine("Acesso liberado");
                                conclusao = true;
                            }
                            else
                                Console.WriteLine("Senha invalida");

                        }
                        Console.WriteLine("aperte uma tecla para sair");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        while (!conclusao)
                        {
                            Console.WriteLine("Irei dizer qual o quadrante das coordenadas informadas");
                            Console.WriteLine("Informe as coordenadas ou 0 para sair");
                            string[] coordenadas = Console.ReadLine().Split(' ');

                            double first = double.Parse(coordenadas[0]);
                            double second = double.Parse(coordenadas[1]);
                            if (first == 0 && second == 0)
                            {
                                Console.WriteLine("Origem");
                                conclusao = true;
                            }
                            else if (first == 0 && second != 0)
                            {
                                Console.WriteLine("Eixo y");
                                conclusao = true;
                            }
                            else if (first != 0 && second == 0)
                            {
                                Console.WriteLine("Eixo X");
                                conclusao = true;
                            }
                            else if (first > 0 && second > 0) Console.WriteLine("Q1");
                            else if (first > 0 && second < 0) Console.WriteLine("Q4");
                            else if (first < 0 && second > 0) Console.WriteLine("Q2");
                            else { Console.WriteLine("Q3"); }
                        }
                        Console.WriteLine("aperte uma tecla para sair");
                        Console.ReadLine();
                        Console.Clear();
                    break;
                    case "3":
                        List<List<object>> caixa =
                                [
                                [01, "Alcool", 0],
                                [02, "Gasolina", 0],
                                [03, "disel", 0],
                                ];
                        foreach (List<object> optionX in caixa)
                        {
                            Console.WriteLine($"{optionX[0]} - {optionX[1]}: clientes{optionX[2]}");
                        }
                        while (!conclusao)
                        {
                            Console.WriteLine("Digite o que o cliente comprou ou 4 para sair");
                            string compra = Console.ReadLine();
                            if (compra == "1") caixa[0][2] = Convert.ToDouble(caixa[0][2]) + 1;
                            else if (compra == "2") caixa[1][2] = Convert.ToDouble(caixa[1][2]) + 1;
                            else if (compra == "3") caixa[2][2] = Convert.ToDouble(caixa[2][2]) + 1;
                            else if (compra == "4")
                            {
                                foreach (List<object> optionX in caixa)
                                {
                                    Console.WriteLine($"{optionX[0]} - {optionX[1]}: clientes {optionX[2]}");
                                }
                                conclusao = true;
                            }
                            else
                                continue;
                        }
                        Console.WriteLine("aperte uma tecla para sair");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
