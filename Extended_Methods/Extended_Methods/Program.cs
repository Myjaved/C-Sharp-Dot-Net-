using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extended_Methods
{
    internal class Program
    {
        public void Func1()
        {
            Console.WriteLine("This is method of First Function");
        }

        public void Func2()
        {
            Console.WriteLine("This is method of second Function");
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            p.Func1();
            p.Func2();
            p.Func3();
            Console.ReadLine();
        }
    }
}
