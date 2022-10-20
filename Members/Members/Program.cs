using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class student
    {
        public int rollNo;
        string firstname;
        string lastname;
        int standard;


    }
   internal class Program
   {
        static void Main(string[] args)
        {
            student Ali = new student();
            Ali.rollNo = 30;
            student Tahir=new student();
            Tahir.rollNo = 31;
            Console.WriteLine("Ali's Roll No :"+Ali.rollNo );
            Console.WriteLine("Tahirs's Roll No: "+ Tahir.rollNo);
            Console.ReadLine();

        }
   }
}
