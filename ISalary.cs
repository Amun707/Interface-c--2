using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_c__2
{
    interface ISalary
    {
        string FullName { get; set; }
        int WorkingDays { get; set; }
        double CalculateSalary();
    }
    interface IConsoleOutput
    {
        void Print();
    }

    class Manager : ISalary, IConsoleOutput
    {
        public string FullName { get; set; }
        public int WorkingDays { get; set; }

        public double CalculateSalary()
        {
            return WorkingDays * 1000;
        }

        public void Print()
        {
            Console.WriteLine($"Manager {FullName}:");
            Console.WriteLine($"Working days: {WorkingDays}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }

    class DepartmentHead : ISalary, IConsoleOutput
    {
        public string FullName { get; set; }
        public int WorkingDays { get; set; }

        public double CalculateSalary()
        {
            return WorkingDays * 2500;
        }

        public void Print()
        {
            Console.WriteLine($"Department Head {FullName}:");
            Console.WriteLine($"Working days: {WorkingDays}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }

    class Accountant
    {
        public double CalculateIncomeTax(ISalary employee, int days)
        {
            double salary = employee.CalculateSalary() * days / employee.WorkingDays;
            return salary * 0.13;
        }
    }
}
