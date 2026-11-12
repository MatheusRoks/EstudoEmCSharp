using EstudoEmCSharp.Entities;
using EstudoEmCSharp.Entities.Enums;
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
                Console.WriteLine(" 16 - Conversão");
                Console.WriteLine(" 17 - Produto Construtor");
                Console.WriteLine(" 18 - Produto encapsulamento manual");
                Console.WriteLine(" 19 - Banco");
                Console.WriteLine(" 20 - Pensionato");
                Console.WriteLine(" 21 - Calculator");
                Console.WriteLine(" 22 - Cadastro Funcionário (listas)");
                Console.WriteLine(" 23 - Matriz");
                Console.WriteLine(" 24 - Cadastro Funcionario (composição)");
                Console.WriteLine(" 25 - Post");
                Console.WriteLine(" 26 - Produtos");
                Console.WriteLine(" 27 - Accounts");

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
                    case "16":
                        Console.WriteLine("Digite a cotação do dólar: ");
                        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Digite a quantidade de dolares a comprar: ");
                        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Quantidade a pagar: ");
                        Console.WriteLine(Conversao.ValorReal(cotacao, quantia).ToString("F2", CultureInfo.InvariantCulture));
                        Console.Read();
                        break;
                    case "17":
                        Console.WriteLine("Entre com os dados do produto");
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Preço: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Quantidade: ");
                        int amount = int.Parse(Console.ReadLine());
                        ProdConstructor product2 = new ProdConstructor(name, price, amount);
                        Console.WriteLine(product2);
                        Console.Write("Insina a quantidade de produtos a serem adicionados: ");
                        product2.Adicionar(int.Parse(Console.ReadLine()));
                        Console.WriteLine(product2);
                        Console.Write("Insina a quantidade de produtos a serem removidos: ");
                        product2.Adicionar(int.Parse(Console.ReadLine()));
                        Console.WriteLine(product2);
                        /*
                         * Ainda é possivel instanciar uma classe usando o seguinte método
                         * ProdConstructo x = new ProdConstructor{
                         * Name = "Rádio"
                         * Price = 200.00
                         * Amount = 10
                         * }
                         * isso permite instanciar uma classe já com os valores sem a necessidade de criar construtores, porem, se não estiver
                         * estipulado o construtor padrão na classe mas tiver outros, esse método de instancaiação se torna invalido.
                         */

                        Console.Read();
                        break;
                    case "19":
                        Console.WriteLine("Iremos realizar o cadastro de sua conta");
                        Console.WriteLine("Digite o nome do titular da conta");
                        Banco b;
                        string Name = Console.ReadLine();

                        Console.WriteLine("Digite o número da conta");
                        int Number = int.Parse(Console.ReadLine());

                        Console.WriteLine("Deseja depositar S/N");
                        string Option = Console.ReadLine().ToLower();
                        if (Option == "s")
                        {
                            Console.WriteLine("Digite o valor do depósito inical ou deixe em branco");
                            double Money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            b = new Banco(Name, Number, Money);
                        }
                        else
                        {
                            b = new Banco(Name, Number);
                        }

                        Console.WriteLine(b);

                        Console.WriteLine("Deseja renomear a conta S/N");
                        string Renomear = Console.ReadLine();

                        if (Renomear.ToLower() == "s")
                        {
                            Console.WriteLine("Dgite o novo nome: ");
                            string NewName = Console.ReadLine();
                            b.Rename(NewName);
                        }

                        Console.WriteLine("Digite o valor a adicionar na conta: ");
                        double NewValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        b.AddMoney(NewValue);
                        Console.WriteLine(b);

                        Console.WriteLine("Digite o valor para sacar: ");
                        double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        b.TakeMoney(Saque);
                        Console.WriteLine(b);

                        Console.Read();
                        break;
                    case "20":
                        Console.WriteLine("Indique quantos estudantes irão se cadastrar");
                        int quantity = int.Parse(Console.ReadLine());

                        Pensionato[] pensionato = new Pensionato[10];

                        for (int i = 0; i < quantity; i++)
                        {
                            bool livre = false;
                            Console.WriteLine("Digite o nome do estudante: ");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Digite o email do estudante");
                            string email = Console.ReadLine();

                            while (livre is not true)
                            {
                                Console.WriteLine("Digite o número que deseja ocupar: ");
                                int quarto = int.Parse(Console.ReadLine());
                                int indice = quarto - 1;

                                if (pensionato[indice] is null)
                                {
                                    pensionato[indice] = new Pensionato { Name = name1, Email = email };
                                    livre = true;
                                }
                                else
                                {
                                    Console.WriteLine("Quarto ocupado escoolha outro");
                                }

                            }

                        }

                        for (int i = 0; i < 10; i++)
                        {
                            if (pensionato[i] is not null)
                                Console.WriteLine($"Quarto {i + 1} ocupado por {pensionato[i].Name} com o email {pensionato[i].Email} ");
                        }
                        Console.Read();
                        break;
                    case "21":
                        int s1 = Calculator.Sum(2, 3);
                        int s2 = Calculator.Sum(3, 9);
                        Console.WriteLine(s1);
                        Console.WriteLine(s2);
                        int a1 = 10;
                        Calculator.Triple(ref a1);
                        Console.WriteLine(a1);
                        int b1 = 20;
                        int triple;
                        Calculator.TripleS(b1, out triple);
                        Console.WriteLine(triple);

                        Console.Read();
                        break;
                    case "22":
                        List<CadastroFuncionarios> lista = new List<CadastroFuncionarios>();
                        Console.WriteLine("Digite a quantidade de funcionários a ser cadastrado: ");
                        int quantidadeF = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        for (int x1 = 0; x1 < quantidadeF; x1++)
                        {
                            bool verificador = false;
                            while (verificador != true)
                            {
                                Console.WriteLine("Adicione o id: ");
                                int id = int.Parse(Console.ReadLine());
                                if (lista.FindAll(x => x.Id == id).Count > 0)
                                {
                                    Console.WriteLine("Id já cadastrado, digite outro");
                                }
                                else
                                {
                                    Console.WriteLine("Digite o nome do funcionário: ");
                                    string nameF = Console.ReadLine();
                                    Console.WriteLine("Digite o salário do funcionário: ");
                                    double salaryF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    lista.Add(new CadastroFuncionarios(id, nameF, salaryF));
                                    verificador = true;
                                }
                            }

                        }
                        foreach (CadastroFuncionarios c in lista)
                            Console.WriteLine($"{c.Id} - {c.Name} : {c.Salary:F2}");
                        bool verificador2 = false;
                        while (!verificador2)
                        {
                            Console.WriteLine("Deseja alterar o salario de algum funcionário? S/N");
                            string option1 = Console.ReadLine().ToLower();
                            if (option1 == "n")
                                verificador2 = true;
                            else
                            {
                                Console.WriteLine("Digite o id do funcionário");
                                int escolhido = int.Parse(Console.ReadLine());
                                CadastroFuncionarios recebido = lista.Find(x => x.Id == escolhido);
                                if (recebido is not null)
                                {
                                    Console.WriteLine("Digite a porcentagem que deseja adicionar ao salário: ");
                                    double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    recebido.AddSalary(aumento);
                                    verificador2 = true;
                                }
                            }
                        }
                        foreach (CadastroFuncionarios c in lista)
                            Console.WriteLine($"{c.Id} - {c.Name} : {c.Salary:F2}");
                        Console.Read();
                        break;
                    case "23":
                        Console.WriteLine("Elaborando uma matriz");
                        Console.WriteLine("Digite um número para as linhas");
                        int lines = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite um número para as colunas");
                        int column = int.Parse(Console.ReadLine());
                        int[,] matriz = new int[lines, column];

                        for (int i = 0; i < lines; i++)
                        {
                            Console.WriteLine($"Digite todos o valores da linha {i + 1}");
                            string[] values = Console.ReadLine().Split(' ');
                            for (int j = 0; j < column; j++)
                            {
                                matriz[i, j] = int.Parse(values[j]);

                            }
                        }

                        Console.WriteLine("Digite o número que deseja procurar: ");
                        int numberSearch = int.Parse(Console.ReadLine());
                        for (int i = 0; i < lines; i++)
                        {
                            for (int j = 0; j < column; j++)
                            {
                                if (matriz[i, j] == numberSearch)
                                {
                                    int? left = j > 0 ? matriz[i, j - 1] : null;
                                    int? up = i > 0 ? matriz[i - 1, j] : null;
                                    int? right = j < column - 1 ? matriz[1, j + 1] : null;
                                    int? down = i < lines - 1 ? matriz[i + 1, j] : null;

                                    Console.WriteLine($"Número {numberSearch} encontrado na posição {i},{j}, à esquerda temos {left?.ToString() ?? "NADA"}.");
                                    Console.WriteLine($"Acima temos {up?.ToString() ?? "NADA"}, à direita {right?.ToString() ?? "NADA"} e abaixo {down?.ToString() ?? "NADA"}.");
                                }
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "24":

                        Console.Write("Digite o departamento que o funcionário pertence: ");
                        string deptName = Console.ReadLine();
                        Console.WriteLine("Entre com os dados do funcionário");
                        Console.WriteLine();
                        Console.Write("Nome: ");
                        string nameFunc = Console.ReadLine();
                        Console.Write("Level [Junior, MidLevel, Senior]: ");
                        WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
                        Console.Write("Salário base: ");
                        double basicSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Departament dept = new Departament(deptName);
                        Worker worker = new Worker(nameFunc, level, basicSalary, dept);

                        Console.Write("Digite a quantidade de contratos fechados: ");
                        int contracts = int.Parse(Console.ReadLine());
                        for (int i = 0; i < contracts; i++)
                        {
                            Console.WriteLine($"Entre com o {i + 1}º contrato: ");
                            Console.Write("Data(DD/MM/YYYY): ");
                            DateTime date1 = DateTime.Parse(Console.ReadLine());
                            Console.Write("Entre com o valor por hora trabalhada: ");
                            double salaryPerHouer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Quatidade de horas: ");
                            int hours = int.Parse(Console.ReadLine());
                            HourContract contract = new HourContract(date1, salaryPerHouer, hours);
                            worker.AddContract(contract);
                        }
                        Console.WriteLine("Entre com o mes e o ano para calcular o ganho: ");
                        string monthAndYear = Console.ReadLine();
                        int month = int.Parse(monthAndYear.Substring(0, 2));
                        int year = int.Parse(monthAndYear.Substring(3));
                        Console.WriteLine("Nome: " + worker.Name);
                        Console.WriteLine($"Departamento: {worker.Departament.Name}");
                        Console.WriteLine($"Salario do mês{month} do ano {year} = {worker.Income(month, year)}");
                        Console.ReadLine();

                        break;
                    case "25":
                        Console.WriteLine("Digite o primeiro comentário: ");
                        string commentA = Console.ReadLine();
                        Console.WriteLine("Digite o segundo comentário: ");
                        string commentB = Console.ReadLine();
                        Console.WriteLine("Digite o terceiro comentário: ");
                        string commentC = Console.ReadLine();
                        Console.WriteLine("Digite o quarto comentário: ");
                        string commentD = Console.ReadLine();
                        Comment c1 = new Comment(commentA);
                        Comment c2 = new Comment(commentB);
                        Comment c3 = new Comment(commentC);
                        Comment c4 = new Comment(commentD);

                        Post p1 = new Post(
                            DateTime.Now,
                            "Travalling for Alta Floresta",
                            "Finally going see my family",
                            14
                            );
                        p1.AddComments(c1);
                        p1.AddComments(c2);

                        Post p2 = new Post(
                            DateTime.Now,
                            "A beautiful day in Curitiba",
                            "Enjoying the city and its amazing places!",
                            8
                        );
                        p2.AddComments(c3);
                        p2.AddComments(c4);

                        Console.WriteLine(p1);
                        Console.WriteLine(p2);
                        Console.ReadLine();
                        break;
                    case "26":
                        Console.WriteLine("Cadastro do cliente: ");
                        Console.Write("Digite o nome do cliente: ");
                        string clientName = Console.ReadLine();

                        Console.Write("Digite o email do cliente: ");
                        string emailClient = Console.ReadLine();

                        Console.Write("Digite a data de nascimento do cliente: ");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());

                        Client client = new Client(clientName, emailClient, birthDate);

                        Console.WriteLine("\nCadastro do pedido:");
                        Console.Write("Digite o status do pedido: ");
                        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

                        Order order = new Order(DateTime.Now, status);

                        Console.Write("Quantos produtos deseja adicionar? ");
                        int quantityProducts = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantityProducts; i++)
                        {
                            Console.WriteLine($"\nProduto #{i + 1}");

                            Console.Write("Digite o nome do produto: ");
                            string nameProd = Console.ReadLine();

                            Console.Write("Digite o valor do produto: ");
                            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Digite a quantidade: ");
                            int quantityx = int.Parse(Console.ReadLine());

                            ProductE productx = new ProductE(nameProd, productPrice);

                            OrderItem item = new OrderItem(quantityx, productPrice);
                            item.product = productx;
                            item.SumTotal();

                            order.AddItem(item);
                        }

                        order.TotalValue();
                        Console.WriteLine();
                        Console.WriteLine("RESUMO DO PEDIDO");
                        Console.WriteLine($"Cliente: {clientName}");
                        Console.WriteLine($"Email: {emailClient}");
                        Console.WriteLine($"Data de nascimento: {birthDate:dd/MM/yyyy}");
                        Console.WriteLine($"Momento do pedido: {order.Moment}");
                        Console.WriteLine($"Status do pedido: {order.OrderStatus}");
                        Console.WriteLine();
                        Console.WriteLine("ITENS DO PEDIDO");

                        foreach (OrderItem item in order.Items)
                        {
                            Console.WriteLine(
                                $"{item.product.Name} - " +
                                $"Preço: {item.Price:F2} - " +
                                $"Quantidade: {item.Quantity} - " +
                                $"Subtotal: {item.SubTotal:F2}"
                            );
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Total do pedido: {order.Total:F2}");

                        Console.ReadLine();
                        break;
                    case "27":
                        Console.Write("Digite 1 para conta pessoal 2 para conta empresarial e 3 para poupança: ");
                        string type = Console.ReadLine();
                        switch (type)
                        {
                            case "1":
                                Console.WriteLine("Digite o número da conta: ");
                                int acNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o nome do titular: ");
                                string holder = Console.ReadLine();
                                Console.WriteLine("Digite o deposito inicial: ");
                                double deposit = double.Parse(Console.ReadLine());

                                Account conta1 = new Account(acNumber, holder, deposit);
                                Console.WriteLine(conta1);
                                break;
                            case "2":
                                Console.WriteLine("Cadastro de conta empresarial: ");
                                Console.WriteLine("Digite o número da conta: ");
                                int businessNumber = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o nome do titular: ");
                                string businessHolder = Console.ReadLine();

                                Console.WriteLine("Digite o depósito inicial: ");
                                double businessDeposit = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o limite de empréstimo: ");
                                double loanLimit = double.Parse(Console.ReadLine());

                                BusinessAccount businessAccount = new BusinessAccount(
                                    businessNumber,
                                    businessHolder,
                                    businessDeposit,
                                    loanLimit
                                );

                                Console.WriteLine(businessAccount);
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("Cadastro de conta poupança: ");
                                Console.WriteLine("Digite o número da conta: ");
                                int savingsNumber = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o nome do titular: ");
                                string savingsHolder = Console.ReadLine();

                                Console.WriteLine("Digite o depósito inicial: ");
                                double savingsDeposit = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a taxa de juros: ");
                                double interestRate = double.Parse(Console.ReadLine());

                                SavingsAccount savingsAccount = new SavingsAccount(
                                    savingsNumber,
                                    savingsHolder,
                                    savingsDeposit,
                                    interestRate
                                );

                                Console.WriteLine(savingsAccount);
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine($"Classe '{className}' não encontrada.");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine($"Classe '{className}' não encontrada.");
                        break;
                }
            }

        }
    }

}