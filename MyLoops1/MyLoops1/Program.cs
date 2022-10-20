using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{

            //    int i;
            //    int sum = 0;
            //    Console.WriteLine("The natural numbers are :");
            //    for (i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //        sum = sum+ i;
            //    }

            //    Console.WriteLine("The Sum is :"+ sum);
            //    Console.ReadLine();
            //}


            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
            Console.ReadLine();
        }
       
    }
}
    
