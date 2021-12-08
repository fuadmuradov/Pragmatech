using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        public string code;
        public string name;
        public int price;
        public int discPrice;
        public static int no = 1000;
        public Producttype type;
        public static int totalcount=0;
        public Product(Producttype type, int price)
        {
            string types = Convert.ToString(type);
            this.type = type;
            this.price = price;
            if (type == Producttype.Bakery)
            {
                discPrice = (price * 9) / 10;
            }
            else
            {
                discPrice = price;
            }
            code = types[0] + Convert.ToString(no);

            totalcount++;
            no++;
        }

    }
    enum Producttype
    {
        Bakery,
        Drink,
        Meat,
        Fish
    }
}
