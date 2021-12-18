using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_with_picture
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFD1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if(openFD1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFD1.FileName);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = "";
            string surname = "";
            string email = "";
            string picture = "";
            if(txtname.Text != "" && txtsurname.Text != "" && txtemail.Text != "")
            {
                name = txtname.Text;
                surname = txtsurname.Text;
                email = txtemail.Text;
                picture = openFD1.FileName;
                Student student = new Student(name, surname, email, picture);
               
                students.Add(student);
                ClearTXT();
            }
            else
            {
                MessageBox.Show("Plesae Fill All textBox and load Picture", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ClearTXT()
        {
            txtname.Text = "";
            txtsurname.Text = "";
            txtemail.Text = "";
            pictureBox1.Image = null;
        }
        private void sudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList(students);
            studentList.ShowDialog();
            this.Close();
        }
    }
}
