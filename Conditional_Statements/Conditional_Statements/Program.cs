using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 1st Number :");
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter 2nd Number");
            int Num2=Convert.ToInt32(Console.ReadLine());
            
            if (Num1 > Num2)
            {
                Console.WriteLine("Num1 is Greater");
            }
            else if(Num1 == Num2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Num2 is Greater");
            }
            Console.ReadLine();
        }
    }
}
