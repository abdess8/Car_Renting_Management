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
    public partial class manager_page_client_edit : Form
    {
        BL.CLS_ADD_CLIENT cltedit = new BL.CLS_ADD_CLIENT();
        public manager_page_client_edit()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            cltedit.UPDATE_CLIENT(int.Parse(ID_CUSTOMER.Text), CIN.Text, FNAME.Text, LNAME.Text, int.Parse(PHONE_NUMBER.Text), DRIVER_LICENSE.Text);
            MessageBox.Show("Client Updated successfully");
            adminpage_managers_list.getMainForm.dataGridView1.DataSource = cltedit.GET_CLIENT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_page_client_edit_Load(object sender, EventArgs e)
        {

        }
    }
}
