namespace EstudoEmCSharp.Entities
{
    public abstract class AbsPerson
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public AbsPerson() { }

        public AbsPerson(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}