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
                Console.WriteLine(" 11 - Produto");
                Console.WriteLine(" 12 - Retangulo");
                Console.WriteLine(" 13 - Salario Funcionário");
                Console.WriteLine(" 14 - Aluno");
                Console.WriteLine(" 15 - Circunferencia(static)");
                string className = Console.ReadLine();
                Console.Clear();
                if (className.ToLower() == "sair" || className == "0")
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
                        x.Name = Console.ReadLine();
                        Console.WriteLine("Digite a idade da primeira pessoa");
                        x.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dados da segunda pessoa");
                        Console.WriteLine("Digite o nome da segunda pessoa");
                        y.Name = Console.ReadLine();
                        Console.WriteLine("Digite a idade da segunda pessoa");
                        y.Age = int.Parse(Console.ReadLine());

                        if (x.Age > y.Age)
                        {
                            Console.WriteLine($"A idade de {x.Name} é maior que a idade de {y.Name}");
                        }
                        else if (y.Age > x.Age)
                        {
                            Console.WriteLine($"A idade de {y.Name} é maior que a idade de {x.Name}");
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
                        x2.Name = Console.ReadLine();
                        x2.Salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome e em seguida o salário (use vírcula) do 2º funcionário");
                        y2.Name = Console.ReadLine();
                        y2.Salary = double.Parse(Console.ReadLine());

                        double media;
                        media = (x2.Salary + y2.Salary) / 2;
                        Console.WriteLine($"A média salarial é de {media:F2}");
                        Console.ReadLine();
                        break;
                    case "11":
                        Product product = new Product();
                        Console.WriteLine("Entre com os dados do produto");
                        Console.Write("Nome: ");
                        product.Name = Console.ReadLine();
                        Console.Write("Preço: ");
                        product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Quantidade: ");
                        product.Amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(product);
                        Console.Write("Insina a quantidade de produtos a serem adicionados: ");
                        product.Adicionar(int.Parse(Console.ReadLine()));
                        Console.WriteLine(product);
                        Console.Write("Insina a quantidade de produtos a serem removidos: ");
                        product.Adicionar(int.Parse(Console.ReadLine()));
                        Console.WriteLine(product);

                        Console.Read();
                        break;
                    case "12":
                        Retangulo r = new Retangulo();
                        Console.WriteLine("Digite a Altura do retangulo");
                        r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Digite a Largura do retangulo");
                        r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine(r);
                        Console.Read();
                        break;
                    case "13":
                        Person p = new Person();
                        Console.WriteLine("Digite o nome do funcionário: ");
                        p.Name = Console.ReadLine();
                        Console.WriteLine("Digite o salário bruto: ");
                        p.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Digite o valor de imposto descontado: ");
                        p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        p.SalaryLiquid();
                        Console.WriteLine(p);
                        Console.WriteLine("Informe a adição salarial em porcentagem ");
                        p.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        Console.WriteLine(p);
                        Console.Read();
                        break;
                    case "14":
                        Aluno a = new Aluno();
                        Console.WriteLine("Insira o nome: ");
                        a.Name = Console.ReadLine();
                        Console.WriteLine("Digite a nota 1, 2 e 3");
                        a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

                        if (a.Aprovado())
                        {
                            Console.WriteLine("APROVADO");
                        }
                        else
                        {
                            Console.WriteLine("REPROVADO");
                            Console.WriteLine("FALTARAM "
                            + a.Faltante().ToString("F2", CultureInfo.InvariantCulture)
                            + " PONTOS");
                        }
                        Console.Read();
                        break;
                    case "15":
                        Cincunferencia.Main2();
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine($"Classe '{className}' não encontrada.");
                        break;
                }
            }

        }
    }


}