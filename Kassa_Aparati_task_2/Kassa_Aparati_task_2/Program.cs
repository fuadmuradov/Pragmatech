using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassa_Aparati_task_2
{
    class Program
    {
        static void Main(string[] args)

        {
            CashRegister cashRegister = new CashRegister();
            Console.WriteLine("Enter How many products do you ADD!!");
           // CashRegister.AddSale(CashRegister.Currency.USD, 21);
            int k = Convert.ToInt32(Console.ReadLine());
            AddingElements(k);
            Console.WriteLine("What do you want: Add or Remove Sell?");
            Console.WriteLine("1-Add   2-Remove\nSelect one number:");
            k = Convert.ToInt32(Console.ReadLine());

            if (k != 1 && k != 2)
            {
                do
                {
                    Console.WriteLine("Please select RIGHT number: 1 or 2 !!!");
                    k = Convert.ToInt32(Console.ReadLine());
                } while (k != 1 && k != 2);

            }
            if (k == 1)
            {
                AddingElements(k);
            }
            if (k == 2)
            {
                RemovingElements();

            }


            Console.ReadLine();

        }

        public static void RemovingElements()
        {
            Console.WriteLine($"You can select USD, EURO, TL \nYou have to Choose Currency and Amount for {1} times:");
            string a;
            double money;

            for (int i = 0; i < 1; i++)
            {
                a = Console.ReadLine().ToUpper();

                money = Convert.ToDouble(Console.ReadLine());

                if (a.ToUpper() == "USD")
                {
                    CashRegister.RemoveSale(CashRegister.Currency.USD, money);
                }
                else
                     if (a.ToUpper() == "EURO")
                {
                    CashRegister.RemoveSale(CashRegister.Currency.EURO, money);
                }
                else
                     if (a.ToUpper() == "TL")
                {
                    CashRegister.RemoveSale(CashRegister.Currency.TL, money);
                }
                else Console.WriteLine("You Would Choose Correct Currency Type!!!");

            }

            Console.WriteLine($" totalAmount: {CashRegister.totalamount} \nTotalSalesCount: {CashRegister.totalsalescount}");
        }
        public static void AddingElements(int k)
        {
            Console.WriteLine($"You can select USD, EURO, TL \nYou have to Choose Currency and Amount for {k} times:");
            string a;
            double money;

            for (int i = 0; i < k; i++)
            {
                a = Console.ReadLine().ToUpper();

                money = Convert.ToDouble(Console.ReadLine());

                if (a.ToUpper() == "USD")
                {
                    CashRegister.AddSale(CashRegister.Currency.USD, money);
                }
                else
                     if (a.ToUpper() == "EURO")
                {
                    CashRegister.AddSale(CashRegister.Currency.EURO, money);
                }
                else
                     if (a.ToUpper() == "TL")
                {
                    CashRegister.AddSale(CashRegister.Currency.TL, money);
                }
                else Console.WriteLine("You Would Choose Correct Currency Type!!!");

            }

            Console.WriteLine($" totalAmount: {CashRegister.totalamount} \nTotalSalesCount: {CashRegister.totalsalescount}");
        }

    }
}
