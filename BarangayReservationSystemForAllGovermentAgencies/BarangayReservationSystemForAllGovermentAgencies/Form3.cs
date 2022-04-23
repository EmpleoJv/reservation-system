using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BarangayReservationSystemForAllGovermentAgencies
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void readDataBtn_Click(object sender, EventArgs e)
        {
            string dataBaseChooser = String.Empty;
            if (reservedAgencieTxb.Text == "Overseas Workers Welfare Administration(OWWA)")
            {
                dataBaseChooser = "overseas_workers_weslfare_administration";
            }
            else if (reservedAgencieTxb.Text == "Philippine Health Insurance Corporation(PHILHEALTH)")
            {
                dataBaseChooser = "philippine_health_insurance_corporation";
            }
            else if (reservedAgencieTxb.Text == "Philippine Overseas Employment Administration(POEA)")
            {
                dataBaseChooser = "philippine_overseas_employment_administration";
            }
            else if (reservedAgencieTxb.Text == "Department of Labor and Employment(DOLE)")
            {
                dataBaseChooser = "department_of_labor_and_employment";
            }
            else if (reservedAgencieTxb.Text == "Department of Trade and Industry(DTI)")
            {
                dataBaseChooser = "department_of_trade_and_industry";
            }
            else if (reservedAgencieTxb.Text == "Bureau of Immigration(BI)")
            {
                dataBaseChooser = "bureau_of_immigration";
            }
            else if (reservedAgencieTxb.Text == "Commission on Filipinos Overseas(CFO)")
            {
                dataBaseChooser = "commission_on_filipinos_overseas";
            }
            else if (reservedAgencieTxb.Text == "Bangko Sentral ng Pilipinas(BSP")
            {
                dataBaseChooser = "bangko_sentral_ng_pilipinas";
            }
            else if (reservedAgencieTxb.Text == "Commission of Elections(COMELEC)")
            {
                dataBaseChooser = "commission_of_elections";
            }
            else if (reservedAgencieTxb.Text == "Department of Tourism(DOT)")
            {
                dataBaseChooser = "department_of_tourism";
            }
            else if (reservedAgencieTxb.Text == "Office of the President(OP)")
            {
                dataBaseChooser = "office_of_the_president";
            }
            else if (reservedAgencieTxb.Text == "Office of the Press Secretary(OPS)")
            {
                dataBaseChooser = "office_of_the_press_secretary";
            }
            else if (reservedAgencieTxb.Text == "Overseas Absentee Voting Secretariat(OAVS)")
            {
                dataBaseChooser = "overseas_absentee_voting_secretariat";
            }
            else if (reservedAgencieTxb.Text == "National Economic and Development Authority(NEDA)")
            {
                dataBaseChooser = "national_economic_and_development authority";
            }
            else if (reservedAgencieTxb.Text == "PAGIBIG Home Development Mutual Fund(PAGIBIG)")
            {
                dataBaseChooser = "pagibig_home_development_mutual_fund";
            }
            else if (reservedAgencieTxb.Text == "Social Security System(SSS)")
            {
                dataBaseChooser = "social_security_system";
            }
            else if (reservedAgencieTxb.Text == "Philippine Institute for Development Studies(PIDS)")
            {
                dataBaseChooser = "philippine_institute_for_development_studies";
            }
            else if (reservedAgencieTxb.Text == "Bureau of Customs(BOC)")
            {
                dataBaseChooser = "bureau_of_customs";
            }
            else
            {

                reservedAgencieTxb.Text = "";
                MessageBox.Show("Invalid Government Agency" + "Use the drop down");
            }
            
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string selectedForData = this.reservedAgencieTxb.GetItemText(this.reservedAgencieTxb.SelectedItem); 
            string conString = "datasource=localhost;username=root;password=;database=test;";
            string query = "SELECT * FROM " + dataBaseChooser + ";" ;
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string IdS = myReader.GetString("id");
                    string fnameS = myReader.GetString("firstName");
                    string lnameS = myReader.GetString("lastName");
                    string middleS = myReader.GetString("middleName");
                    string ageS = myReader.GetString("age");
                    string emailS = myReader.GetString("email");
                    string mobileS = myReader.GetString("mobileNumber");
                    string validS = myReader.GetString("validId");
                    string idnumS = myReader.GetString("idNumber");
                    string dateS = myReader.GetString("date");
                    string researvedS = myReader.GetString("reservedAgencie");
                    string codeS = myReader.GetString("reseravationCode");

                    dataGridView1.Rows.Add(IdS, fnameS, lnameS, middleS, ageS, emailS, mobileS, validS, idnumS, dateS, researvedS, codeS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting to Database " +ex.Message);
            }
            conn.Close();
        }
    }
}
