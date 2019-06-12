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
    public partial class manager_page_client_add : Form
    {
        BL.CLS_ADD_CLIENT cltadd = new BL.CLS_ADD_CLIENT();
        public manager_page_client_add()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            cltadd.ADD_CLIENT(int.Parse(ID_CUSTOMER.Text), CIN.Text, FNAME.Text, LNAME.Text, int.Parse(PHONE_NUMBER.Text), DRIVER_LICENSE.Text);
            MessageBox.Show("Client Added Successfully!");
            manager_page_client.getMainForm.dataGridView2.DataSource = cltadd.GET_CLIENT();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_page_clients_add_Load(object sender, EventArgs e)
        {

        }

        private void Error_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DRIVER_LICENSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void CITY_TextChanged(object sender, EventArgs e)
        {

        }

        private void PHONE_NUMBER_TextChanged(object sender, EventArgs e)
        {

        }

        private void STREET_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_CUSTOMER_TextChanged(object sender, EventArgs e)
        {

        }
        private void ID_CUSTOMER_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cltadd.VERIFY_ID_CLIENT(ID_CUSTOMER.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("this Id existed in the database ,enter an other one!!!");
                ID_CUSTOMER.Focus();
                ID_CUSTOMER.SelectionStart = 0;
                ID_CUSTOMER.SelectionLength = ID_CUSTOMER.TextLength;
            }

        }

        private void ID_CUSTOMER_VERIFY(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cltadd.VERIFY_ID_CLIENT(ID_CUSTOMER.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("this Id existed in the database ,enter an other one!!!");
                ID_CUSTOMER.Focus();
                ID_CUSTOMER.SelectionStart = 0;
                ID_CUSTOMER.SelectionLength = ID_CUSTOMER.TextLength;
            }
        }
    }

        
    
}
