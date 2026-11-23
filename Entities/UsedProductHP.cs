namespace EstudoEmCSharp.Entities
{
    internal class UsedProductHP : ProductHP
    {
        public DateTime Data { get; set; }

        public UsedProductHP() { }

        public UsedProductHP(string name, double price, DateTime data) : base(name, price)
        {
            Data = data;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" feito em {Data}";
        }
    }
}
