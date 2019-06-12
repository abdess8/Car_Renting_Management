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
    public partial class manager_page_reservation_add : Form
    {
        BL.Cls_RESERVATION resadd = new BL.Cls_RESERVATION();
        public manager_page_reservation_add()
        {
            InitializeComponent();
        }

        private void manager_page_reservation_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void bntreserve_Click(object sender, EventArgs e)
        {
            resadd.ADD_RESERVATION(int.Parse(ID_RESERVATION.Text), DATE_RESERVATION.Value, int.Parse(RENTAL_DAYS.Text), STATUS.Text, MODEL_NAME.Text, CIN_COSTUMER.Text);
            MessageBox.Show("Reservation Successfully Added!");
            manager_page_reservation.getMainForm.dataGridView4.DataSource = resadd.GET_RESERVATION();
        }

        private void MODEl_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_RESERVATION_VERIFY(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = resadd.VERIFY_ID_RESERVATION(ID_RESERVATION.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This ID Already Exist in the Database!");
                ID_RESERVATION.Focus();
                ID_RESERVATION.SelectionStart = 0;
                ID_RESERVATION.SelectionLength = ID_RESERVATION.TextLength;
            }
        }
    }
}
