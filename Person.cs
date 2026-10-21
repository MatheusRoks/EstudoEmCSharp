using System;
using System.Globalization; 
namespace EstudoEmCSharp
{
    internal class Person
    {
        public string Name;
        public int Age;

        public double Salary = 0.0;
        public double SalaryFinal = 0.0;
        public double Imposto = 0.0;

        public void AumentarSalario(double porcentagem)
        {
            Salary += Salary * (porcentagem / 100);
            SalaryLiquid();
        }
        public double SalaryLiquid()
        {
            return SalaryFinal = Salary - Imposto;

        }
        public override string ToString()
        {
            return "O funcionario "
                + Name
                + " com salário de "
                + SalaryFinal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
