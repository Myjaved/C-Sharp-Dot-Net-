using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("This is First Constructor");
        }
        public Program(int a,int b)
        {
            Console.WriteLine("This is Second Constructor: "+(a+b) );
        }
        public Program(int a, int b,int c)
        {
            Console.WriteLine("This is Third Constructor:"+ (a+b+c));
        }


        static void Main(string[] args)
        {
            Program Obj=new Program();
            Program Obj1 = new Program(2, 8);
            Program Obj2 = new Program(1,5,8);
            Console.ReadLine();
        }
    }
}
