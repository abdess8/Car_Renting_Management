using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using House_of_cars.PL;

namespace House_of_cars
{
    public partial class login : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
       /* public bool Verify(string Username, string Password)
        {
            bool result = false;
            if (Username == "admin" && Password == "admin")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }*/
        public login()
        {
            InitializeComponent();
        }


       /* private void Username_Click(object sender, EventArgs e)
        {

        }

        */
        private void Signin_Click(object sender, EventArgs e)
        {

            DataTable dt = log.login(Username.Text, Password.Text);
            string CmbItemValue;
            try
            {
                if ((Username.Text == "") || (Password.Text == ""))
                {
                    erroor.Text = "Check if everything's Full!";
                    erroor.Visible = true;
                }
                else
                {
                    erroor.Text = "Username or Password Incorrect";
                    erroor.Visible = true;
                }
                CmbItemValue = comboBox1.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["usertype"].ToString() == CmbItemValue)
                        {
                            if (comboBox1.SelectedIndex == 0)
                            {
                                this.Visible = false;
                                adminpage Form1 = new adminpage();
                                Form1.Visible = true;
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                this.Visible = false;
                                manager_home Form1 = new manager_home();
                                Form1.Visible = true;
                            }
                            
                        }
                    
                    }
                    


                }
                
            }
            catch(Exception)
            {
                erroor.Text = "Please Select UserType!";
                erroor.Visible = true;
            }

            


        }

        private void Newaccount_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newaccount Form1 = new newaccount();
            Form1.Visible = true;
        }

        private void Passwordrecover_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pwd_rec Form1 = new pwd_rec();
            Form1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
