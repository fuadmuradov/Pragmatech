using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_and_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Timsah", "Cingin Abdullayev", 511);
            Book book2 = new Book("Insan ovu", "Elxan Elatli", 351);
            Book book3 = new Book("Mehkumlar", "Anar", 243);
            Book book4 = new Book("Tersine cevrilen dunya", "Cingin Abdullayev", 720);

            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            library.Books.Add(book4);


            //List<Book> list = library.FinsAllBoksByName("Timsah");
            //foreach ( Book item in list)
            //{
            //    Console.WriteLine(item.name + " " + item.AuthorName + " " + item.PageCount + " " + item.code);
            //}

            //  library.RemoveAllBoksByName("Timsah");


            //List<Book> list = library.FindBooksByPageCountRange(200, 400);
            //foreach (Book item in list)
            //{
            //    Console.WriteLine(item.name + " " + item.AuthorName + " " + item.PageCount + " " + item.code);
            //}


            Console.WriteLine();
            foreach (Book item in library.Books)
            {
                Console.WriteLine( item.name + " " + item.AuthorName + " " + item.PageCount + " " + item.code);
            }


            Console.ReadLine();

        }
    }
}
