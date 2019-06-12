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

namespace House_of_cars
{
    public partial class newaccount : Form
    {
        public newaccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login newaccount = new login();
            newaccount.Visible = true;

        }

        private void register_Click(object sender, EventArgs e)
        {
           
           /*else
            {
                SqlConnection con = new SqlConnection("Data source =DESKTOP-11EVTM9\\SQLEXPRESS;Initial catalog = StockDB;Integrated Security=true");
                string sql = "INSERT INTO StockDB.New_Account(firstname, lastname, email, phone, city, username, pwd, conf_pwd) VALUES('" + this.firstname.Text + "', '" + this.lastname.Text + "', '" + this.email.Text + "','" + this.phone.Text + "','" + this.city.Text + "','" + this.usernam.Text + "','" + this.pwd.Text + "','" + this.conf_pwd.Text + "',);";
                SqlCommand cnd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cnd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Registered!");

                }
                else
                {
                    MessageBox.Show("Not Registered!");

                }
                con.Close();
            }
            */


            /* string connexionstr = "datasource=localhost;port=3306;username=root;password=root";
               string Query = "INSERT INTO StockDB.New_Account(firstname, lastname, email, phone, city, username, pwd, conf_pwd) VALUES('" + this.firstname.Text + "', '" + this.lastname.Text + "', '" + this.email.Text + "','" + this.phone.Text + "','" + this.city.Text + "','" + this.usernam.Text + "','" + this.pwd.Text + "','" + this.conf_pwd.Text + "',);";
               MySqlConnection connexionDB = new MySqlConnection(connexionstr);
               MySqlCommand cmdDB = new MySqlCommand(Query, connexionDB);
               MySqlDataReader myReader;
               try
               {
                   connexionDB.Open();
                   myReader = cmdDB.ExecuteReader();
                   MessageBox.Show("You have been registered successfully");
                   while (myReader.Read())
                   {

                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("You are still not Registred, Check again!");
               }*/
            if (firstname.Text == "" || lastname.Text == "" || email.Text == "" || usernam.Text == "" || phone.Text == "" || pwd.Text == "" || conf_pwd.Text == "")
            {
                Error.Text = "Check if everything's Full!";
                Error.Visible = true;
            }
            if (pwd.Text != conf_pwd.Text)
            {
                Error.Text = "Password and Confirm Password are not the same!";
                Error.Visible = true;
            }
            if (check.CheckState != CheckState.Checked)
            {
                Error.Text = "You must check the box to sign up!";
                Error.Visible = true;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
