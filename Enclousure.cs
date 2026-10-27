using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Enclousure
    {
        private string _name;
        private double _price;
        private int _amount;

        public Enclousure()
        {

        }

        public Enclousure(string name, double price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;

        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetAmount()
        {
            return _amount;
        }

        public double Valor()
        {
            return _price * _amount;
        }
        public void Adicionar(int quantidade)
        {
            _amount += quantidade;
        }
        public void Remover(int quantidade)
        {
            _amount -= quantidade;
        }

        public override string ToString()
        {
            return _name + " por $ " + _price.ToString("F2", CultureInfo.InvariantCulture) + " com " + _amount
                + " unidades em estoque. Totalizando "
                + Valor().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }

}
