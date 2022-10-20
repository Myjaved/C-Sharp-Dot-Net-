using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myloops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm;
            do 
            {
                int i = 1;
                Console.WriteLine("Enter Number :");
                int number = Convert.ToInt32(Console.ReadLine());

                while (i <= 10)
                {

                    Console.WriteLine(number + "*" + i + "=" + i * number);
                    i++;

                }
                
                Console.WriteLine("Do You Want to Continue ? Yes / No ");
                confirm = Console.ReadLine().ToLower();
            }
             
              while(confirm=="yes");


            
            //while(true)
            //{
            //    int i = 1;
            //    Console.WriteLine("Enter No.:");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    while (i <= 10)
            //    {

            //        Console.WriteLine(number + "*" + i + "=" + i * number);
            //        i++;

            //    }
            //    Console.WriteLine("Do You Want to Continue ? Yes / No ");
            //    string confirm = Console.ReadLine().ToLower();

            //    if (confirm == "yes")
            //    {
            //        continue;
            //    }

            //    else
            //    {
            //        break;
            //    }
            //}

        }

    }
}
















