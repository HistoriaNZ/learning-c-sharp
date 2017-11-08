using System;
using System.Collections.Generic;

namespace Delegates2
{

    class Program
    {

        static void Main(string[] args)
        {
            //Employees example
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 50000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 60000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 40000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 30000, Experience = 3 });

            //Using delegates/lambda expressions to increase code versatility
            Employee.PromoteEmployees(empList, emp => emp.Experience >= 5);
            Console.ReadLine();
        }



        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployees(List<Employee> employeeList, IsPromotable PromoElligible)
        {
            foreach (Employee employee in employeeList)
            {
                if (PromoElligible(employee))
                {
                    Console.WriteLine("{0} promoted!", employee.Name);
                }
            }
        }
    }
}
