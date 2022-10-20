using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");

            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = Num1 + Num2;
            Console.WriteLine("The Sum is:" + Num3);


            Console.ReadLine();
        }
    }
}
