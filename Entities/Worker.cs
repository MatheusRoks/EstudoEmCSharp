using EstudoEmCSharp.Entities.Enums;

namespace EstudoEmCSharp.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }

        public double BasicSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkLevel level, double basicSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BasicSalary = basicSalary;
            Departament = departament;
        }
    }
}
