using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassa_Aparati_task_2
{
    class CashRegister
    {
        private static double TotalAmount=0;
        public Currency currency;
        public Paymenttype paymenttype;
        private static int TotalSalesCount=0;


        public static double totalamount
        {
            get { return TotalAmount; }
        }

        public static int totalsalescount
        {
            get { return TotalSalesCount; }
        }
        public enum Currency
        {
            USD,
            EURO,
            TL
        }

       public enum Paymenttype
        {
            Card,
            Cash
        }

        public static void AddSale(Currency currency, double amount)
        {
            TotalAmount = TotalAmount + CurrencyConverter(currency, amount);
            TotalSalesCount++;
        }

        public static void RemoveSale(Currency currency, double amount)
        {
            TotalAmount = TotalAmount - CurrencyConverter(currency, amount);
            TotalSalesCount++;
        }


        public static double CurrencyConverter(Currency currencytypes, double amount)
        {
            double azn = 0;
            if (currencytypes == Currency.USD)
            {
                azn = amount * 1.7;
                azn = Math.Round(azn, 2);
            }
            else
                  if (currencytypes == Currency.EURO)
            {
                azn = amount * 1.92;
                azn = Math.Round(azn, 2);
            }
            else
                  if (currencytypes == Currency.TL)
            {
                azn = amount * 0.14;
                azn = Math.Round(azn, 2);
            }
            return azn;
        }
    }


}
