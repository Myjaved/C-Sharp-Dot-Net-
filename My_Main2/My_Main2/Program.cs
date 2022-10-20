using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Main2
{
    internal class program
        //Constructor Exmple
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public program(int EmpId ,string Empname,int EmpAge )
        {
            this.EmpId = EmpId;
            this.EmpName = Empname; 
            this.EmpAge = EmpAge;   
        }

        public int GetId()
        {
            return this.EmpId;
        }

        public string GetName()
        {
            return this.EmpName;
        }

        public int GetAge()
        {
            return this.EmpAge;
        }

        static void Main(string[] args)
        {
            program Ali = new program(2,"Ali Khan",22);
            program Javed = new program(4, "Javed Shaikh", 32);
            Console.WriteLine("Ali employee Id {0}",Ali.GetId());
            Console.WriteLine("Ali employee Name {0}", Ali.GetName());
            Console.WriteLine("Ali employee Age {0}", Ali.GetAge());
            //Console.WriteLine(Javed.EmpName);
            Console.ReadLine();
        }
    }
}
