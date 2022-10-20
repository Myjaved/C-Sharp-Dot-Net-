using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_1
{
    struct Employee
    {
        public int Salary;
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Salary = 5000;
            emp.Age = 23;

            Employee e1 = emp;
            Employee e2 = emp;
            emp.Age = 27;
            Console.WriteLine(emp.Age);
            Console.WriteLine(e2.Age);
            Console.ReadLine();
        }
    }
}
