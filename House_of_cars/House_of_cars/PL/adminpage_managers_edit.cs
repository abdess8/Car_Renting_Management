using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_of_cars
{
    public partial class adminpage_managers_edit : Form
    {
      
        BL.CLS_ADD_M mngaedit = new BL.CLS_ADD_M();
        public adminpage_managers_edit()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           mngaedit.update_manager (int.Parse(ID_eddit.Text), USERNAME.Text, PASSWORD.Text, FULLNAME.Text, usertype.Text, int.Parse(phone.Text), email.Text);
            MessageBox.Show("Manager Updated Successfully!");
            adminpage_managers_list.getMainForm.dataGridView1.DataSource = mngaedit.GET_MANAGER();
            
        }

        private void adminpage_managers_edit_Load(object sender, EventArgs e)
        {

        }

        private void ID_eddit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
