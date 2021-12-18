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
    public partial class StudentList : Form
    {
        private List<Student> Students;
        public static StudentList instance;
        public StudentList(List<Student> students)
        {
            InitializeComponent();
           this.Students = students;
            listBox1.Items.AddRange(students.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string name = txtsearch.Text;
            foreach (Student item in Students)
            {
                if (item.Name.ToString() == name)
                {
                    txtname.Text = item.Name;
                    txtsurname.Text = item.Surname;
                    txtemail.Text = item.Email;
                    pictureBox1.Image = Image.FromFile(item.Picture);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            int index = listBox1.SelectedIndex;
            foreach (Student item in Students)
            {
                if(item.std_ID == index)
                {
                    txtname.Text = item.Name;
                    txtsurname.Text = item.Surname;
                    txtemail.Text = item.Email;
                    pictureBox1.Image = Image.FromFile(item.Picture);
                }
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form1 f = new Form1())
            {
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
