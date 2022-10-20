using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_TYPES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged Array

            int[][] MyArray1 = new int[3][];
            MyArray1[0] = new[] { 10, 12, 14, 15, 16, 18 };
            MyArray1[1] = new[] { 10, 12, 14, 15, 16, 18, 16, 24, 57, 94 };
            MyArray1[2] = new[] { 10, 12, 14, 15 };

            //for (int i = 0; i < MyArray1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < MyArray1[i].Length; j++)
            //    {
            //        Console.Write(MyArray1[i][j] + " ");
            //    } 
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            foreach (int[] item in MyArray1)
            {
                foreach (int i in item)
                {
                    Console.WriteLine(i + " ");
                }

            }
            Console.ReadLine();


            //rectangular Array

            //int[,] MyArray = new int[3, 4]
            //{
            //    {11,22,33,44 },
            //    {12,45,34,98 },
            //    {56,64,81,26 }

            //};


            //foreach (int item in MyArray)
            //{
            //    Console.WriteLine(" "+item+" ");

            //} 

            //for (int i = 0; i < MyArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < MyArray.GetLength(1); j++)
            //    {
            //        Console.Write(MyArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();
        }
    }
}
