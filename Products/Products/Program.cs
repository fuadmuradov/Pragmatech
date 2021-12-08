using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product(Producttype.Bakery, 100);
            product.name = "Nur";

            Product product1 = new Product(Producttype.Drink, 500);
            product1.name = "Milla";

            Product product2 = new Product(Producttype.Fish, 900);
            product2.name = "Pirana";

            Console.WriteLine(product.type + " " +product.name+ " " + product.code + " " + product.discPrice +
              " " + product.price + " " + Product.totalcount);
            Console.WriteLine(product1.type + " " + product1.name + " " + product1.code + " " + product1.discPrice +
              " " + product1.price + " " + Product.totalcount);
            Console.WriteLine(product2.type + " " + product2.name + " " + product2.code + " " + product2.discPrice +
             " " + product2.price + " " + Product.totalcount);




            Console.ReadLine();
        }
    }
}
