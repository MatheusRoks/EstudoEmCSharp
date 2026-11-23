using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp.Entities
{
    internal class CNPJPerson:AbsPerson
    {
        public int FuncAmount { get; set; }
        public CNPJPerson()
        {
        }

        public CNPJPerson(string name, double annualIncome, int funcAmount) : base(name, annualIncome)
        {
            FuncAmount = funcAmount;
        }

        public override double Tax()
        {
            if (FuncAmount >= 10)
            {
                double taxs = AnnualIncome * 0.14;
                return taxs;
            }
            else
            {
                double taxs = AnnualIncome * 0.16;
                return taxs;
            }
        }
    }
}
