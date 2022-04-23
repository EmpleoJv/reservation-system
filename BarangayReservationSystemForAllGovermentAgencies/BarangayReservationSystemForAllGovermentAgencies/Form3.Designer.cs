namespace BarangayReservationSystemForAllGovermentAgencies
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.readDataBtn = new System.Windows.Forms.Button();
            this.reservedAgencieTxb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researvedAgencie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // readDataBtn
            // 
            this.readDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readDataBtn.Location = new System.Drawing.Point(389, 87);
            this.readDataBtn.Name = "readDataBtn";
            this.readDataBtn.Size = new System.Drawing.Size(107, 38);
            this.readDataBtn.TabIndex = 0;
            this.readDataBtn.Text = "Read Data";
            this.readDataBtn.UseVisualStyleBackColor = true;
            this.readDataBtn.Click += new System.EventHandler(this.readDataBtn_Click);
            // 
            // reservedAgencieTxb
            // 
            this.reservedAgencieTxb.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedAgencieTxb.FormattingEnabled = true;
            this.reservedAgencieTxb.Items.AddRange(new object[] {
            "Overseas Workers Welfare Administration(OWWA)",
            "Philippine Health Insurance Corporation(PHILHEALTH)",
            "Philippine Overseas Employment Administration(POEA)",
            "Department of Labor and Employment(DOLE)",
            "Department of Trade and Industry(DTI)",
            "Bureau of Immigration(BI)",
            "Commission on Filipinos Overseas(CFO)",
            "Bangko Sentral ng Pilipinas(BSP",
            "Commission of Elections(COMELEC)",
            "Department of Tourism(DOT)",
            "Office of the President(OP)",
            "Office of the Press Secretary(OPS)",
            "Overseas Absentee Voting Secretariat(OAVS)",
            "National Economic and Development Authority(NEDA)",
            "PAGIBIG Home Development Mutual Fund(PAGIBIG)",
            "Social Security System(SSS)",
            "Philippine Institute for Development Studies(PIDS)",
            "Bureau of Customs(BOC)"});
            this.reservedAgencieTxb.Location = new System.Drawing.Point(36, 92);
            this.reservedAgencieTxb.Name = "reservedAgencieTxb";
            this.reservedAgencieTxb.Size = new System.Drawing.Size(328, 27);
            this.reservedAgencieTxb.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Reserved Agency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barangay Reservation System for all Government Agencies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idData,
            this.firstName,
            this.lastName,
            this.middleName,
            this.age,
            this.email,
            this.mobileNumber,
            this.validId,
            this.idNumber,
            this.date,
            this.researvedAgencie,
            this.reservationCode});
            this.dataGridView1.Location = new System.Drawing.Point(23, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 418);
            this.dataGridView1.TabIndex = 28;
            // 
            // idData
            // 
            this.idData.HeaderText = "ID";
            this.idData.MaxInputLength = 32762;
            this.idData.Name = "idData";
            this.idData.Width = 40;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // middleName
            // 
            this.middleName.HeaderText = "Middle Initial";
            this.middleName.Name = "middleName";
            this.middleName.Width = 50;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.Width = 30;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 120;
            // 
            // mobileNumber
            // 
            this.mobileNumber.HeaderText = "Mobile Number";
            this.mobileNumber.Name = "mobileNumber";
            // 
            // validId
            // 
            this.validId.HeaderText = "Valid ID";
            this.validId.Name = "validId";
            // 
            // idNumber
            // 
            this.idNumber.HeaderText = "ID Number";
            this.idNumber.Name = "idNumber";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 110;
            // 
            // researvedAgencie
            // 
            this.researvedAgencie.HeaderText = "Researved Agencie";
            this.researvedAgencie.Name = "researvedAgencie";
            this.researvedAgencie.Width = 190;
            // 
            // reservationCode
            // 
            this.reservationCode.HeaderText = "Reservation Code";
            this.reservationCode.Name = "reservationCode";
            this.reservationCode.Width = 160;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservedAgencieTxb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.readDataBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readDataBtn;
        private System.Windows.Forms.ComboBox reservedAgencieTxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idData;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn validId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn researvedAgencie;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationCode;
    }
}