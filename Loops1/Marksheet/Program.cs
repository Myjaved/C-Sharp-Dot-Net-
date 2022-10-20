using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 50; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //int number = 3;
            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(number + "*" +i +"= "+number*i);
            //    i++;
            //}
            //Console.ReadLine();


            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 0);

            Console.WriteLine("Do While Loop terminates");
            Console.ReadLine();

        }
    }
}
