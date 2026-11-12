namespace EstudoEmCSharp.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount && amount > 0)
                Balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
                Balance += amount;
        }

        public override string ToString()
        {
            return $"Account {Number}, Holder: {Holder}, Balance: $ {Balance:F2}";
        }
    }
}
