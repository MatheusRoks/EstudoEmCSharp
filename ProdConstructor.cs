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
            Amount = 0;
        }
        public ProdConstructor(string name, double price) : this()
        {
            Name = name;
            Price = price;

        }/* esse this permite eu reaproveitar o Amount, sem ter que passar ele novamente*/

        public ProdConstructor(string name, double price, int amount) : this(name, price)
        {
            Amount = amount;
            
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
