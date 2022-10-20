using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Function
{
    public delegate int MyDelegate(int num);

    internal class Program
    {
        
        //public static void MyMethod(int a)
        //{  
        //    a += 10;
        //    Console.WriteLine(a);
        //}

        static void Main(string[] args)
        {
            //MyDelegate obj = new MyDelegate(Program.MyMethod);
            //obj.Invoke(50);

            MyDelegate obj= delegate (int a)
            {
                a += 10;
                return a;
            };

            Console.WriteLine(obj(10));
            
            Console.ReadLine();
        }
    }
}
