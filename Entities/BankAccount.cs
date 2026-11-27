using EstudoEmCSharp.Entities.Exceptions;

namespace EstudoEmCSharp.Entities
{
    internal class BankAccount
    {
        public string Holder { get; set; }
        public int Number { get; set; }
        public double Balance { get; private set; }

        public double WithdrawLimit { get; protected set; }

        public BankAccount() { }

        public BankAccount(string holder, int number, double balance, double withdrawLimit)
        {
            Holder = holder;
            Number = number;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ValueException("Value must be greater than 0");
            }
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ValueException("Value must be greater than 0");
            }

            if (value > WithdrawLimit)
            {
                throw new ValueException("The withdraw amount exceeds the limit");
            }

            if (value > Balance)
            {
                throw new ValueException("Insufficient balance");
            }

            Balance -= value;
        }

        public override string ToString()
        {
            return $"Account: {Number}, Holder: {Holder}, " +
                   $"Balance: {Balance:F2}, Withdraw Limit: {WithdrawLimit:F2}";
        }
    }
}
