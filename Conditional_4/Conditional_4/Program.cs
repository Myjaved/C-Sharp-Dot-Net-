using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Pizza flavour");
            string Pizza=Console.ReadLine().ToLower();

            switch(Pizza)
            {
                case "russian":
                    Console.WriteLine("You have selected Russian Pizza");
                    break;
                case "afgani":
                    Console.WriteLine("You have selected Afgani Pizza");
                    break;
                case "veg":
                    Console.WriteLine("Enter your Veg Pizza flavour");
                    string veg =Console.ReadLine();    
                    switch(veg)
                    {
                        case "onion":
                            Console.WriteLine("You have selected Onion flavour Pizza");
                            break ;
                        case "garlic":
                            Console.WriteLine("You have selected Garlic flavour Pizza");
                            break;
                        case "ginger":
                            Console.WriteLine("You have selected Garlic flavour Pizza");
                            break;
                        default:
                            Console.WriteLine("This Flavour not found");
                            break;
                    }
                    break;

                case "chicken":
                    Console.WriteLine("You have selected Chicken Pizza");
                    break;
                default:
                    Console.WriteLine("Pizza flavour not available");
                    break ;

            }
            Console.ReadLine();

        }
    }
}
