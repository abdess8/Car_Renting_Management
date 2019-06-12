using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace House_of_cars.PL
{
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void managers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_managers_list Adminpage = new adminpage_managers_list();
            Adminpage.Visible = true;
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage_reservation_list Adminpage = new adminpage_reservation_list();
            Adminpage.Visible = true;
        }

        private void Deconnect_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login Adminpage = new login();
            Adminpage.Visible = true;
        }

        private void Adminpage_Load(object sender, EventArgs e)
        {

        }
    }
}
