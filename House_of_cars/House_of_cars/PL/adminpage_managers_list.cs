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
    public partial class adminpage_managers_list : Form
    {
        public static adminpage_managers_list frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static adminpage_managers_list getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new adminpage_managers_list();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
                }

        }
        BL.CLS_ADD_M edit = new BL.CLS_ADD_M();
        
        public adminpage_managers_list()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = edit.GET_MANAGER();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage admin_page_managers_list = new adminpage();
            admin_page_managers_list.Visible = true;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = edit.search_M(searchbox.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void Delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you ready want to Delete this manager?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                edit.Delet_M(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("deleted successfully");
                this.dataGridView1.DataSource = edit.GET_MANAGER();
            }
            else
            {

                MessageBox.Show("take it easy,the manager still with us!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminpage_managers_edit edit_manager = new adminpage_managers_edit();
            edit_manager.ID_eddit.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edit_manager.USERNAME.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edit_manager.PASSWORD.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edit_manager.FULLNAME.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edit_manager.usertype.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edit_manager.phone.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            edit_manager.email.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            edit_manager.ID_eddit.ReadOnly = true;
            edit_manager.ShowDialog();
            edit_manager.usertype.Focus();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            adminpage_managers_add admin_page_managers = new adminpage_managers_add();
            admin_page_managers.Visible = true;
            admin_page_managers.ID.Text = edit.GET_ADMIN_ID().Rows[0][0].ToString();
            admin_page_managers.usertype.Focus();

        }

        private void adminpage_managers_list_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
