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
    public partial class manager_page_cars : Form
    {
        public static manager_page_cars frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static manager_page_cars getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new manager_page_cars();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
            }

        }
        BL.CLS_CARS car_edit = new BL.CLS_CARS();

        public manager_page_cars()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView3.DataSource = car_edit.GET_CAR();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home manager_page_cars = new manager_home();
            manager_page_cars.Visible = true;
        }



        private void manager_page_cars_Load(object sender, EventArgs e)
        {

        }

        private void btneditcar_Click(object sender, EventArgs e)
        {
            manager_page_cars_editcar edit_car = new manager_page_cars_editcar();
            edit_car.ID_CAR.Text = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();
            edit_car.MODEL_NAME.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            edit_car.MODEL_YEAR.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
            edit_car.MILEAGE.Text = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
            edit_car.CAR_CATEGORY_NAME.Text = this.dataGridView3.CurrentRow.Cells[4].Value.ToString();
            edit_car.AVAILABILITY_FLAG.Text = this.dataGridView3.CurrentRow.Cells[5].Value.ToString();
            edit_car.ID_CAR.ReadOnly = true;
            edit_car.ShowDialog();
            edit_car.AVAILABILITY_FLAG.Focus();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = car_edit.search_CAR(searchbox.Text);
            this.dataGridView3.DataSource = dt;
        }

        private void btndeletecar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you ready want to Delete this manager?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                car_edit.Delete_CAR(this.dataGridView3.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("deleted successfully");
                this.dataGridView3.DataSource = car_edit.GET_CAR();
            }
            else
            {

                MessageBox.Show("take it easy,the manager still with us!");
            }
        }

        private void addcarbnt_Click(object sender, EventArgs e)
        {
            manager_page_cars_addcar add_car = new manager_page_cars_addcar();
            add_car.Visible = true;
            add_car.ID_CAR.Text = car_edit.GET_CAR_ID().Rows[0][0].ToString();
            add_car.AVAILABILITY_FLAG.Focus();
        }
    }
}
