using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_OVERRIDING
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is method of Parent class");
        }
        
    }

    class child : parent
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("This is method of child class");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent c=new child();
            c.print();
            Console.ReadLine();
        }
    }
}
