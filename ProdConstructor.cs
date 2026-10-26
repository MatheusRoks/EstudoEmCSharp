using System;
using System.Globalization;

namespace EstudoEmCSharp
{
    class ProdConstructor
    {

        public string Name;
        public double Price;
        public int Amount;

        public ProdConstructor()
        {

        }
        public ProdConstructor(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public ProdConstructor(string name, double price)
        {
            Name = name;
            Price = price;
            Amount = 0;/*linha dispensável*/
        }

        public double Valor()
        {
            return Price * Amount;
        }
        public void Adicionar(int quantidade)
        {
            Amount += quantidade;
        }
        public void Remover(int quantidade)
        {
            Amount -= quantidade;
        }

        public override string ToString()
        {
            return Name + " por $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " com " + Amount
                + " unidades em estoque. Totalizando "
                + Valor().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }

}
