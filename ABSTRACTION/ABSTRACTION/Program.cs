using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    /*it is used to display only necessary and essential features of an object
    to outside the world .Means displaying what is necessary and encapsulate the unnecessary
    things to outside the world. Hiding can be achieved by using "PRIVATE" access modifier.
    Abstraction is the process of hiding the implementation details from the user,
    only the functionality will be provided */
    class employee
    {
        public int empId;
        public string empName;
        double grossSalary;
        double tax = 0.1;
        double netSalary;

        public employee(int EmpId, string EmpName,double GrossSalary)
        {
            this.empId = EmpId;
            this.empName = EmpName;
            this.grossSalary = GrossSalary;
        }
        void netSalaryCalculate()
        {
            if(grossSalary >=30000)
            {
                netSalary = grossSalary - (tax * grossSalary);
                Console.WriteLine("Your salary: {0}",netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: {0}",grossSalary);
            }

        }

        public void showdetails()
        {
            this.netSalaryCalculate();
            Console.WriteLine("Employee Id is :{0}",this.empId);
            Console.WriteLine("Employee Name is :{0}", this.empName);


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee(12, "Javed", 29000);
            obj.showdetails();
            
            Console.ReadLine();
        }
    }
}
