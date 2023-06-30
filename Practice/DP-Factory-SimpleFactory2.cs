using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Factory_SimpleFactory2
    {
        public interface ICreditCard
        {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }

        public class MoneyBack: ICreditCard
        {
            public string GetCardType()
            {
                return "MoneyBack";
            }
            public int GetCreditLimit()
            {
                return 50000;
            }
            public int GetAnnualCharge()
            {
                return 500;
            }
        }
        public class Titanium: ICreditCard
        {
            public string GetCardType()
            {
                return "Titanium";
            }
            public int GetCreditLimit()
            {
                return 150000;
            }
            public int GetAnnualCharge()
            {
                return 100;
            }
        }
        public class Platinum: ICreditCard
        {
            public string GetCardType()
            {
                return "Platinum";
            }
            public int GetCreditLimit()
            {
                return 200000;
            }
            public int GetAnnualCharge()
            {
                return 1000;
            }
        }
        public class CreditCardFactory
        {
            public static ICreditCard GetCreditCardObject(string type)
            {
                if (type == "MoneyBack")
                {
                    return new MoneyBack();
                }
                else if (type == "Titanium")
                {
                    return new Titanium();
                }
                else return new Platinum();
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        ICreditCard _cc = CreditCardFactory.GetCreditCardObject("Titanium");
        //        _cc.GetCreditLimit();
        //        _cc.GetAnnualCharge();
        //        _cc.GetCardType();
        //    }
        //}
    }
}
