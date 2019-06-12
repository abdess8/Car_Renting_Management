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
    public partial class manager_page_bills_newbill : Form
    {
        BL.Cls_bills cltadd = new BL.Cls_bills();
        public manager_page_bills_newbill()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_page_bills_newbill_Load(object sender, EventArgs e)
        {

        }

        private void btnsavebill_Click(object sender, EventArgs e)
        {
            cltadd.ADD_BILL(int.Parse(BILL_ID.Text), BILL_DATE.Value, BILL_STATUS.Text, int.Parse(TOTAL_AMOUNT.Text), int.Parse(ID_RESERVATION.Text));
            MessageBox.Show("Bill Successfully Added!");
            manager_page_bill.getMainForm.dataGridView5.DataSource = cltadd.GET_BILLS();
        }

        private void BILL_ID_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cltadd.VERIFY_ID_BILLS(BILL_ID.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This ID Already Exist!");
                BILL_ID.Focus();
                BILL_ID.SelectionStart = 0;
                BILL_ID.SelectionLength = BILL_ID.TextLength;
            }
        }
    }
}
