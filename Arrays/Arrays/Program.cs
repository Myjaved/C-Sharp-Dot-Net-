using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* An Array is collection of (related values) elements of a single data type stored
            in adjacent memory Location */

            // An Array always stored value of a single DATA TYPE

            // 1st Method of creating an Array

            int[] My_Array = new int[5];                    
            My_Array[0] = 11;
            My_Array[1] = 22;                               //Int type array
            My_Array[2] = 33;
            My_Array[3] = 44;
            My_Array[4] = 55;

            Console.WriteLine(My_Array[2]);
            Console.WriteLine(My_Array[3]);
            Console.WriteLine(My_Array[4]);


            string[] My_Array2 = new string[3];
            My_Array2[0] = "Ali";
            My_Array2[1] = "Anas";                          //String Type Array
            My_Array2[2] = "Waqar";


            //2nd Method of creating an Array
            int[] My_Array3 = new int[] { 1, 2, 3 };

            //3rd Method of creating an Array
            int[] My_Array4 = { 1, 2, 3 };

            Console.ReadLine();

        }
    }
}
