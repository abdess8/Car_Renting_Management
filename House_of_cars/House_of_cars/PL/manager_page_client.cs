using House_of_cars.PL;
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
    public partial class manager_page_client : Form
    {
        public static manager_page_client frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static manager_page_client getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new manager_page_client();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
            }

        }
        BL.CLS_ADD_CLIENT edit = new BL.CLS_ADD_CLIENT();
        public manager_page_client()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView2.DataSource = edit.GET_CLIENT();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home admin_page_clients = new manager_home();
            admin_page_clients.Visible = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            manager_page_client_add manager_page_client = new manager_page_client_add();
            manager_page_client.Visible = true;
            manager_page_client.ID_CUSTOMER.Text = edit.GET_CUSTOMER_ID().Rows[0][0].ToString();
            manager_page_client.CIN.Focus();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            manager_page_client_edit edit_client = new manager_page_client_edit();
            edit_client.ID_CUSTOMER.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            edit_client.CIN.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            edit_client.FNAME.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            edit_client.LNAME.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            edit_client.PHONE_NUMBER.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            edit_client.DRIVER_LICENSE.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            edit_client.ID_CUSTOMER.ReadOnly = true;
            edit_client.ShowDialog();
            edit_client.CIN.Focus();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you ready want to Delete this manager?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                edit.DELETE_CLIENT(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully");
                this.dataGridView2.DataSource = edit.GET_CLIENT();
            }
            else
            {

                MessageBox.Show("Take it easy! The Manager Still With Us!");
            }
        }

        private void manager_page_clients_Load(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = edit.SEARCH_CLIENT(searchbox.Text);
            this.dataGridView2.DataSource = dt;
        }
    }
}
