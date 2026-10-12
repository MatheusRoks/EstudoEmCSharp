using System;
using System.Globalization;


namespace EstudoEmCSharp
{
    class Outputs
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome da classe que deseja executar):");
                Console.WriteLine(" 0 ou 'sair' para encerrar o programa.");
                Console.WriteLine(" 1 - AssingmentOperators");
                Console.WriteLine(" 2 - Interpolation");
                Console.WriteLine(" 3 - Conversion");
                Console.WriteLine(" 4 - DataInput");
                Console.WriteLine(" 5 - FirstExerc");
                string className = Console.ReadLine();
                Console.Clear();
                if (className.ToLower() == "sair"|| className == "0")
                {
                    break;
                }
                switch (className)
                {
                    case "1":
                        AssingmentOperators assignmentOperators = new AssingmentOperators();
                        break;
                    case "2":
                        Interpolation interpolation = new Interpolation();
                        break;
                    case "3":
                        Conversion conversion = new Conversion();
                        break;
                    case "4":
                        DataInput dataInput = new DataInput();
                        break;
                    case "5":
                        FirstExerc firstExerc = new FirstExerc();
                        break;
                    default:
                        Console.WriteLine($"Classe '{className}' não encontrada.");
                        break;
                }
            }
            
        }
    }


}