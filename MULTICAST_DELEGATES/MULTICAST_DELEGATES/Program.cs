using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTICAST_DELEGATES
{
    public delegate void Calculation(int a ,int b);

    internal class Program
    {
        public static void Addition (int a ,int b)
        {
            int result = a + b;
            Console.WriteLine("The Addition Result is {0}",result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The Substraction Result is {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The Multiplication Result is {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("The Division Result is {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            //obj(3, 5);
            //Calculation obj1 = new Calculation(Multiplication);   //1st Method
            //obj1(80, 60);

            //obj = Substraction;                                    //2nd Method
            //obj(60, 40);

            //Calculation obj3 = new Calculation(Division);            // 3rd Method
            //obj3.Invoke(50, 25);

            obj += Substraction;
            obj += Multiplication;                   //Multicast Delegates
            obj -= Division;                         // Object is One but refercence difference            obj(100, 50);
            obj(100, 50);
            Console.ReadLine();
        }
    }
}
