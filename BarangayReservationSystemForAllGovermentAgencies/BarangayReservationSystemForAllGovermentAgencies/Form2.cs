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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
                firstnameTxB.Text = "";
                lastnameTxB.Text = "";
                middleNameTxb.Text = "";
                ageTxb.Text = "";
                emailTxb.Text = "";
                mobileNumberTxb.Text = "";
                validIdTxb.Text = "";
                idNumberTxb.Text = "";
                reservedAgencieTxb.Text = "";
                generatedCodeTxb.Text = "";
                MessageBox.Show("Invalid Government Agency" + "Use the drop down");
            }

            string theDate = dateTxb.Value.ToString("yyyy-MM-dd");
            string selected = this.reservedAgencieTxb.GetItemText(this.reservedAgencieTxb.SelectedItem);

            try
            {
                string conString = "datasource=localhost;username=root;password=;database=test;";
                string query = "insert into "+ dataBaseChooser + " (firstName,lastName,middleName,age,email,mobileNumber,validId,idNumber,date,reservedAgencie,reseravationCode)" +
                    " values('"+this.firstnameTxB.Text+"','"+this.lastnameTxB.Text+"','"+this.middleNameTxb.Text+"','"+this.ageTxb.Text+"','"+this.emailTxb.Text+ "','" + this.mobileNumberTxb.Text + "','" + this.validIdTxb.Text + "','" + this.idNumberTxb.Text + "','" + theDate + "','" + selected + "','" + generatedCodeTxb.Text + "');";

                //string query = "insert into " + dataBaseChooser + "(firstName,lastName,middleName,age,email,mobileNumber,validId,idNumber,date,reservedAgencie,reseravationCode) " +
                //  "values('" + this.firstnameTxB.Text + "','" + this.lastnameTxB.Text + "','" + this.middleNameTxb.Text + "','" + this.ageTxb.Text + "','" + this.emailTxb.Text + "','" + this.mobileNumberTxb.Text + "','" + this.validIdTxb.Text + "','" + this.idNumberTxb.Text + "','" + theDate + "','" + selected + "','" + this.generatedCodeTxb.Text + "');";

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                conn.Close();
                firstnameTxB.Text = "";
                lastnameTxB.Text = "";
                middleNameTxb.Text = "";
                ageTxb.Text = "";
                emailTxb.Text = "";
                mobileNumberTxb.Text = "";
                validIdTxb.Text = "";
                idNumberTxb.Text = "";
                reservedAgencieTxb.Text = "";
                generatedCodeTxb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                Console.WriteLine(ex);
                MessageBox.Show("Invalid Government Agency" + "Use the drop down");
            }
        }
        private void codeGeneratorBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNum = rand.Next(10000, 99999);
            generatedCodeTxb.Text = randomNum+this.firstnameTxB.Text+this.lastnameTxB.Text+ageTxb.Text;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(generatedCodeTxb.Text, QRCoder.QRCodeGenerator.ECCLevel.M);
            var code = new QRCoder.QRCode(MyData);
            pb1.Image = code.GetGraphic(50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
