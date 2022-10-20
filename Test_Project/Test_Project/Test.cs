using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class Employee
    {
    //    string Emp_Name;
    //    int Emp_Age;
    //    public Employee(string Employee_Name,int Employee_Age)
    //    {
    //        this.Emp_Name = Employee_Name;
    //        this.Emp_Age=Employee_Age;
    //    }

    //    public void EmployeeDetails()
    //    {
    //        Console.WriteLine(Emp_Name);
    //        Console.WriteLine(Emp_Age);
    //    }
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            //Employee obj = new Employee("Shabbir",54);
            //Employee obj2 = new Employee("Juned", 28);
            //obj2.EmployeeDetails();
            Console.WriteLine("Enter your name");
            string showcharacters = Console.ReadLine().ToUpper();

            for (int  i = 0;  i < showcharacters.Length;  i++)
            {
                Console.WriteLine(showcharacters[i]);
            }

            //foreach (char item in showcharacters)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();




        }
    }
}
