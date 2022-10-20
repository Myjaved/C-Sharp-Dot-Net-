using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLoops3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Uva", "Ertiga", "Jeep", "Mazda", "Impala","Scorpio"};

            //Access using for loop
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }



            //Access using foreach loop

            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //Console.WriteLine(cars.Length);
            Console.ReadLine();


        }
    }
}
