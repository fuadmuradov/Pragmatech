using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_and_Library
{
    class Book
    {
        public string code;
        public string name;
        public string AuthorName;
        public int PageCount;
        public static int No=1;

        public Book(string name, string authorname, int pagecount)
        {
            this.name = name;
            this.AuthorName = authorname;
            this.PageCount = pagecount;
            code = name.Substring(0, 2) + No.ToString();
            No++;
        }
    }
}
