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
    public partial class manager_page_reservation : Form
    {
        public static manager_page_reservation frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static manager_page_reservation getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new manager_page_reservation();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
            }

        }
        BL.Cls_RESERVATION edit = new BL.Cls_RESERVATION();
        public manager_page_reservation()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView4.DataSource = edit.GET_RESERVATION();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            manager_page_reservation_edit edit_res = new manager_page_reservation_edit();
            edit_res.ID_RESERVATION.Text = this.dataGridView4.CurrentRow.Cells[0].Value.ToString();
            edit_res.DATE_RESERVATION.Text = this.dataGridView4.CurrentRow.Cells[1].Value.ToString();
            edit_res.RENTAL_DAYS.Text = this.dataGridView4.CurrentRow.Cells[2].Value.ToString();
            edit_res.STATUS.Text = this.dataGridView4.CurrentRow.Cells[3].Value.ToString();
            edit_res.MODEL_NAME.Text = this.dataGridView4.CurrentRow.Cells[4].Value.ToString();
            edit_res.CIN_COSTUMER.Text = this.dataGridView4.CurrentRow.Cells[5].Value.ToString();
            edit_res.ID_RESERVATION.ReadOnly = true;
            edit_res.ShowDialog();
            edit_res.STATUS.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            manager_page_reservation_add manager_page_reservation = new manager_page_reservation_add();
            manager_page_reservation.Visible = true;
            manager_page_reservation.ID_RESERVATION.Text = edit.GET_RESERVATION_ID().Rows[0][0].ToString();
            manager_page_reservation.STATUS.Focus();

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home manager_page_reservation = new manager_home();
            manager_page_reservation.Visible = true;
        }

        private void manager_page_reservation_Load(object sender, EventArgs e)
        {

        }

        private void bntdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you ready want to Delete this Reservation?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                edit.Delet_RESERVATION(this.dataGridView4.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully");
                this.dataGridView4.DataSource = edit.GET_RESERVATION();
            }
            else
            {

                MessageBox.Show("Take it easy!");
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = edit.search_RESERVATION(search.Text);
            this.dataGridView4.DataSource = dt;
        }
    }
}
