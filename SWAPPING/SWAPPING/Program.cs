using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPPING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            Console.WriteLine("-------Before Swapping-------");
            Console.WriteLine("a is :"+a);
            Console.WriteLine("b is :" + b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("-------After Swappning-------:");
            Console.WriteLine("a is : "+a);
            Console.WriteLine("b is : "+b);
            Console.ReadLine();
        }
    }
}
