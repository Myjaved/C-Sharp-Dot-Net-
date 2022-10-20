using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine("Todays Date is : {0:ddd}",dt);
            Console.ReadLine();
        }
    }
}
