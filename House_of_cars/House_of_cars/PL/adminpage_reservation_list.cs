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
    public partial class adminpage_reservation_list : Form
    {
        public static adminpage_reservation_list frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static adminpage_reservation_list getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new adminpage_reservation_list();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
            }

        }
        BL.Cls_RESERVATION edit = new BL.Cls_RESERVATION();
        public adminpage_reservation_list()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView4.DataSource = edit.GET_RESERVATION();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpage admin_page_reservation_list = new adminpage();
            admin_page_reservation_list.Visible = true;
        }

        private void adminpage_reservation_list_Load(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = edit.search_RESERVATION(search.Text);
            this.dataGridView4.DataSource = dt;
        }
    }
}
