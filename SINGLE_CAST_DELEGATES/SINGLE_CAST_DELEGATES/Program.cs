using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGLE_CAST_DELEGATES
{

    internal class Program
    {
        public delegate void Calculation(int a, int b);

        public static void Addition(int a, int b)
        {
            int result = a+b;
            Console.WriteLine("The Addition Result is {0}",result);

        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            obj(60, 40);
            Console.ReadLine();

        }
    }
}
