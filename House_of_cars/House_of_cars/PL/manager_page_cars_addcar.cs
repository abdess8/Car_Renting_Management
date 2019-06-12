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
    public partial class manager_page_cars_addcar : Form
    {
        BL.CLS_CARS add_car = new BL.CLS_CARS();
        public manager_page_cars_addcar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_page_cars_addcar_Load(object sender, EventArgs e)
        {
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_car.ADD_CAR(int.Parse(ID_CAR.Text), char.Parse(AVAILABILITY_FLAG.Text), MODEL_NAME.Text, int.Parse(MODEL_YEAR.Text), int.Parse(MILEAGE.Text), CAR_CATEGORY_NAME.Text);
            MessageBox.Show("Car Added Successfully");
            manager_page_cars.getMainForm.dataGridView3.DataSource = add_car.GET_CAR();
        }

        private void ID_CAR_VERIFY(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = add_car.VERIFY_ID_car(ID_CAR.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This ID Already Exist!");
                ID_CAR.Focus();
                ID_CAR.SelectionStart = 0;
                ID_CAR.SelectionLength = ID_CAR.TextLength;
            }
        }
    }
}
