using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2
{
    class Medicine
    {
        public string Name;
        private int Price;
        private int Count;

        public Medicine(string name, int price, int count)
        {
            this.Name = name;

            Pricer = price;
            Counter = count;
        }

        public int Pricer
        {
            get
            {
                return Price;
            }

            set
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
        }
        public int Counter
        {
            get { return Count; }
            set
            {
                if (value > 0)
                {
                    Count = value;
                }
            }
        }

    }
}
