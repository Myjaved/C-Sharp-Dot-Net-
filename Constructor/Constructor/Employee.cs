using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    //constructor runs without calling an object .it just runs when we create an object

    /*The main use of constructors is to initialize the "PRIVATE" fields of the 
      class while creating an instance for the class */

    internal class Employee
    {
        private int EmpId;
        private int EmpAge;
        private string EmpName;

        public Employee(int EmpId,int EmpAge,string EmpName)
        
        {
            this.EmpId = EmpId;
            this.EmpAge = EmpAge;
            this.EmpName = EmpName;
        }
        
        public int GetId()
        { 
            return this.EmpId;
        }

        public int GetAge()
        {
            return this.EmpAge;
        }

        public string GetName()
        {
            return this.EmpName;
        }


        static void Main(string[] args)
        {
            Employee Ali = new Employee(23,32,"Javed");
            Employee Tahir = new Employee(5, 35, "Tahir");
            Console.WriteLine(Tahir.GetName()); 
            Console.WriteLine("Employee id is :"+ Ali.EmpId);
            Console.WriteLine("Employee Age is :" + Ali.EmpAge);
            Console.WriteLine("Employee Name is :" + Ali.EmpName);

            Console.ReadLine();
        }
    }    
}
