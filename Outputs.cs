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
                Console.WriteLine(" 6 - Conditionals");
                Console.WriteLine(" 7 - WhileExerc");
                Console.WriteLine(" 8 - ForClass");
                Console.WriteLine(" 9 - Pessoa");
                Console.WriteLine(" 10 - Salario");
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
                    case "6":
                        Conditional conditional = new Conditional();
                        break;
                    case "7":
                        WhileExerc whileExerc = new WhileExerc();
                        break;
                    case "8":
                        ForClass forClass = new ForClass();
                        break;
                    case "9":
                        Person x, y;
                        x = new Person();
                        y = new Person();

                        Console.WriteLine("Iremos definir qual é o mais velho");
                        Console.WriteLine("Digite o nome da primeira pessoa");
                        x.name = Console.ReadLine();
                        Console.WriteLine("Digite a idade da primeira pessoa");
                        x.age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dados da segunda pessoa");
                        Console.WriteLine("Digite o nome da segunda pessoa");
                        y.name = Console.ReadLine();
                        Console.WriteLine("Digite a idade da segunda pessoa");
                        y.age = int.Parse(Console.ReadLine());

                        if (x.age > y.age)
                        {
                            Console.WriteLine($"A idade de {x.name} é maior que a idade de {y.name}");
                        }
                        else if (y.age > x.age)
                        {
                            Console.WriteLine($"A idade de {y.name} é maior que a idade de {x.name}");
                        }
                        else
                        {
                            Console.WriteLine("Ambos possuem a mesma idade");
                        }
                        Console.ReadLine();
                        break;
                    case "10":
                        Person x2, y2;
                        x2 = new Person();
                        y2 = new Person();

                        Console.WriteLine("Digite o nome e em seguida o salário (use vírcula) do 1º funcionário");
                        x2.name = Console.ReadLine();
                        x2.salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome e em seguida o salário (use vírcula) do 2º funcionário");
                        y2.name = Console.ReadLine();
                        y2.salary = double.Parse(Console.ReadLine());

                        double media;
                        media = (x2.salary + y2.salary) / 2;
                        Console.WriteLine($"A média salarial é de {media:F2}");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine($"Classe '{className}' não encontrada.");
                        break;
                }
            }
            
        }
    }


}