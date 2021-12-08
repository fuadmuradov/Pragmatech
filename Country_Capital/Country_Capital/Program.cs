using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Capital
{
    class Program
    {
        static void Main(string[] args)
        {
            string country, capital;
            Dictionary<string, string> CountCap = new Dictionary<string, string>();
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Zehmet olmasa olke adini qeyd edin: ");
               country =  Console.ReadLine();

                Console.WriteLine("Zehmet olmasa Paytaxt adini qeyd edin: ");
                capital = Console.ReadLine();
                CountCap.Add(country, capital);
            }
            country = ""; capital = "";
            Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin");
            country = Console.ReadLine();
            if(country=="all")
            {
                foreach (var item in CountCap)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            } else
            Console.WriteLine(CountCap[country]);

            Console.WriteLine("Yeni paytaxt axtarılsın ? Y / N");
            country = Console.ReadLine();
            if(country == "Y")
            {
                Console.WriteLine("Zehmet olmasa olke adini qeyd edin: ");
                country = Console.ReadLine();
                Console.WriteLine(CountCap[country]);
            }
            
            Console.ReadLine();
        }
    }
}
