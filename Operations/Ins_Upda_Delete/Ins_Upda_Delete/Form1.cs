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

namespace Ins_Upda_Delete
{
    public partial class Form1 : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["rgstrform"].ConnectionString;
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataReader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoll.Text = "";
            txtCourse.Text = "";
            TxtName.Text = "";
            txtAge.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            SqlConnection sqlConnection = new SqlConnection(constring);
           

            if (txtRoll.Text != "" && txtCourse.Text != "" && TxtName.Text != "" && txtAge.Text != "")
            {
                string name = TxtName.Text;
                int roll = Convert.ToInt32(txtRoll.Text);
                string Course = txtCourse.Text;
                int Age = Convert.ToInt32(txtAge.Text);

                sqlCommand = new SqlCommand("Insert into Student2 values(" + roll + ", '" + name + "', " + Age + ", '" + Course + "');", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

               
            }
            else
            {
                MessageBox.Show("Fill All Textbox!!!", "Warning", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRoll.Text != "") {

                int roll = Convert.ToInt32(txtRoll.Text);
                sqlConnection = new SqlConnection(constring);
                using (sqlCommand = new SqlCommand("Delete from Student2 where roll = " + roll + ";", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Roll Number", "Warning", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRoll.Text != "")
            {

                int roll = Convert.ToInt32(txtRoll.Text);
                sqlConnection = new SqlConnection(constring);
                using (sqlCommand = new SqlCommand("Select * from Student2 where roll = " + roll + ";", sqlConnection))
                {
                    sqlConnection.Open();
                   sqlDataReader =  sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        TxtName.Text = sqlDataReader[1].ToString();
                    }
                    

                    sqlConnection.Close();
                    

                }
            }
            else
            {
                MessageBox.Show("Fill Roll Number", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRoll.Text != "")
            {

                int roll = Convert.ToInt32(txtRoll.Text);
                sqlConnection = new SqlConnection(constring);
                using (sqlCommand = new SqlCommand("Update Student2 set name = '" + TxtName.Text +"' " + "where roll = " + roll + ";", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Roll Number", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
