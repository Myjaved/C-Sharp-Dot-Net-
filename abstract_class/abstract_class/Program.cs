using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTARCTCLASS
{
    class student
    {
        int id;
        string name;
        int age;
        public void Setstudentdetails(int ID,string Name,int Age)
        {
            this.id = ID;
            this.name = Name;
            this.age = Age;
        }
        public void GetStudentsDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }


    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            student obj=new student();
            obj.Setstudentdetails(2, "Javed", 32);
            obj.GetStudentsDetails();
            Console.ReadLine();
        }
    }
}
