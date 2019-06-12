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
    public partial class Billing_List : Form
    {
        BL.Cls_bills Reservation = new BL.Cls_bills();

        public Billing_List()
        {
            InitializeComponent();
            this.dataGridBills.DataSource = Reservation.GET_BILLS();

        }

        private void dataGridBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBills_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
