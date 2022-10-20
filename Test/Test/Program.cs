using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "one", "two", "three", "four", "five" };
            str.Reverse();
            Console.WriteLine(str);
            Console.ReadLine(); 
        }
    }
}
