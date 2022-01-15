using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly ParfumsEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new ParfumsEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb1.DataSource = db.Brands.Select(x => x.Name).ToList();
            // dataGridView1.DataSource = db.Parfums.ToList();
            dataGridView1.DataSource = db.Parfums.Select(x => x.Name).ToList();
            //cmb1.DataSource = db.ParfumInfoes.Select(x => x.Name).ToList();
                //  cmb1.DataSource = db.Parfums.Select(x => x.Name).ToList();
           // List<string> parfums = db.Parfums.Select(x => x.Name).ToList();
           // cmb1.DataSource = parfums;
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brandname = cmb1.Text;

            if (!string.IsNullOrEmpty(brandname))
            {
                Brand brandresult = db.Brands.FirstOrDefault(x => x.Name == brandname);
                if (brandresult.Parfums.Count == 0)
                {
                    MessageBox.Show("brand adinda parfum yoxdur");
                }
                else
                {
                    cmb2.DataSource = brandresult.Parfums.Select(x => x.Name).ToList();
                }
            }
        }
    }
}
