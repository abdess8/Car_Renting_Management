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
    public partial class manager_page_bills_edit : Form
    {
        BL.Cls_bills cltedit = new BL.Cls_bills();
        public manager_page_bills_edit()
        {
            InitializeComponent();
        }

        private void btnsavebill_Click(object sender, EventArgs e)
        {
            cltedit.UPDATE_BILLS(int.Parse(BILL_ID.Text), BILL_DATE.Value, BILL_STATUS.Text, int.Parse(TOTAL_AMOUNT.Text), int.Parse(ID_RESERVATION.Text));
            MessageBox.Show("Bill Updated Successfully");
            manager_page_bill.getMainForm.dataGridView5.DataSource = cltedit.GET_BILLS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_page_bills_edit_Load(object sender, EventArgs e)
        {

        }

        private void BILL_ID_Validated(object sender, EventArgs e)
        {
            
            
        }
    }
}
