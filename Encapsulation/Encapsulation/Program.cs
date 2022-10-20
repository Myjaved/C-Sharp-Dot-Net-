using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private int _empID;
        private string _empName;
        public void setID(int empID)
        {
            if(empID <= 0)
            {
                Console.WriteLine("Invalid Id");
            }
            else 
            {
                this._empID = empID;
            }
            
        }
        public int getID()
        {
            return this._empID;

        }
        public void setName(string empName)
        {
            if(string.IsNullOrEmpty(empName))
            {
                Console.WriteLine("Invalid Name or Empty ");
            }
            else 
            {
                this._empName = empName;
            }
        }
        
        public string getAge()
        {
             return this._empName;

        }

    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string x=Console.ReadLine();
            Person p=new Person();
            p.setName(x);
            Console.WriteLine("Enter ID");
            int y = int.Parse(Console.ReadLine());
            p.setID(y);
            Console.WriteLine("Your Name is "+p.getAge());
            Console.WriteLine("Your Id is "+p.getID());
            
            Console.ReadLine();
            
        }
    }
}
