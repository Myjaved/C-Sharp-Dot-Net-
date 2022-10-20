using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    public class class1
    {
        public void show1()
        {
            Console.WriteLine("This is C# programing ");
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            class1 c1=new class1();
            c1.show1();
        }
    }
}

