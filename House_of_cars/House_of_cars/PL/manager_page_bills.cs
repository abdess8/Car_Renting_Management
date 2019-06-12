using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace House_of_cars
{
    public partial class manager_page_bills : Form
    {
        BL.Cls_bills Newbill = new BL.Cls_bills();
        BL.CLS_ADD_CLIENT CLIENT = new BL.CLS_ADD_CLIENT();
        DataTable dt = new DataTable();

        void CalculateAmount()
        {
            if (AMOUNT.Text != string.Empty)
            { 
            
            TOTAL_AMOUNT.Text=(Convert.ToDouble(AMOUNT.Text) * Convert.ToDouble(RENTAL_DAYS.Text)+" DH").ToString();

            }
        
        }
   

        void CreateDatatable()
        {
            dt.Columns.Add("Reservation ID");
            dt.Columns.Add("Amount(DH)");
            dt.Columns.Add("Date of Reservation");
            dt.Columns.Add("Model car Name");
            dt.Columns.Add("Rental days");
            
            dataGridReservation.DataSource = dt;
            IMPORT.Focus();

        }

        void Resizedgv()
        {
            this.dataGridReservation.RowHeadersWidth = 121;
            this.dataGridReservation.Columns[0].Width = 144;
            this.dataGridReservation.Columns[1].Width = 114;
            this.dataGridReservation.Columns[2].Width = 204;
            this.dataGridReservation.Columns[3].Width = 230;
            this.dataGridReservation.Columns[4].Width = 146;
            
        }
        void ClearData()
        {

            ID_RESERVATION.Clear();
            AMOUNT.Clear();
            DATE_RESERVATION.Clear();
            MODEL_NAME.Clear();
            RENTAL_DAYS.Clear();
        }

        public manager_page_bills()
        {
            InitializeComponent();
            CreateDatatable();
            Resizedgv();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Adminpage_Load(object sender, EventArgs e)
        {

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Deconnect_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_home manager_page_bills = new manager_home();
            manager_page_bills.Visible = true;
        }

        private void btnnewbill_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager_page_bills_newbill manager_page_bills = new manager_page_bills_newbill();
            manager_page_bills.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PL.Customer_bills_list frm = new PL.Customer_bills_list();
            frm.ShowDialog();
            this.ID_CLIENT.Text = frm.dataGridcustomer.CurrentRow.Cells[0].Value.ToString();
            this.CIN.Text = frm.dataGridcustomer.CurrentRow.Cells[1].Value.ToString();
            this.FNAME.Text = frm.dataGridcustomer.CurrentRow.Cells[2].Value.ToString();
            this.DRIVER_LICENSE.Text = frm.dataGridcustomer.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
            PL.Reservation_list frm = new PL.Reservation_list();
            frm.ShowDialog();
            this.ID_RESERVATION.Text = frm.dataGridReservation.CurrentRow.Cells[0].Value.ToString();
            this.DATE_RESERVATION .Text = frm.dataGridReservation.CurrentRow.Cells[1].Value.ToString();
            this.MODEL_NAME.Text = frm.dataGridReservation.CurrentRow.Cells[4].Value.ToString();
            this.RENTAL_DAYS.Text = frm.dataGridReservation.CurrentRow.Cells[2].Value.ToString();
            AMOUNT.Focus();


        }

        private void dataGridReservation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ID_RESERVATION.Text = this.dataGridReservation.CurrentRow.Cells[0].Value.ToString();
                AMOUNT.Text = this.dataGridReservation.CurrentRow.Cells[1].Value.ToString();
                DATE_RESERVATION.Text = this.dataGridReservation.CurrentRow.Cells[2].Value.ToString();
                MODEL_NAME.Text = this.dataGridReservation.CurrentRow.Cells[3].Value.ToString();
                RENTAL_DAYS.Text = this.dataGridReservation.CurrentRow.Cells[4].Value.ToString();
                dataGridReservation.Rows.RemoveAt(dataGridReservation.CurrentRow.Index);
                AMOUNT.Focus();

            }
            catch
            {
                return;

            }
        }

        private void DRIVER_LICENSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AMOUNT_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TOTAL_AMOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void AMOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void RENTAL_DAYS_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void RENTAL_DAYS_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMOUNT_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridReservation.Rows.Count - 1; i++)
                {
                    if (dataGridReservation.Rows[i].Cells[0].Value.ToString() == ID_RESERVATION.Text)
                    {
                        MessageBox.Show("This Reservation ID Was Already Added ");
                        return;
                    }
                }

                DataRow r = dt.NewRow();
                r[0] = ID_RESERVATION.Text;
                r[1] = AMOUNT.Text;
                r[2] = DATE_RESERVATION.Text;
                r[3] = MODEL_NAME.Text;
                r[4] = RENTAL_DAYS.Text;
                dt.Rows.Add(r);
                dataGridReservation.DataSource = dt;
                ClearData();
                TOTAL_AMOUNT.Text = (from DataGridViewRow row in dataGridReservation.Rows
                              where row.Cells[1].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum() + " DH".ToString();

            }
        }

        private void dataGridReservation_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TOTAL_AMOUNT.Text = (from DataGridViewRow row in dataGridReservation.Rows
                          where row.Cells[1].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum() + " DH".ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridReservation_DoubleClick(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridReservation.Refresh();
        }

        private void bntsave_Click(object sender, EventArgs e)
        {
            

        }

        private void importbtn_Click(object sender, EventArgs e)
        {
            PL.Billing_List frm = new PL.Billing_List();
            frm.ShowDialog();
            this.BILL_ID.Text = frm.dataGridBills.CurrentRow.Cells[0].Value.ToString();
            this.BILL_DATE.Text = frm.dataGridBills.CurrentRow.Cells[1].Value.ToString();
            this.STATUS.Text = frm.dataGridBills.CurrentRow.Cells[2].Value.ToString();
        }

        private void BILL_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMOUNT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            CalculateAmount();

        }

        private void TOTAL_AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMOUNT_KeyUp_1(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }
    }
}
