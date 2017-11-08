using System;
using System.Collections.Generic;

namespace Delegates
{
    //A delegate is a TYPE-SAFE function pointer!
    public delegate void HelloFunctionDelegate(string Message);

    class Program
    {

        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from the delegate!");
            Console.ReadLine();

            //Employees example
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 50000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 60000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 40000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 30000, Experience = 3 });

            Employee.PromoteEmployees(empList);
            Console.ReadLine();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployees(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine("{0} promoted!", employee.Name);
                }
            }
        }
    }
}
