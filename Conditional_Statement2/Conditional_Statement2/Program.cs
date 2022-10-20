using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your mail id :");
            String email=Console.ReadLine();

            if (email == "jshaikh003@gmail.com")
            {
                Console.WriteLine("Please Enter your Password :");
                String Pass = Console.ReadLine();

                if(Pass == "nairenai")
                {
                    Console.WriteLine("Your Login Successful!!"); 
                }
                else
                {
                    Console.WriteLine("Sorry!Login Failed ");
                }
            }
            
            else
            {
                Console.WriteLine("invalid mail,Please try again");
            }

            Console.ReadLine();




            

        }
    }
}
