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
    public partial class adminpage_managers : Form
    {
        public adminpage_managers()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Adminpage admin_page_managers = new Adminpage();
            admin_page_managers.Visible = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_add admin_page_managers = new adminpage_managers_add();
            admin_page_managers.Visible = true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_edit admin_page_managers = new adminpage_managers_edit();
            admin_page_managers.Visible = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_delete admin_page_managers = new adminpage_managers_delete();
            admin_page_managers.Visible = true;
        }

        private void client_list_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_list admin_page_managers = new adminpage_managers_list();
            admin_page_managers.Visible = true;
        }
    }
}
