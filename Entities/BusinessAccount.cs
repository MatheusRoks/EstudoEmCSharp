namespace EstudoEmCSharp.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (LoanLimit >= amount)
            {
                Deposit(amount);

            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, LoanLimit: {LoanLimit:F2}%";
        }

    }
}
