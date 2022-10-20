using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    public delegate void Calculation(int a ,int b);

    internal class Program
    {
        public void Addition(int a,int b )
        {
            int result = a + b;
            Console.WriteLine("The Addition result is {0}",result);

        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The Substraction result is {0}", result);

        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The Multiplication result is {0}", result);

        }
        static void Main(string[] args)
        {
            //Calculation obj = new Calculation(Program.Addition);
            //obj.Invoke(10, 30);   1st method
            //obj = Substraction;
            //obj(30,10);
            //obj = Multiplication;
            //obj(30,10);
            Program p=new Program();
            Calculation obj = new Calculation(p.Addition);
            obj(100, 50);
            Calculation obj1 = new Calculation(Program.Substraction);
            obj1(100, 50);
            Calculation obj2 = new Calculation(Program.Multiplication);
            obj2(100, 50);
            
            Console.ReadLine();
        }
    }
}
