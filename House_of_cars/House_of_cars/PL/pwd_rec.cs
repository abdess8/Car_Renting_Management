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
    public partial class pwd_rec : Form
    {
        public pwd_rec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login Userpage = new login();
            Userpage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text.Equals(" "))
            {
                MessageBox.Show("Enter your Email first!");
            }
            else
            {
                MessageBox.Show("Check you Email for the new password!");
            }
            
        }

        private void pwd_rec_Load(object sender, EventArgs e)
        {

        }
    }
}
