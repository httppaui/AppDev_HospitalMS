namespace HOSPITALDB
{
    partial class frmPatient
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
            lblDocPatInfo = new Label();
            label5 = new Label();
            cbCrud = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgPatient = new DataGridView();
            cbLicense = new ComboBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            txtFname = new TextBox();
            cbRoomNo = new ComboBox();
            txtAge = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lblRoomInfo = new Label();
            btnapply = new Button();
            txtPatientID = new TextBox();
            label8 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            lblback = new LinkLabel();
            lblLicenseNumber = new Label();
            lblDoctorFirstName = new Label();
            lblDoctorLastName = new Label();
            lblSpecialization = new Label();
            lblAvailabilityStatus = new Label();
            lblRoomType = new Label();
            lblRoomNumber = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPatient).BeginInit();
            SuspendLayout();
            // 
            // lblDocPatInfo
            // 
            lblDocPatInfo.AutoSize = true;
            lblDocPatInfo.BackColor = Color.Transparent;
            lblDocPatInfo.Font = new Font("Verdana", 9F);
            lblDocPatInfo.Location = new Point(1022, 394);
            lblDocPatInfo.Name = "lblDocPatInfo";
            lblDocPatInfo.Size = new Size(272, 22);
            lblDocPatInfo.TabIndex = 28;
            lblDocPatInfo.Text = "Patient Doctor's Information ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(61, 299);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 25;
            label5.Text = "CRUD";
            // 
            // cbCrud
            // 
            cbCrud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCrud.FormattingEnabled = true;
            cbCrud.Items.AddRange(new object[] { "Insert", "Select", "Update", "Delete" });
            cbCrud.Location = new Point(66, 331);
            cbCrud.Name = "cbCrud";
            cbCrud.Size = new Size(346, 33);
            cbCrud.TabIndex = 24;
            cbCrud.SelectedIndexChanged += cbCrud_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(460, 204);
            label4.Name = "label4";
            label4.Size = new Size(169, 22);
            label4.TabIndex = 23;
            label4.Text = "DoctorsLicenseNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(851, 109);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 22;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(61, 204);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 21;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(460, 109);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 20;
            label1.Text = "First Name";
            // 
            // dtgPatient
            // 
            dtgPatient.BackgroundColor = Color.LightCyan;
            dtgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPatient.GridColor = Color.Teal;
            dtgPatient.Location = new Point(61, 394);
            dtgPatient.Name = "dtgPatient";
            dtgPatient.RowHeadersWidth = 62;
            dtgPatient.Size = new Size(931, 476);
            dtgPatient.TabIndex = 19;
            // 
            // cbLicense
            // 
            cbLicense.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicense.FormattingEnabled = true;
            cbLicense.Location = new Point(461, 235);
            cbLicense.Name = "cbLicense";
            cbLicense.Size = new Size(346, 33);
            cbLicense.TabIndex = 18;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(856, 140);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(346, 31);
            txtLname.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(66, 235);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(346, 31);
            txtAddress.TabIndex = 16;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(461, 140);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(346, 31);
            txtFname.TabIndex = 15;
            // 
            // cbRoomNo
            // 
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Location = new Point(856, 235);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(346, 33);
            cbRoomNo.TabIndex = 29;
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1251, 140);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(185, 31);
            txtAge.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9F);
            label6.Location = new Point(1247, 109);
            label6.Name = "label6";
            label6.Size = new Size(44, 22);
            label6.TabIndex = 31;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9F);
            label7.Location = new Point(851, 202);
            label7.Name = "label7";
            label7.Size = new Size(141, 22);
            label7.TabIndex = 33;
            label7.Text = "Room Number";
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.BackColor = Color.Transparent;
            lblRoomInfo.Font = new Font("Verdana", 9F);
            lblRoomInfo.Location = new Point(1022, 621);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(251, 22);
            lblRoomInfo.TabIndex = 34;
            lblRoomInfo.Text = "Patient Room Information ";
            // 
            // btnapply
            // 
            btnapply.BackColor = Color.Teal;
            btnapply.Cursor = Cursors.Hand;
            btnapply.FlatStyle = FlatStyle.Popup;
            btnapply.Font = new Font("Verdana", 9F);
            btnapply.ForeColor = Color.White;
            btnapply.Location = new Point(445, 324);
            btnapply.Name = "btnapply";
            btnapply.Size = new Size(141, 46);
            btnapply.TabIndex = 34;
            btnapply.Text = "Apply";
            btnapply.UseVisualStyleBackColor = false;
            btnapply.Click += btnapply_Click;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(66, 140);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(346, 31);
            txtPatientID.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9F);
            label8.Location = new Point(61, 109);
            label8.Name = "label8";
            label8.Size = new Size(101, 22);
            label8.TabIndex = 36;
            label8.Text = "Patient ID";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // lblback
            // 
            lblback.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            lblback.AutoSize = true;
            lblback.BackColor = Color.Teal;
            lblback.BorderStyle = BorderStyle.FixedSingle;
            lblback.Cursor = Cursors.Hand;
            lblback.DisabledLinkColor = Color.White;
            lblback.LinkColor = Color.White;
            lblback.Location = new Point(1440, 867);
            lblback.Name = "lblback";
            lblback.Size = new Size(50, 27);
            lblback.TabIndex = 42;
            lblback.TabStop = true;
            lblback.Text = "Back";
            lblback.VisitedLinkColor = Color.White;
            lblback.LinkClicked += lblback_LinkClicked;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.BackColor = Color.Transparent;
            lblLicenseNumber.Font = new Font("Verdana", 9F);
            lblLicenseNumber.Location = new Point(1035, 431);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(18, 22);
            lblLicenseNumber.TabIndex = 43;
            lblLicenseNumber.Text = "-";
            // 
            // lblDoctorFirstName
            // 
            lblDoctorFirstName.AutoSize = true;
            lblDoctorFirstName.BackColor = Color.Transparent;
            lblDoctorFirstName.Font = new Font("Verdana", 9F);
            lblDoctorFirstName.Location = new Point(1035, 462);
            lblDoctorFirstName.Name = "lblDoctorFirstName";
            lblDoctorFirstName.Size = new Size(18, 22);
            lblDoctorFirstName.TabIndex = 44;
            lblDoctorFirstName.Text = "-";
            // 
            // lblDoctorLastName
            // 
            lblDoctorLastName.AutoSize = true;
            lblDoctorLastName.BackColor = Color.Transparent;
            lblDoctorLastName.Font = new Font("Verdana", 9F);
            lblDoctorLastName.Location = new Point(1035, 493);
            lblDoctorLastName.Name = "lblDoctorLastName";
            lblDoctorLastName.Size = new Size(18, 22);
            lblDoctorLastName.TabIndex = 45;
            lblDoctorLastName.Text = "-";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.BackColor = Color.Transparent;
            lblSpecialization.Font = new Font("Verdana", 9F);
            lblSpecialization.Location = new Point(1035, 524);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(18, 22);
            lblSpecialization.TabIndex = 46;
            lblSpecialization.Text = "-";
            // 
            // lblAvailabilityStatus
            // 
            lblAvailabilityStatus.AutoSize = true;
            lblAvailabilityStatus.BackColor = Color.Transparent;
            lblAvailabilityStatus.Font = new Font("Verdana", 9F);
            lblAvailabilityStatus.Location = new Point(1035, 717);
            lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            lblAvailabilityStatus.Size = new Size(18, 22);
            lblAvailabilityStatus.TabIndex = 49;
            lblAvailabilityStatus.Text = "-";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = Color.Transparent;
            lblRoomType.Font = new Font("Verdana", 9F);
            lblRoomType.Location = new Point(1035, 686);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(18, 22);
            lblRoomType.TabIndex = 48;
            lblRoomType.Text = "-";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.BackColor = Color.Transparent;
            lblRoomNumber.Font = new Font("Verdana", 9F);
            lblRoomNumber.Location = new Point(1035, 655);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(18, 22);
            lblRoomNumber.TabIndex = 47;
            lblRoomNumber.Text = "-";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Verdana", 9F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(618, 324);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 46);
            btnReset.TabIndex = 50;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.patient_bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1502, 903);
            Controls.Add(btnReset);
            Controls.Add(lblAvailabilityStatus);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblSpecialization);
            Controls.Add(lblDoctorLastName);
            Controls.Add(lblDoctorFirstName);
            Controls.Add(lblLicenseNumber);
            Controls.Add(lblback);
            Controls.Add(txtPatientID);
            Controls.Add(label8);
            Controls.Add(btnapply);
            Controls.Add(label7);
            Controls.Add(lblRoomInfo);
            Controls.Add(label6);
            Controls.Add(lblDocPatInfo);
            Controls.Add(txtAge);
            Controls.Add(dtgPatient);
            Controls.Add(cbRoomNo);
            Controls.Add(cbCrud);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtLname);
            Controls.Add(cbLicense);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += frmPatient_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocPatInfo;
        private Label label5;
        private ComboBox cbCrud;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgPatient;
        private ComboBox cbLicense;
        private TextBox txtLname;
        private TextBox txtAddress;
        private TextBox txtFname;
        private ComboBox cbRoomNo;
        private TextBox txtAge;
        private Label label6;
        private Label label7;
        private Label lblRoomInfo;
        private Button btnapply;
        private TextBox txtPatientID;
        private Label label8;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private LinkLabel lblback;
        private Label lblLicenseNumber;
        private Label lblDoctorFirstName;
        private Label lblDoctorLastName;
        private Label lblSpecialization;
        private Label lblAvailabilityStatus;
        private Label lblRoomType;
        private Label lblRoomNumber;
        private Button btnReset;
    }
}