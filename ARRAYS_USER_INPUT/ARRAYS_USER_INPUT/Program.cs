using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_USER_INPUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give number you wants to set in an array");
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data");
                int Data=int.Parse(Console.ReadLine());
                numbers[i] = Data;
            }
            
            Console.WriteLine("-----Your Data------");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

    }
}
