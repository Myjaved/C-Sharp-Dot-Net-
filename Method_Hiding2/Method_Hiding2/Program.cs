using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding2
{
    class Employee
    {
        public string Fname;
        public string Lname;
        public void printFullName()
        {
           
            Console.WriteLine(Fname + " " + Lname );
        }
    }

    class PartTimeEmployee : Employee
    {
        public new void printFullName()
        {
            Console.WriteLine(Fname + " " + Lname+ " "+"PTE");
        }
    }

    class FullTimeEmployee :Employee
    {
        public new void printFullName()
        {
            Console.WriteLine(Fname + " " + Lname+" "+"FTE");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee F = new FullTimeEmployee();
            F.Fname = "Javed";
            F.Lname = "Shaikh";
            F.printFullName();
            Console.ReadLine();    
        }
    }
}
