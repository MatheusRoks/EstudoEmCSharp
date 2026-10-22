using System;
using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Conversao
    {
       public  static double Iof = 0.06;
         public static double ValorReal(double cotacao, double quantia)
        {
            double imposto = (cotacao * quantia) * Iof;
            return (cotacao * quantia) + imposto;

        }
    }
}
