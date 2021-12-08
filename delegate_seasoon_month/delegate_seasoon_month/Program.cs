using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_seasoon_month
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ilin aylarini daxil edin:");
            //int month = Convert.ToInt32(Console.ReadLine());


           // Writer writer = new Writer();

            int number =Convert.ToInt32( Console.ReadLine());
            
            Action<int> action = delegate (int k)
            {
                if (k < 0) Console.WriteLine("eded menfidir");
                else
                    Console.WriteLine("eded musbetdir");
            };

            action += isdivited;

            action += k =>
            {
                if (k % 2 == 0) Console.WriteLine($"{k} is Even");
                else Console.WriteLine($"{k} is Odd");
            };

            action.Invoke(number);

            //Writer writer = new Writer(translatemonth);
            //writer += translateseason;
            //writer += PrintInfo;

            //writer.Invoke(month);

            Console.ReadLine();
        }

       // public delegate void Writer(int a);

        static void isdivited(int k)
        {
            if (k % 5 == 0) Console.WriteLine($"{k} is divited by 5");
            else Console.WriteLine($"{k} is not divited by 5");
        }

        static void PrintInfo(int month)
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine("Qisda Qar yagmalidir");
                    break;
                case 2:
                    Console.WriteLine("Qisda Qar yagmalidir");
                    break;
                case 3:
                    Console.WriteLine("Yarpaqlar yasil olur");
                    break;
                case 4:
                    Console.WriteLine("Yarpaqlar yasil olur");
                    break;
                case 5:
                    Console.WriteLine("Yarpaqlar yasil olur");
                    break;
                case 6:
                    Console.WriteLine("Havalar isti olur");
                    break;
                case 7:
                    Console.WriteLine("Havalar isti olur");
                    break;
                case 8:
                    Console.WriteLine("Havalar isti olur");
                    break;
                case 9:
                    Console.WriteLine("yarpaqlar saralir");
                    break;

                case 11:
                    Console.WriteLine("Yarpaqlar saralir");
                    break;
                case 12:
                    Console.WriteLine("Qisda Qar yagmalidir");
                    break;
            }
        }
        static void translatemonth(int k)
        {
            switch (k)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;

                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
            }
        }
        static void translateseason(int k)
        {
            switch (k)
            {
                case 1:
                    Console.WriteLine("Winter");
                    break;
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                    Console.WriteLine("Spring");
                    break;
                case 4:
                    Console.WriteLine("Spring");
                    break;
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                    Console.WriteLine("Summer");
                    break;
                case 7:
                    Console.WriteLine("Summer");
                    break;
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                    Console.WriteLine("Autumn");
                    break;

                case 11:
                    Console.WriteLine("Autumn");
                    break;
                case 12:
                    Console.WriteLine("Winter");
                    break;
            }
        }
    }
}
