using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    public class Polymorphism                    //Method Overloading
    {
        public void add()
        {
            int a = 10;
            int b = 50;
            int c = a + b;
            Console.WriteLine(c);

        }

        public void add(int a ,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Polymorphism P=new Polymorphism();  
            P.add(2,4);
            Console.ReadLine();
        }
    }
}
