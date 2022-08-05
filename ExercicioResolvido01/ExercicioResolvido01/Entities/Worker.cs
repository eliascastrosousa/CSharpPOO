using ExercicioResolvido01.Entities.Enums;
using System;


namespace ExercicioResolvido01.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //enum
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //composição de objetos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //lista pq podem ser varios contratos

        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //metodos

        public void AddContract(HourContract contract )
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) //ganhos rendas..
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
               if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
    

    
}
