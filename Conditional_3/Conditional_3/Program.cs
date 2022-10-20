using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your Day");
            string question = Console.ReadLine();
               

            switch (question)
            {
                case "Monday":
                    Console.WriteLine("Today is your school ");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today MIDC holiday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Today is Night shift");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Veg day");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Juma Namaj");
                    break;
                case "Satuday":
                    Console.WriteLine("Today is Half day");
                    break;
                case "Sunday":
                    Console.WriteLine("Holiday, No Work Today");
                    break;
                default:
                    Console.WriteLine("Do Whatever You want");
                    break;
            }
            Console.ReadLine();
        }
    }
}
        
