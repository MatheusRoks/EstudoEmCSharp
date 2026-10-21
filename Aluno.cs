using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp
{
    internal class Aluno
    {
        public string Name;
        public double N1, N2, N3;
        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else return false;
        }

        public double Faltante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }

        
        
    }
}
