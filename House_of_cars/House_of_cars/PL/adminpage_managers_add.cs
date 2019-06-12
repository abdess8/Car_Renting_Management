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
    public partial class adminpage_managers_add : Form
    {
        BL.CLS_ADD_M mngadd = new BL.CLS_ADD_M();
        public adminpage_managers_add()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Error_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DRIVER_LICENSE_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mngadd.ADD_M(int.Parse(ID.Text), USERNAME.Text, PASSWORD.Text, FULLNAME.Text,usertype.Text, int.Parse(phone.Text), email.Text);
            MessageBox.Show("Manager Added Successfully!");
            adminpage_managers_list.getMainForm.dataGridView1.DataSource = mngadd.GET_MANAGER();
        }

        private void fjofhdf_Click(object sender, EventArgs e)
        {

        }

        private void cin2_Click(object sender, EventArgs e)
        {

        }

        private void city2_Click(object sender, EventArgs e)
        {

        }

        private void labelfg_Click(object sender, EventArgs e)
        {

        }

        private void adresse2_Click(object sender, EventArgs e)
        {

        }

        private void lastname2_Click(object sender, EventArgs e)
        {

        }

        private void name2_Click(object sender, EventArgs e)
        {

        }

        private void CIN_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void CITY_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void PHONE_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void STREET_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNAME_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNAME_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_MANAGER_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_M_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mngadd.VERIFY_ID(ID.Text);
            if(dt.Rows.Count>0)
            {
            MessageBox.Show("This ID already Exist!");
            ID.Focus();
            ID.SelectionStart = 0;
            ID.SelectionLength = ID.TextLength;
            }

        }

        private void adminpage_managers_add_Load(object sender, EventArgs e)
        {

        }
    }
}
