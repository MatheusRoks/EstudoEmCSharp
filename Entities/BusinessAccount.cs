using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    }
}
