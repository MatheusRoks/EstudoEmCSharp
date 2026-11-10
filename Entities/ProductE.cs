using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp.Entities
{
    internal class ProductE
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductE() { }

        public ProductE(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
