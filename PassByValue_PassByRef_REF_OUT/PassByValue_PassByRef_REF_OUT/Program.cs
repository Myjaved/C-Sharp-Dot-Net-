using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue_PassByRef_REF_OUT
{
    internal class Program
    {
        public static void PassByValue(ref int a)
        {
            a = a + 10;
            Console.WriteLine("The value of method A :"+a );
        }
        static void Main(string[] args)
        {
            int value = 100;
            Program.PassByValue(ref value);
            Console.WriteLine("value of Main method is "+ value);
            Console.ReadLine();
        }
    }
}
