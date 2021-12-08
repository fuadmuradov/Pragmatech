using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_and_Library
{
    class Library
    {
       public List<Book> Books;
        public Library()
        {
            this.Books = new List<Book>();

        }

        public List<Book> FinsAllBoksByName(string name)
        {
            name = name.ToLower().Trim();
            List<Book> list = new List<Book>();
            foreach (Book item in Books)
            {
                if (item.name.ToLower().Trim() == name) list.Add(item);
                else continue;
            }

            return list;
        }

        public void RemoveAllBoksByName(string names)
        {
           string name = names.ToLower().Trim();

         Books.RemoveAll(x => x.name.ToLower().Trim() == name);

            //foreach (Book item in Books)
            //{
            //    if (item.name.ToLower().Trim() == name) Books.Remove(item);
            //    else continue;
            //}

           
        }

        public List<Book> SearchBooks(string name)
        {
            name = name.ToLower().Trim();
            List<Book> list = new List<Book>();
            foreach (Book item in Books)
            {
                if (item.name.ToLower().Trim() == name || item.AuthorName.ToLower().Trim() == name || item.PageCount.ToString().ToLower().Trim() == name) list.Add(item);
                else continue;
            }

            return list;
        }


        public List<Book> FindBooksByPageCountRange(int min, int max)
        {
           
            List<Book> list = new List<Book>();
            foreach (Book item in Books)
            {
                if (item.PageCount >= min && item.PageCount <= max) list.Add(item);
            }

            return list;
        }

        public void RemoveByNo(string str)
        {

            
            foreach (Book item in Books)
            {
                if (item.code == str) Books.Remove(item);
            }

            
        }
    }
}
