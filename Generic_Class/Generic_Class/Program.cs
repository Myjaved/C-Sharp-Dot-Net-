using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Example
    {
        public static void showarray<G>(G[] arr)   //use < > in place of data type
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //public static void showarray(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        public static bool check_condition<F>(F a,F b)
        {
            bool c = a.Equals(b);
            return c;

        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            string[] names = { "Javed", "Usman", "Ali", "Anwar" };
            double[] points = { 2.6, 66.5, 89.33, 69.33 };
            Example.showarray(names);
            Example.showarray(num);
            Example.showarray(points);
            Console.WriteLine(Example.check_condition(69.33,69.33));
            Console.ReadLine();

        }
    }
}
