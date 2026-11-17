namespace EstudoEmCSharp.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        protected virtual double WithdrawalFee => 5.0;

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
            double total = amount + WithdrawalFee;

            if (amount > 0 && Balance >= total)
                Balance -= total;
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
