using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }

    //class Program3
    //{
    //    static void Main()
    //    {
    //        Employee emp = new Employee("Alice", 50000);
    //        Manager mgr = new Manager("Bob", 80000, 15000);

    //        emp.DisplayInfo();
    //        Console.WriteLine();
    //        mgr.DisplayInfo();
    //    }
    //}
}
