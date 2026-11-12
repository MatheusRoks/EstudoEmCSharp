namespace EstudoEmCSharp.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Deposit(Balance * InterestRate);
        }

        public void NewInterestRate(double newInterestRate)
        {
            InterestRate = newInterestRate;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Interest Rate: {InterestRate:F2}%";
        }
    }

}
