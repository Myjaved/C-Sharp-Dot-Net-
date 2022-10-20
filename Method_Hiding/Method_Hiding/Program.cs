using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    class parent
    {
        public virtual void show1()
        {
            Console.WriteLine("virtual method from parent class");
        }
        public void show() /*same method*/ 
        {
            Console.WriteLine("parent class method");
        }
        public void Test()
        {
            Console.WriteLine("Test method of parent class");
        }
    }

    class child : parent
    {
        public override void show1()
        {
            Console.WriteLine("Override method from child class");
        }

        public new void show()
        {
            //base.show(); for calling parent class 
            Console.WriteLine("child class method");
        }

        public new void Test()
        {
           
            Console.WriteLine("Test method from child class");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent c=new child();
            c.Test();
            /*for calling parent class from inside child class*/
            child obj=new child();
            obj.Test();
            Console.ReadLine();

        }
    }
}

