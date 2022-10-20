using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    class Person
    {
        public virtual void show()
        {
            Console.WriteLine("this is method of class A");
        }
    }
    class Teacher : Person 
    {
        public sealed override void show()    /*sealed keyword for method and always used in overriding*/
        {
            Console.WriteLine("this is method of class B");

        }

    }
    class Student 
    {
        public void show()
        {
            Console.WriteLine("this is method of class C");

        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Student S=new Student();
            S.show();
            
            Console.ReadLine();

        }
    }
}
