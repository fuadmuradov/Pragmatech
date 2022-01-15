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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            string constring = ConfigurationManager.ConnectionStrings["rgstrform"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(constring))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Student", sqlConnection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }
    }
}
