using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayReservationSystemForAllGovermentAgencies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;username=root;password=;database=test;";
            string query = "SELECT * FROM userlogin";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string user = myReader.GetString("username");
                    string pass = myReader.GetString("password");
                    if (userTxb.Text == user)
                    {
                        if (passtxb.Text == pass)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                        else
                        {
                            userTxb.Text = "";
                            passtxb.Text = "";
                            MessageBox.Show("Password Error");
                        }
                    }
                    else
                    {
                        userTxb.Text = "";
                        passtxb.Text = "";
                        MessageBox.Show("Username Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }


    }
}
