using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public Enum OrderStatus { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public double Total { get; private set; }

        public Order() { }

        public Order(DateTime moment, Enum orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public void TotalValue()
        {
            foreach(OrderItem item in Items)
            {
                Total += item.SubTotal;
            }
        }
    }
}
