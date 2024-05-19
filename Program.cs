namespace Interface_c__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager { FullName = "John Doe", WorkingDays = 22 };
            DepartmentHead head = new DepartmentHead { FullName = "Alice Smith", WorkingDays = 20};

            manager.Print();
            head.Print();

            Accountant accountant = new Accountant();
            Console.WriteLine($"Income tax for Manager:{accountant.CalculateIncomeTax(manager, 22)}");
            Console.WriteLine($"Income tax for Department Head:{accountant.CalculateIncomeTax(head, 20)}");
        }
    }
}
