using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }

    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            Console.WriteLine("Enter Card Type");
            //string cardType = "MoneyBack";
            string cardType = Console.ReadLine().ToLower();
           
            ICreditCard cardDetails = null;

            /*Based of the CreditCard Type we are creating the
            appropriate type instance using if else condition*/

            if (cardType == "moneyback")
            {
                cardDetails = new MoneyBack();
            }
                
            else if (cardType == "titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "platinum")
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
    

