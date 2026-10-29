using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Banco
    {
        public int CountNumber { get; private set; }
        public double Money { get; private set; }

        public string Name { get; private set; }

        public Banco(string name, int countNumber, double money)
        {
            Name = name;
            CountNumber = countNumber;
            if (money >= 0)
            {
                AddMoney(money);
            }
        }
        public Banco(string name, int countNumber)
        {
            Name = name;
            CountNumber = countNumber;
            Money = 0.0;
        }
        public void Rename(string newName)
        {
            Name = newName;

        }
        public void AddMoney(double value)
        {
            if (value >= 1)
            {
                Money += value;
            }
            else
            {
                Console.WriteLine("Depósito nulo ou negativo, deposito negado");
            }
        }
        public void TakeMoney(double value)
        {
            if (value >= 1 && Money >= value + 5.00)
            {
                Money -= value;
            }
            else
            {
                Console.WriteLine("Valor superior ao depositado, saque negado");
            }
        }
        public override string ToString()
        {
            return Name + " titular da conta " + CountNumber + " com " + Money.ToString("F2", CultureInfo.InvariantCulture)
                + " depositados "
                ;
        }
    }
}
