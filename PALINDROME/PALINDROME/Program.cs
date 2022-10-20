using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALINDROME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //Console.WriteLine("Enter a string :");
            //str = Console.ReadLine();
            //str = str.ToLower();


            //char[] Javed = str.ToCharArray();             //Convert string to character array 
            //Array.Reverse(Javed);                         //Array is reversed here
            //string str_reverse = new string(Javed);         // Making an object of an array

            //Console.WriteLine("The reverse string is " + str_reverse);  //Printing reverse string

            //if (str_reverse == str)                          // Giving condition for Palindrome
            //{
            //    Console.WriteLine("Its a palindrome string");

            //}
            //else
            //{
            //    Console.WriteLine("Its not a palindrome string");
            //}
            //str_reverse = str.ToLower();
            //if (str.Equals(str_reverse))
            //{
            //    Console.WriteLine(str + ":--its a palindrome string");

            //}
            //else
            //{
            //    Console.WriteLine(str + ":--Its not palindrome string");
            //}

            while (true)
            {
                Console.WriteLine("Please enter any string which you want to reverse :");

                string str = Console.ReadLine().ToLower();
                //Console.WriteLine(str.GetType());
                char[] char_arr_str = str.ToCharArray();
                Console.WriteLine(char_arr_str);
                //Console.WriteLine(char_arr_str.GetType());
                Array.Reverse(char_arr_str);

                string Reverse = new string(char_arr_str);

                Console.WriteLine($"Your reverse string is : {Reverse}");
                if (str == Reverse)
                {
                    Console.WriteLine("Yes !! This string is palindrome");
                }
                else
                {

                    Console.WriteLine("Nope ! This string is not a palindrome");
                }

                Console.ReadLine();
            }
            




        }
    }
}
