using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace EstudoEmCSharp
{
    internal class CadastroFuncionarios
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public CadastroFuncionarios(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void AddSalary( double porcent)
        {
            double acress = Salary * (porcent / 100);
            Salary += acress;
        }
    }
}
