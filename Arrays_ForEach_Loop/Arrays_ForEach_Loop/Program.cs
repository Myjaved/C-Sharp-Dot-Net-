using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_ForEach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names= new string[4];
            names[0] = "IBRAHIM";
            names[1] = "FARHAAN";
            names[2] = "HAIDER";
            names[3] = "JAVED";

            foreach (String item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
    }
}
