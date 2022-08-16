using System;
using System.Collections.Generic;
using ExercicioResolvido03.Entities;

namespace ExercicioResolvido03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                

                Console.WriteLine("Employee #{0} data: ", i+1);

                Console.Write("Outsourced (y/n)?");
                string res = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (res == "y")
                {
                    Console.WriteLine("Additional Change: ");
                    double Additional = double.Parse(Console.ReadLine());

                    OutSourceEmployee outSourceEmployee = new OutSourceEmployee(name, hours, valuePerHour, Additional);
                    list.Add(outSourceEmployee);

                }
                else
                {

                    Employee employee = new Employee(name, hours, valuePerHour);
                    list.Add(employee);
                }

            }

            Console.WriteLine("Payments: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment());

            }



        }
    }
}