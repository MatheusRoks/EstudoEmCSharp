using System;
using System.Collections.Generic;
using System.Globalization;

namespace EstudoEmCSharp
{
    internal class Retangulo
    {
        public double Largura, Altura;
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2)) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return "Um retangulo de altura "
                + Altura
                + " e uma largura de "
                + Largura
                + " possui uma area de "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " um perimetro de "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " e uma diagonal de "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }

}
