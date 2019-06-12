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
    public partial class adminpage_managers_delete : Form
    {
        public adminpage_managers_delete()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_list admin_page_managers_delete = new adminpage_managers_list();
            admin_page_managers_delete.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void adminpage_managers_delete_Load(object sender, EventArgs e)
        {

        }
    }
}
