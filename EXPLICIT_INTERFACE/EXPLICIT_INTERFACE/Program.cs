using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPLICIT_INTERFACE
{
    interface I1
    {
        void show();
        
    }
    interface I2
    {
        void show();
        
    }

    class Myexample : I1, I2
    {
        public void show()    // Implicit implimentation
        {
            Console.WriteLine("This is the method of I2 Interface");
        }

        void I1.show()    // Explicit implimentation
        {
            Console.WriteLine("This is the method of I1 Interface");
        }

        
    }


    internal class Program
    {
        static void Main(string[] args)            
        {
            I1 obj1=new Myexample();
            obj1.show();
            Myexample obj2=new Myexample();
            obj2.show();

            Console.ReadLine();
            
        }
    }
}
