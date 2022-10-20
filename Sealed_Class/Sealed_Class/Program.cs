using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    sealed class baseclass /*sealed keyword is preferable*/
    { 
     public void show1()
        {
            Console.WriteLine("this is method of baseclass");   
        }
    }
    class childclass : baseclass
    {
        public void show2()
        {
            Console.WriteLine("this is method of childclass");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
