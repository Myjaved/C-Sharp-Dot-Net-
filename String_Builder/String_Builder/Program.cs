using System;
using System.Diagnostics;
using System.Text;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "JAVED";
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    s1 = s1 + i;
            //}
            //sw1.Stop();

            //StringBuilder sb = new StringBuilder("Hello");
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i);
            //}
            //sw2.Stop();

            //Console.WriteLine("time taken by string" + " " + sw1.ElapsedMilliseconds);
            //Console.WriteLine("time taken by string builder" + " " + sw2.ElapsedMilliseconds);
            //Console.ReadLine();


            //String Literal in C#

            //string a = "Javed is lerning C#";
            //int age = 65;
            //Console.WriteLine($"{a} through CWH and LNE and His age is {age}");


            //Ternary Operator
            int b = 50;
            Console.WriteLine( $"The value of B is {b}");
            Console.WriteLine("So Please enter Your number here");
            int a = int.Parse(Console.ReadLine());
            string x= (a >= b) ?"A is greater":"A is Smaller";
            Console.WriteLine($"The result is : {x}");
            Console.ReadLine();




        }

    }
}
