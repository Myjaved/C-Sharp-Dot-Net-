using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    interface IEmployee    //In Interface all members are By Default PUBLIC and ABSTRACT
    {
       void show();
        
    }

    class PartTimeEmployee : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is a method of IEmployee Interface");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee employee = new PartTimeEmployee();
            employee.show();
            Console.ReadLine();
        }
    }
}
