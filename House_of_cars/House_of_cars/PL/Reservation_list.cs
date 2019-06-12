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
    public partial class Reservation_list : Form
    {
        BL.Cls_RESERVATION Reservation=new BL.Cls_RESERVATION();
        public Reservation_list()
        {
            InitializeComponent();
            this.dataGridReservation.DataSource = Reservation.GET_RESERVATION();
        }

        private void dataGridReservation_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
