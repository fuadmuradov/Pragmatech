using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library
{
    class Library_Management
    {
        public static List<Book> Books = new List<Book>();

        public void AddBooks(Book book)
        {
            bool havebook = false;

            foreach(var item in Books)
            {
                if(item.ISBN==book.ISBN)
                {
                    havebook = true;
                    break;
                }
            }

            if (havebook==false) 
            { 
                Books.Add(book);
            }
            else
            {
                MessageBox.Show("This Book Already Have!!", "Exist Book", MessageBoxButtons.OK);
            }
        }



    }
}
