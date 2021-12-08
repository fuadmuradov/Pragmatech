using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicines1 = new Medicine("Metamizol", 10, 5);

            Medicine medicines2 = new Medicine("Morfin", 15, 12);

            Medicine medicines3 = new Medicine("Piritramid", 7, 20);

            Medicine medicines4 = new Medicine("Piritramid", 7, 20);

            PharmacyManager manager1 = new PharmacyManager();

            manager1.Add(medicines1);
            manager1.Add(medicines2);
            manager1.Add(medicines3);
          //  manager1.Add(medicines4);

            foreach (var item in manager1.Medicines)
            {
                Console.WriteLine(item.Drug_Name + " " + item.Drug_Price + " " + item.Drug_Count);
            }
            Console.ReadLine();
        }
    }
}
