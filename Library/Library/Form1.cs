using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        List<Book> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            Book.Janr book1 = new Book.Janr();
            

            if (  CmbBoxJanr.SelectedItem.ToString()=="Dedektiv") book1 = Book.Janr.Dedektiv;

            else
                if (CmbBoxJanr.SelectedItem.ToString() == "Psixoloji") book1 = Book.Janr.Psixoloji;
            else
                if (CmbBoxJanr.SelectedItem.ToString() == "Siyasi") book1 = Book.Janr.Siyasi;
            else
                if (CmbBoxJanr.SelectedItem.ToString() == "Romantik") book1 = Book.Janr.Romantik;
          else
                if (CmbBoxJanr.SelectedItem.ToString() == "Fantastik") book1 = Book.Janr.Fantastik;

            Book book = new Book(txtname.Text.ToString(),Convert.ToInt32(txtisbn.Text), Convert.ToInt32(txtprice.Text), book1);

            Library_Management library = new Library_Management();
            library.AddBooks(book);

            list = Library_Management.Books;
            checkedListBox1.Items.Clear();
            foreach (Book item in list)
            {
                checkedListBox1.Items.Add(item.BookName + " " + item.ISBN + " " + item.Price + " " + item.BookJanr);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in list)
            {
                if (item.BookJanr.ToString() == CmbBoxJanr.SelectedItem.ToString())
                {
                    checkedListBox1.Items.Add(item.BookName + " " + item.ISBN + " " + item.Price + " " + item.BookJanr);
                }
            }
        }
    }
}
