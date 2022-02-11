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

namespace GuessWhat
{
    public partial class Form2 : Form
    {
        int aa, bb, cc, dd;

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform);
            th.Start();
        }

        Thread th;
        public void openform(object obj)
        {
            Application.Run(new Form1());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<string> words = new List<string>();
        public Form2(List<string> _words, int a, int b, int c, int d)
        {
            InitializeComponent();
            words = _words;
            this.aa = a;
            this.bb = b;
            this.cc = c;
            this.dd = d;
        }
   
        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Text = aa.ToString();
            label7.Text = bb.ToString();
            label8.Text = cc.ToString();
            label9.Text = dd.ToString();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = words;
            cmbword.DataSource = bindingSource1;
        }
    }
}
