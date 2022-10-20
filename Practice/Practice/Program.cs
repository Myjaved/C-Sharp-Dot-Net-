using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        public  void show()
        {
            Console.WriteLine("Show method");
        }
        public int show(int x)
        {
            return x;

        }

        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine(p.show(6)); ;
            
            Console.ReadLine();
        }
    }
}
