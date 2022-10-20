using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extended_Methods
{
    internal static class Extended
    {
        public static void Func3(this Program P)
        {
            Console.WriteLine("This is method of third Function");
        }
    }
}
