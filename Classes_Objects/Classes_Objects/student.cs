using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class student
    {
        int rollNo;
        int age;
        int standard;
        string name;

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public void setAge(int Age)
        {
            this.age= Age;
        }
        public int getRollNo()
        {
            return this.rollNo;

        }

        public int getAge()
        {
            return this.age;

        }
        static void Main(string[] args)
        {
            student Ali = new student();
            Ali.setRollNo(1);
            Console.WriteLine(Ali.getRollNo());
            Console.ReadLine(); 
        }
    }
}
