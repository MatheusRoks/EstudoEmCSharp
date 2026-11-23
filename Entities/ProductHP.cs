namespace EstudoEmCSharp.Entities
{
    internal class ProductHP
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public ProductHP() { }
        public ProductHP(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $" Produto: {Name}, valor: {Price}";
        }
    }
}
