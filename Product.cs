using System;
using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public double Valor()
        {
            return Price * Amount;
        }
        public void Adicionar( int quantidade)
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
                + Valor().ToString("F2",CultureInfo.InvariantCulture)              
                ;
        }
    }

}
