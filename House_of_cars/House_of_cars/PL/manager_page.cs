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
    public partial class manager_home : Form
    {
        public manager_home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clients_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_client manager_home = new manager_page_client();
            manager_home.Visible = true;
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_reservation manager_home = new manager_page_reservation();
            manager_home.Visible = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login manager_home = new login();
            manager_home.Visible = true;
        }

        private void cars_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_cars manager_home = new manager_page_cars();
            manager_home.Visible = true;
        }

        private void bills_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_bills manager_home = new manager_page_bills();
            manager_home.Visible = true;
        }

        private void manager_home_Load(object sender, EventArgs e)
        {

        }

        private void BILLS_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_bill manager_home = new manager_page_bill();
            manager_home.Visible = true;
        }
    }
}
