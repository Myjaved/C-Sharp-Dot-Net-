using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    class Employee
    {
        private int[] age = new int[3];

        
        public int this[int index]
        {
            
            set 
            {
                if (index >= 0 && index < age.Length)
                {
                    if (value > 0)
                    {

                        age[index] = value;
                }
                    else
                    {
                        Console.WriteLine("invalid value !!!");
                    }
                }
                else
                {
                    Console.WriteLine("invalid index");
                }
            }
            get 
            {
                return age[index]; 
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[2] = 32;
            Console.WriteLine(emp[2]);
            Console.ReadLine();
        }
    }
}
