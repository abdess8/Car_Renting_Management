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
    public partial class manager_page_bill : Form
    {
        BL.Cls_bills billedit = new BL.Cls_bills();
        public static manager_page_bill frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static manager_page_bill getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new manager_page_bill();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);

                }
                return frm;
            }

        }
        public manager_page_bill()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView5.DataSource = billedit.GET_BILLS();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            manager_page_bills_edit edit_bills = new manager_page_bills_edit();
            edit_bills.BILL_ID.Text = this.dataGridView5.CurrentRow.Cells[0].Value.ToString();
            edit_bills.BILL_DATE.Text = this.dataGridView5.CurrentRow.Cells[1].Value.ToString();
            edit_bills.BILL_STATUS.Text = this.dataGridView5.CurrentRow.Cells[2].Value.ToString();
            edit_bills.TOTAL_AMOUNT.Text = this.dataGridView5.CurrentRow.Cells[3].Value.ToString();
            edit_bills.ID_RESERVATION.Text = this.dataGridView5.CurrentRow.Cells[4].Value.ToString();
            edit_bills.BILL_ID.ReadOnly = true;
            edit_bills.ShowDialog();
            edit_bills.BILL_DATE.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            manager_page_bills_newbill manager_page_bill = new manager_page_bills_newbill();
            manager_page_bill.Visible = true;
            manager_page_bill.BILL_ID.Text = billedit.GET_BILL_ID().Rows[0][0].ToString();
            manager_page_bill.BILL_DATE.Focus();
        }

        private void bntdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you ready want to Delete this Reservation?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                billedit.DELETE_BILLS(this.dataGridView5.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully");
                this.dataGridView5.DataSource = billedit.GET_BILLS();
            }
            else
            {

                MessageBox.Show("Take it easy!");
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home manager_page_bill = new manager_home();
            manager_page_bill.Visible = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = billedit.SEARCH_BILLS(search.Text);
            this.dataGridView5.DataSource = dt;
        }
    }
}
