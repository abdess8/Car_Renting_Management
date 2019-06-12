using House_of_cars.PL;
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
    public partial class manager_page_reservation_edit : Form
    {
        BL.Cls_RESERVATION resedit = new BL.Cls_RESERVATION();
        public manager_page_reservation_edit()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntreserve_Click(object sender, EventArgs e)
        {
            resedit.UPDATE_RESERVATION(int.Parse(ID_RESERVATION.Text), DATE_RESERVATION.Value, int.Parse(RENTAL_DAYS.Text),STATUS.Text, MODEL_NAME.Text, CIN_COSTUMER.Text);
            MessageBox.Show("Reservation Updated Successfully");
            manager_page_reservation.getMainForm.dataGridView4.DataSource = resedit.GET_RESERVATION();
        }

        private void manager_page_reservation_edit_Load(object sender, EventArgs e)
        {

        }

        private void BOOKING_STATUS_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }
    }
}
