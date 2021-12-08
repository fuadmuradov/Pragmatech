using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Currencytypes, double> currencies = new Dictionary<Currencytypes, double>();
           
            Console.WriteLine("Choose How many time do  you Exchange?");
          
            int k = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"You can select USD, EURO, TL \nYou have to Choose Currency and Amount for {k} times:");
            string a;
            double money;
            for(int i =0; i<k; i++)
            {
                a = Console.ReadLine();
                money = Convert.ToDouble(Console.ReadLine());
                if (a.ToUpper() == "USD")
                {
                    currencies.Add(Currencytypes.USD, money);
                }
                else
                     if (a.ToUpper() == "EURO")
                {
                    currencies.Add(Currencytypes.EURO, money);
                }
                else
                     if (a.ToUpper() == "TL")
                {
                    currencies.Add(Currencytypes.TL, money);
                }
                else Console.WriteLine("You Would Choose Correct Currency Type!!!");

            }


            foreach (var item in currencies)
            {
                Exchangee(item.Key, item.Value);
            }


            Console.ReadLine();
        }

       public enum Currencytypes
        {
            USD,
            EURO,
            TL
        }

        public static void Exchangee(Currencytypes currencytypes,double amount)
        {
            double azn = 0;
           // Console.WriteLine(currencytypes + " " + amount); 
           if(currencytypes == Currencytypes.USD)
            {
                azn = amount * 1.7;
                azn = Math.Round(azn, 2);
                Console.WriteLine($"{amount} USD = {azn} AZN");
            }
           else
                 if (currencytypes == Currencytypes.EURO)
            {
                azn = amount * 1.92;
                azn = Math.Round(azn, 2);
                Console.WriteLine($"{amount} EURO = {azn} AZN");
            }
            else
                 if (currencytypes == Currencytypes.TL)
            {
                azn = amount * 0.14;
                azn = Math.Round(azn, 2);
                Console.WriteLine($"{amount} TL = {azn} AZN");
            }

        }


    }
}
