 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private int _StdId;
        private string _StdName;
        private string _StdLName;

        public int StdID 
        {
            set
            {
                this._StdId = value;
            }

            get
            {
                return this._StdId;

            }
        }
        public string StdName
        {
            set
            {
                this._StdName = value;
            }

            get
            {
                return this._StdName;

            }
        }
        public string StdLName
        {
            set
            {
                this._StdLName = value;
            }

            get
            {
                return this._StdLName;

            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                Student s = new Student();
                s.StdID = 20;
                s.StdName = "ADIL";
                s.StdLName = "Mehmood";
                Console.WriteLine(s.StdLName);
                Console.WriteLine(s.StdName);
                Console.WriteLine(s.StdID);


                Console.ReadLine();

            }
        }
    }
}


