using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUGHWORK
{
    internal class Program
    {
        string name;
        string fname;
        string mname;
        

        public Program(string Name,string Fname,string Mname)

        {
            name = Name;
            fname = Fname;
            mname = Mname;
            
        }

        public Program(Program p)
        {
            name = p.name;
            mname = p.mname;
            fname=p.fname;
            
        }

        public void getdetails()
        {
            Console.WriteLine(name);
            Console.WriteLine(fname);
            Console.WriteLine(mname);
            
        }

        static void Main(string[] args)
        {
            Program Javed = new Program("Javed", "Hamid", "Tabassum");
            Javed.getdetails();
            Program obj2=new Program(Javed);
            obj2.getdetails();
            Program obj3 = new Program(Javed);
            obj3.getdetails();


            Console.ReadLine();
        } 
    }
}
