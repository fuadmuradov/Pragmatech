using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualCard
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
            Manager.CreateRealCard("1111222233334444", 1000, "25/05/2022");
            Manager.CreateRealCard("2222333344445555", 1200, "25/12/2022");
            Manager.CreateRealCard("3333444455556666", 200, "10/03/2022");
        }

        Thread th;
        public void openform(object obj)
        {
            Application.Run(new Form2());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string number = txtnum.Text;
            string amount = txtamount.Text;
            string date = txtdate.Text;
           

            if(number=="" || amount == "" || date == "")
            {
                MessageBox.Show("Fill all Textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           // DateTime dat = Convert.ToDateTime(date);

            if (Convert.ToDateTime(date) < Convert.ToDateTime(DateTime.Now))
            {
                MessageBox.Show("This Card not Useful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Manager.CreateRealCard(number, int.Parse(amount), date);
            MessageBox.Show("Real Card Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            th = new Thread(openform);
            th.Start();
        }
    }
}
