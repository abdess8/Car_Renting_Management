using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using House_of_cars;


namespace House_of_cars.PL
{
    public partial class Customer_bills_list : Form
    {
        BL.CLS_ADD_CLIENT customers = new BL.CLS_ADD_CLIENT();
        public Customer_bills_list()
        {
            InitializeComponent();
            this.dataGridcustomer.DataSource = customers.GET_CLIENT();
        }

        private void dataGridcustomer_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
