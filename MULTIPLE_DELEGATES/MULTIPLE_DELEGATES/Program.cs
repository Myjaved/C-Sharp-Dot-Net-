using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTIPLE_DELEGATES
{
    public delegate void Calculation(int a ,int b);   //Delegates with different Parameters
    public delegate void Show_Delegates();
    public delegate void Show1_Delegates(int a);
    internal class Program
    {
        public static void Square(int a)
        {
            int B = a * a;
            Console.WriteLine("The Square of {0} is : {1}",a,B);
        }
        public static void Cube (int a)
        {
            int B = a * a * a ;
            Console.WriteLine("The Cube of {0} is : {1}", a, B);
        }

        public static void show()
        {
            Console.WriteLine("This is Show Method");
        }

        public static void Addition(int a ,int b)
        {
            int result = a + b;
            Console.WriteLine("The Addition result is {0}",result);
        }

        public static void Multiplication (int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The Multiplication result is {0}", result);
        }

        static void Main(string[] args)
        {
            //Show_Delegates obj = new Show_Delegates(show);
            //obj.Invoke();

            Show1_Delegates SQ = new Show1_Delegates(Square);
            SQ(25);

            Show1_Delegates SQ1 = new Show1_Delegates(Cube);
            SQ1(3);
            Console.ReadLine();
        }
    }
}
