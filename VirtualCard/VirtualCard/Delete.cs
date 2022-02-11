using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualCard
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string realcard = txtrealcard.Text;
            if(realcard == "")
            {
                MessageBox.Show("Fill Realcard Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> list = new List<string>();
            if (Manager.SearchRealCard(realcard))
            {
               list = Manager.VirtualCardList(realcard);
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = list;
                cmbVcard.DataSource = bindingSource1;
                
            }
            else
            {
                MessageBox.Show("This Real Card Not Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string virtualcard = txtvirtualcard.Text;
            if (virtualcard == "")
            {
                MessageBox.Show("write Virtual Card Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Manager.DeleteVirtualCard(virtualcard);
            MessageBox.Show("Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
