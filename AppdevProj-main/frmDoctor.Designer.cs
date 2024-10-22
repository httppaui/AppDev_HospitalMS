namespace HOSPITALDB
{
    partial class frmDoctor
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
            label5 = new Label();
            lblDocInfo = new Label();
            dtgPatientInfo = new DataGridView();
            lblDoc = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            cbSpecialization = new ComboBox();
            txtLicense = new TextBox();
            label1 = new Label();
            cbCrud = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnapply = new Button();
            lblback = new LinkLabel();
            lblLicenseno = new Label();
            lblFname = new Label();
            lblLname = new Label();
            lblSpecialization = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPatientInfo).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(61, 291);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 11;
            label5.Text = "CRUD";
            // 
            // lblDocInfo
            // 
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(1052, 544);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(0, 25);
            lblDocInfo.TabIndex = 13;
            // 
            // dtgPatientInfo
            // 
            dtgPatientInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPatientInfo.BackgroundColor = Color.LightCyan;
            dtgPatientInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPatientInfo.GridColor = Color.Teal;
            dtgPatientInfo.Location = new Point(61, 394);
            dtgPatientInfo.MultiSelect = false;
            dtgPatientInfo.Name = "dtgPatientInfo";
            dtgPatientInfo.ReadOnly = true;
            dtgPatientInfo.RowHeadersWidth = 62;
            dtgPatientInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPatientInfo.Size = new Size(931, 476);
            dtgPatientInfo.TabIndex = 39;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.BackColor = Color.Transparent;
            lblDoc.Font = new Font("Verdana", 9F);
            lblDoc.Location = new Point(1022, 394);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(183, 22);
            lblDoc.TabIndex = 37;
            lblDoc.Text = "Doctor Information";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(338, 167);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(346, 31);
            txtFname.TabIndex = 3;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(740, 167);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(346, 31);
            txtLname.TabIndex = 2;
            // 
            // cbSpecialization
            // 
            cbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpecialization.FormattingEnabled = true;
            cbSpecialization.Location = new Point(1142, 168);
            cbSpecialization.Name = "cbSpecialization";
            cbSpecialization.Size = new Size(275, 33);
            cbSpecialization.TabIndex = 4;
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(85, 167);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(197, 31);
            txtLicense.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(85, 140);
            label1.Name = "label1";
            label1.Size = new Size(154, 22);
            label1.TabIndex = 6;
            label1.Text = "License Number";
            // 
            // cbCrud
            // 
            cbCrud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCrud.FormattingEnabled = true;
            cbCrud.Items.AddRange(new object[] { "Insert", "Select", "Update", "Delete" });
            cbCrud.Location = new Point(61, 316);
            cbCrud.Name = "cbCrud";
            cbCrud.Size = new Size(346, 33);
            cbCrud.TabIndex = 10;
            cbCrud.SelectedIndexChanged += cbCrud_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(338, 137);
            label2.Name = "label2";
            label2.Size = new Size(108, 22);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(740, 142);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(1142, 143);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 9;
            label4.Text = "Specialization";
            // 
            // btnapply
            // 
            btnapply.BackColor = Color.Teal;
            btnapply.Cursor = Cursors.Hand;
            btnapply.FlatStyle = FlatStyle.Popup;
            btnapply.Font = new Font("Verdana", 9F);
            btnapply.ForeColor = Color.White;
            btnapply.Location = new Point(442, 309);
            btnapply.Name = "btnapply";
            btnapply.Size = new Size(141, 46);
            btnapply.TabIndex = 35;
            btnapply.Text = "Apply";
            btnapply.UseVisualStyleBackColor = false;
            btnapply.Click += btnapply_Click_1;
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
            lblback.TabIndex = 41;
            lblback.TabStop = true;
            lblback.Text = "Back";
            lblback.VisitedLinkColor = Color.White;
            lblback.LinkClicked += lblback_LinkClicked;
            // 
            // lblLicenseno
            // 
            lblLicenseno.AutoSize = true;
            lblLicenseno.Location = new Point(1035, 431);
            lblLicenseno.Name = "lblLicenseno";
            lblLicenseno.Size = new Size(19, 25);
            lblLicenseno.TabIndex = 42;
            lblLicenseno.Text = "-";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(1035, 462);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(19, 25);
            lblFname.TabIndex = 43;
            lblFname.Text = "-";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(1035, 493);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(19, 25);
            lblLname.TabIndex = 44;
            lblLname.Text = "-";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Location = new Point(1035, 524);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(19, 25);
            lblSpecialization.TabIndex = 45;
            lblSpecialization.Text = "-";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Verdana", 9F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(621, 309);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 46);
            btnReset.TabIndex = 46;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.doctor_g;
            ClientSize = new Size(1502, 903);
            Controls.Add(btnReset);
            Controls.Add(lblSpecialization);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(lblLicenseno);
            Controls.Add(lblback);
            Controls.Add(dtgPatientInfo);
            Controls.Add(lblDoc);
            Controls.Add(btnapply);
            Controls.Add(lblDocInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(cbCrud);
            Controls.Add(label1);
            Controls.Add(txtLicense);
            Controls.Add(cbSpecialization);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += frmDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPatientInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label lblDocInfo;
        private DataGridView dtgPatientInfo;
        private Label lblDoc;
        private TextBox txtFname;
        private TextBox txtLname;
        private ComboBox cbSpecialization;
        private TextBox txtLicense;
        private Label label1;
        private ComboBox cbCrud;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnapply;
        private LinkLabel lblback;
        private Label lblLicenseno;
        private Label lblFname;
        private Label lblLname;
        private Label lblSpecialization;
        private Button btnReset;
    }
}