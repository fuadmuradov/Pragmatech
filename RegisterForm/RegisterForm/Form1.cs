using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //string conString = ConfigurationManager.ConnectionStrings["rgstrform"].ConnectionString;
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand = null;
            //SqlDataReader sqlDataReader = null;

            //try
            //{
            //    sqlConnection = new SqlConnection(conString);
            //    sqlConnection.Open();
            //    String command 
            //}
            //catch
            //{

            //}

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            string conString = ConfigurationManager.ConnectionStrings["rgstrform"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlCommand sqlCommand = null;

            if (txtName.Text!="" && txtSurname.Text!="" && txtMail.Text!="" && txtDate.Text!="")
            {
                string name = txtName.Text;
                string Surname = txtSurname.Text;
                string mail = txtMail.Text;
                string graduate = txtDate.Text;

                sqlCommand = new SqlCommand("Insert into Student values('" + @name + "', '" + @Surname + "', '" + @mail + "', '" + @graduate + "');", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                clearText();
            }
            else
            {
                MessageBox.Show("Fill All Textbox!!!", "Warning", MessageBoxButtons.OK);
            }


            
        }

       private void clearText()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            txtDate.Clear();
        }

        private void allStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Form1 form1 = new Form1();
            form1.Close();
        }
    }
}
