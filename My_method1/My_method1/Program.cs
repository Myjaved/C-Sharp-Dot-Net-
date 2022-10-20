using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_method1
{
    class Program
    {
        public void Add(int a ,int b)
        {
            int c = a + b ; 
            Console.WriteLine("Addition Result is :" + c);
        }
        
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Add(50,50);
            //Program.Add(2,1000);
            Console.ReadLine();
        }
    }

}
