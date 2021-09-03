using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> l = new List<Employee>();
            l.Add(new Employee()
            {
                ID = 101,
                Name = "Lasha",
                Salary = 5000,
                Experience = 4,
            });
            l.Add(new Employee()
            {
                ID = 102,
                Name = "David",
                Salary = 1200,
                Experience = 1
            });
            l.Add(new Employee()
            {
                ID = 101,
                Name = "Nikusha",
                Salary = 7500,
                Experience = 7,
            });
            l.Add(new Employee()
            {
                ID = 101,
                Name = "Mariam",
                Salary = 2500,
                Experience = 2,
            });

            IsPromotable IsPromotable = new IsPromotable(PromoteByExperience);

            Employee.PromoteEmployee(l, IsPromotable);

            
        }

        // method which determines if employee is promotable by his/her experience
        public static bool PromoteByExperience(Employee emp)
        {
            if (emp.Experience >= 5) return true;
            else return false;
        }


    }
    // method callback for reusable class employee
    delegate bool IsPromotable(Employee emp);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // method which identifies if employee is promotable.

        public static void PromoteEmployee(List<Employee> EmployeeList, IsPromotable IsEligible)
        {
            foreach (Employee employee in EmployeeList)
            {
                if(IsEligible(employee))
                {
                    Console.WriteLine($"{employee.Name} is promoting");
                }
            }
        }
    }
}
