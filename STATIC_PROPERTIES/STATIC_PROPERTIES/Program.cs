using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_PROPERTIES
{
    //cant create static property for instance fields
    // i.e. private string personName - its an instance field
    
    class university
    {
        private static string University_Name;
        private static string Department_Name;

        public static string _University_Name 
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid value");
                }
                else
                {
                    University_Name = value;
                }
                
            }
            get
            {
                return University_Name;
            }   
        
        }

        public static string _Department_Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid value");
                }
                else 
                {
                    Department_Name = value;
                }
                
            }
            get
            {
                return Department_Name;
            }

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            university._University_Name = "OXFORD UNIVERSITY";
            university._Department_Name = "Physics Department";
            Console.WriteLine(university._University_Name);
            Console.WriteLine(university._Department_Name);
            Console.ReadLine();
            
        }
    }
}
