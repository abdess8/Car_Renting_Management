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
    public partial class manager_page_client_delete : Form
    {
        public manager_page_client_delete()
        {
            InitializeComponent();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_client admin_page_clients_delete = new manager_page_client();
            admin_page_clients_delete.Visible = true;
        }
    }
}
