using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifier
{
    public class class1
    {
        protected void show()
        {
            Console.WriteLine("This is protected version");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c1=new class1();
            c1.show; 
            Console.ReadLine();
        }
    }
}
