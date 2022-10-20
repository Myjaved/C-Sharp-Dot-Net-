using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESTRUCTOR
{
    class person 
    {
        public string Name;
        public int age;

        public person(string name,int age)
        {
            this.Name = name;
            this.age = age; 
        }

        public string getname() 
        {
            return this.Name;
        }
        public int getage()
        {
            return this.age;
        }

        ~person()
        {
            Console.WriteLine("Destructor has been invoked");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person Ali = new person("Ali Khan",28);
            person Javed = new person("Javed SHaikh", 31);

            Console.WriteLine(Ali.getname());
            Console.WriteLine(Ali.getage());
            Console.WriteLine("-----------------------");
            Console.WriteLine(Javed.getname());
            Console.WriteLine(Javed.getage());

            //Console.ReadLine();                  //ctrl +f5 for screen hold
        }
    }
}
