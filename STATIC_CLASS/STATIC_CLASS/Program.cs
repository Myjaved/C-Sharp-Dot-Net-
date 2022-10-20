using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_CLASS
{
     static class product 
    {
        public static int productID;
        public static string productName;
        public static int productPrice;
        public static int DiscPrice;

        static product()
        {
            productID = 20;
            productName = "Guitar";
            productPrice = 10000;
            DiscPrice = 500;
           
                
        }
        public static void getdetails()
        {
            Console.WriteLine("The product ID is {0}",productID);
            Console.WriteLine("The product Name is {0}", productName);
            Console.WriteLine("The product price is {0}", productPrice);
        }

        public static void getDiscount()
        {
            DiscPrice =(productPrice / 10);
            Console.WriteLine("The discount is {0}",DiscPrice);
            Console.WriteLine("The total price is {0}", (productPrice - DiscPrice));
            
        }

     }
    internal class Program
    {
        static void Main(string[] args)
        {
            product.getdetails();
            product.getDiscount();
            Console.ReadLine();
        }
    }
}
