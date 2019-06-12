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
    public partial class manager_page_cars_editcar : Form
    {
        BL.CLS_CARS car_edit = new BL.CLS_CARS();
        public manager_page_cars_editcar()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            car_edit.UPDATE_CAR(int.Parse(ID_CAR.Text), char.Parse(AVAILABILITY_FLAG.Text), MODEL_NAME.Text, int.Parse(MODEL_YEAR.Text), int.Parse(MILEAGE.Text), CAR_CATEGORY_NAME.Text); ;
            MessageBox.Show("Car Updated Successfully!");
            manager_page_cars.getMainForm.dataGridView3.DataSource = car_edit.GET_CAR();
        }

        private void MODEL_YEAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void manager_page_cars_editcar_Load(object sender, EventArgs e)
        {

        }

        private void ID_CAR_VERIFY(object sender, EventArgs e)
        {
        
        }
    }
}
