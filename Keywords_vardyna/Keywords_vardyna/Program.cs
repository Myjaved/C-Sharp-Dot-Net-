using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords_vardyna
{
    internal class Program
    {
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("value is:{0}",a);
        }
            
        static void Main(string[] args)
        {

            int value = 10;
            PassByValue(value);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
