using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoEmCSharp.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public double ValeuPerHour { get; set; }
        public double Hours { get; set; }

        public double SalaryEmp { get; set; } = 0.0;

        public Employee()
        {
        }

        public Employee(string name, double hours, double valeuPerHour)
        {
            Name = name;
            Hours = hours;
            ValeuPerHour = valeuPerHour;
        }

        public  virtual void Salary()
        {
            SalaryEmp = Hours * ValeuPerHour;
        }

        public override string ToString()
        {
            Salary();

            return $"Employee: {Name}, Hours: {Hours}, " +
                   $"Value per hour: {ValeuPerHour:F2}, Salary: {SalaryEmp:F2}";
        }
    }
}
