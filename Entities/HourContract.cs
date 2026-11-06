namespace EstudoEmCSharp.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHpur { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHpur, int hours)
        {
            Date = date;
            ValuePerHpur = valuePerHpur;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHpur * Hours;
        }
    }
}
