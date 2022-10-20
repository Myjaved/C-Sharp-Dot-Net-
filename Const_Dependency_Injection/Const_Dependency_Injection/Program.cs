﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Dependency_Injection
{
    internal class Program
    {
        public interface text
        {
            void print();
        }
        class format : text
        {
            public void print()
            {
                Console.WriteLine(" here is text format");
            }
        }
        // constructor injection
        public class constructorinjection
        {
            private text _text;
            public constructorinjection(text t1)
            {
                this._text = t1;
            }
            public void print()
            {
                _text.print();
            }
        }
        static void Main(string[] args)
        {
            constructorinjection cs=new constructorinjection(new format());
            cs.print();
            Console.ReadKey();
        }
    }
}
