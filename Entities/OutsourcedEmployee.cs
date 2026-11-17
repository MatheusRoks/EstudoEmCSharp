using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp.Entities
{
    internal class OutsourcedEmployee:Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, double hours, double valeuPerHour, double aditional) : base(name, hours, valeuPerHour)
        {
            AdditionalCharge = aditional;
        }

        override public void Salary()
        {
            SalaryEmp = (Hours * ValeuPerHour) + (AdditionalCharge *1.1);

        }

        public override string ToString()
        {
            return $"{base.ToString()}, Additional Charge: {AdditionalCharge:F2}";
        }

    }
}
