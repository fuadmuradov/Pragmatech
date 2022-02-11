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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            Thread th;
        public void openform(object obj)
        {
            Application.Run(new Form1());
        }

        public void openDeleteform(object obj)
        {
            Application.Run(new Delete());
        }
        private void addRealCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform);
            th.Start();

        }

        private void deleteVirtualCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openDeleteform);
            th.Start();
        }

        private void clear()
        {
            txtnum.Text = "";
            txtamount.Text = "";
            txtdate.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = txtnum.Text;
            int amount = Convert.ToInt32(txtamount.Text);
            int day = Convert.ToInt32(txtdate.Text);


            if (Manager.CheckRealCard(number, amount, day))
            {
                Manager.CreateVirtualCard(number, amount, day);
                MessageBox.Show("Virtual card Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                return;
            }


        }

       
    }
}
