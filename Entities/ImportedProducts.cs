namespace EstudoEmCSharp.Entities
{
    internal class ImportedProducts : ProductHP
    {
        public double CustomFee { get; set; }

        public ImportedProducts() { }

        public ImportedProducts(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public void TotalPrice()
        {
            Price += CustomFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" taxa da importação{CustomFee}";
        }
    }
}
