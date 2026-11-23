namespace EstudoEmCSharp.Entities
{
    internal class CPFperson : AbsPerson
    {
        public double Healthcare { get; set; }

        CPFperson() { }
        public CPFperson(string name, double annualIncome, double healthcare) : base(name, annualIncome)
        {
            Healthcare = healthcare;
        }

        public override double Tax()
        {
            if (AnnualIncome <= 20000)
            {
                double taxs = (AnnualIncome * 0.15) - (Healthcare * 0.5);
                return taxs;
            }
            else
            {
                double taxs = (AnnualIncome * 0.25) - (Healthcare * 0.5);
                return taxs;
            }
        }
    }
}
