namespace EstudoEmCSharp.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; private set; }
        public ProductE product { get; set; } = new ProductE();
        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public void SumTotal()
        {
            SubTotal = Quantity * Price;
        }
    }
}
