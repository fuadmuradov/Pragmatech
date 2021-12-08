using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {


        public string BookName;
        public int ISBN;
        public static int No=1000;
        public int BookId;
        public Janr BookJanr;
        public int Price;
        public Book(string name, int isbn, int price, Janr janr)
        {
            this.BookName = name;
            this.ISBN = isbn;
            this.Price = price;
            this.BookId = No;
            No++;
            this.BookJanr = janr;
        }

       public enum Janr
        {
            Dedektiv,
            Psixoloji,
            Siyasi,
            Romantik,
            Fantastik
        }
    }
}
