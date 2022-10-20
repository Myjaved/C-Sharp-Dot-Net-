using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPERTIES2
{
    public class student
    {
        private int _STDID;
        private string _STDNAME;

        //PROPERTIES have set and get methods
        public int STDID
        {
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Id Cant be Negative or Zero");
                }
                else
                {
                    this._STDID = value;
                }
                
            }
            get
            {
                return this._STDID;
            }
        }
         public string STDNAME
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your name");
                }
                else
                {
                    this._STDNAME = value;
                }

            }
            get
            {
                return this._STDNAME;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student S=new student();
            S.STDID = 20;
            S.STDNAME = "ABDUL";
            Console.WriteLine(S.STDID);
            Console.WriteLine(S.STDNAME);
            Console.ReadLine();

        } 
    }
}
