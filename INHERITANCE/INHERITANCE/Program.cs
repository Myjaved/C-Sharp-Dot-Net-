using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    class employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
       

        public void show()
        {
            Console.WriteLine("This is Baseclass");
        }
    }
    class visitingEmployees :employees
    {
        public int VistingSalary;
        public int VisitingHours;
    }
    class permanentEmployee : employees
    {
        public int PermanentSalary;
        public int ParmenentHours;
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            permanentEmployee TAHIR=new permanentEmployee();
            TAHIR.EmpAge = 20;
            TAHIR.EmpId = 3;
            TAHIR.EmpName = "Tahir";
            TAHIR.show();

            visitingEmployees Masud = new visitingEmployees();
            Masud.EmpId = 4;
            Masud.EmpAge = 32;

            Console.WriteLine(TAHIR.EmpAge);
            Console.WriteLine(Masud.EmpAge);
            Console.WriteLine(TAHIR.EmpName);
            Console.ReadLine(); 

        }
    }
}
