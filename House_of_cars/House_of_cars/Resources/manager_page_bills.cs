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
    public partial class manager_page_bills : Form
    {
        public manager_page_bills()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Adminpage_Load(object sender, EventArgs e)
        {

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Deconnect_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home manager_page_bills = new manager_home();
            manager_page_bills.Visible = true;
        }

        private void btnnewbill_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_bills_newbill manager_page_bills = new manager_page_bills_newbill();
            manager_page_bills.Visible = true;
        }
    }
}
