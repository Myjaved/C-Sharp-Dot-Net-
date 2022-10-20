using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor1
{
    class person 
    {
        public static string PersonName;
        public static int PersonAge;

        static person()
        {
            PersonName = "Dawood";
            PersonAge = 40;
            Console.WriteLine("Static Constructor invokes");
        }
        public void GetDetails()
        {
            Console.WriteLine("person name is {0}",PersonName);
            Console.WriteLine("person age is {0}",PersonAge);
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person obj=new person();
            person T = new person();
            T.GetDetails();
            Console.ReadLine();
        }
    }
}
