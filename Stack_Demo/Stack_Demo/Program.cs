using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> stack1 = new Stack<string>();
            //string[] str = 
            //{
            //    "MCA",
            //    "BCA",
            //    "BBA",
            //    "MBA",
            //    "MTech"
            //};
            //Stack<string> stack2 = new Stack<string>(str);
            //Stack<string> stack3 = new Stack<string>(10);
            //Console.WriteLine("The elements in the stack1 are:" + stack1.Count());
            //Console.WriteLine("The elements in the stack2 are:" + stack2.Count());
            //Console.WriteLine("The elements in the stack3 are:" + stack3.Count());
            //Console.ReadLine();

           
            Stack<string> stack1 = new Stack<string>();
            
            stack1.Push("MCA");
            stack1.Push("MBA");
            stack1.Push("BCA");
            stack1.Push("BBA");
            
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (object s in stack1)
            {
                Console.WriteLine(s);
            }
            //For remove/or pop the element pop() method is used  
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();
            Console.WriteLine("After removal/or pop the element the stack is as:");
            //the element that inserted in last is remove firstly.  
            foreach (object s in stack1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
