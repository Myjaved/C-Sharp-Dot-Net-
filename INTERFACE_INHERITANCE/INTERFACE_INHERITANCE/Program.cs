using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE_INHERITANCE
{
    public interface I1
    {
        void print1();
    }
    public interface I2
    {
        void print2();
    }
    public interface I3 : I1, I2    
    {
        void print3();
    }

    class Program : I3
    {
        public void print3()
        {
            Console.WriteLine("this is the method of I3");
        }
        public void print2()
        {
            Console.WriteLine("this is the method of I2");
        }
        public void print1()
        {
            Console.WriteLine("this is the method of I1");
        }

        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.print1();
            obj.print2();
            obj.print3();

            I1 obj1=new Program();
            obj1.print1();
            I2 obj2 = new Program();
            obj2.print2();
            
            Console.ReadLine();



        }
    }
}
