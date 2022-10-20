using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Main_Constructor2
{
    internal class Program
    {
        //Constructor Overloading 
        public Program()
        {
            Console.WriteLine("This is first constructor!!");
        }

        public Program(int a,int b)
        {
            Console.WriteLine("This is second constructor!!{0}",(a+b));
        }

        public Program(int a, int b,int c)
        {
            Console.WriteLine("This is third constructor!!{0}", (a + b + c));
        }


        static void Main(string[] args)
        {
            Program Cons = new Program();
            Program Cons1 = new Program(45, 90);
            Program Cons2 = new Program(45,90,60);
            Console.ReadLine();
            
        }
    }
}
