using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_delete_update
{
    public partial class Form1 : Form
    {
        private List<Students> students;
        private List<Groups> groups;
        public Form1()
        {
            InitializeComponent();
            students = new List<Students>();
            groups = new List<Groups>
            {
                new Groups{Group_name="P212"},
                new Groups{Group_name="P313"}
            };


        }


        private void Form1_Load(object sender, EventArgs e)
        {
                cmb_group.Items.AddRange(groups.ToArray());
            cmb_group.DropDownStyle = ComboBoxStyle.DropDownList;
            datagv.ColumnCount = 4;
            datagv.Columns[0].Name = "ID";
            datagv.Columns[1].Name = "Name";
            datagv.Columns[2].Name = "Surname";
            datagv.Columns[3].Name = "Group";
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
          Students student = null;
            string name = txt_name.Text.ToString();
            string Surname = txt_surname.Text.ToString();
           
            
            try
            {
                student = new Students
                {
                    Student_name = name,
                    Student_surname = Surname
                };
            
            }
            catch
            {
                MessageBox.Show("Please Fill Name and Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Groups selectgroup = cmb_group.SelectedItem as Groups;

            if (selectgroup == null)
            {
                MessageBox.Show("Please Select group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                student.Student_group = selectgroup.Group_name.ToString();
                student.Student_Group_id = Convert.ToInt32(selectgroup.group_id);
            }

            students.Add(student);
            FillGridView();



        }

        private void FillGridView()
        {
           // datagv.DataSource = students;

            datagv.Rows.Clear();
           
            foreach (var item in students)
            {
                datagv.Rows.Add(item.Student_id, item.Student_name, item.Student_surname, item.Student_group);
            }

        }

        private void menu_delete_Click(object sender, EventArgs e)
        {
            int selectindex = datagv.CurrentCell.RowIndex;
            //  MessageBox.Show(selecindex.ToString(), "Error", MessageBoxButtons.OK);

            int selectedrowindex = datagv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datagv.Rows[selectedrowindex];
            int cellValue = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            // MessageBox.Show(cellValue, "Error", MessageBoxButtons.OK);
            students.RemoveAll(x=>x.Student_id==cellValue);
            FillGridView();
        }

        private void menu_update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = datagv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datagv.Rows[selectedrowindex];
            int cellValue = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            Groups selectgroup = cmb_group.SelectedItem as Groups;
            foreach (var item in students)
            {
                if (item.Student_id == cellValue)
                {
                    item.Student_name = txt_name.Text.ToString();
                    item.Student_surname = txt_surname.Text.ToString();
                    item.Student_group = selectgroup.Group_name.ToString();
                    item.Student_Group_id = Convert.ToInt32(selectgroup.group_id);
                    break;
                }
            }
            FillGridView();
        }
    }
}
