namespace HOSPITALDB
{
    partial class frmRoom
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
            lblRoomInfo = new Label();
            dtgPatientInfo = new DataGridView();
            cbCrud = new ComboBox();
            txtRoomNo = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtRoomtype = new TextBox();
            btnApply = new Button();
            lblback = new LinkLabel();
            lblRoomAvailability = new Label();
            cboRoomAvailability = new ComboBox();
            lblRoomNum = new Label();
            lblRoomType = new Label();
            lblRoomAvail = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPatientInfo).BeginInit();
            SuspendLayout();
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.BackColor = Color.Transparent;
            lblRoomInfo.Font = new Font("Verdana", 9F);
            lblRoomInfo.Location = new Point(1022, 394);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(176, 22);
            lblRoomInfo.TabIndex = 15;
            lblRoomInfo.Text = "Room Information";
            // 
            // dtgPatientInfo
            // 
            dtgPatientInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPatientInfo.BackgroundColor = Color.LightCyan;
            dtgPatientInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPatientInfo.GridColor = Color.Teal;
            dtgPatientInfo.Location = new Point(61, 394);
            dtgPatientInfo.Name = "dtgPatientInfo";
            dtgPatientInfo.RowHeadersWidth = 62;
            dtgPatientInfo.Size = new Size(931, 476);
            dtgPatientInfo.TabIndex = 21;
            // 
            // cbCrud
            // 
            cbCrud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCrud.FormattingEnabled = true;
            cbCrud.Items.AddRange(new object[] { "Insert", "Select", "Update", "Delete" });
            cbCrud.Location = new Point(60, 294);
            cbCrud.Name = "cbCrud";
            cbCrud.Size = new Size(346, 33);
            cbCrud.TabIndex = 17;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Location = new Point(143, 161);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(346, 31);
            txtRoomNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 132);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 7;
            label1.Text = "Room Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(60, 267);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 19;
            label4.Text = "CRUD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(578, 132);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 8;
            label2.Text = "Room Type";
            // 
            // txtRoomtype
            // 
            txtRoomtype.ForeColor = Color.Black;
            txtRoomtype.Location = new Point(578, 160);
            txtRoomtype.Name = "txtRoomtype";
            txtRoomtype.Size = new Size(346, 31);
            txtRoomtype.TabIndex = 9;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Teal;
            btnApply.Cursor = Cursors.Hand;
            btnApply.FlatStyle = FlatStyle.Popup;
            btnApply.Font = new Font("Verdana", 9F);
            btnApply.ForeColor = Color.Transparent;
            btnApply.Location = new Point(463, 287);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(141, 46);
            btnApply.TabIndex = 36;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click_1;
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
            // lblRoomAvailability
            // 
            lblRoomAvailability.AutoSize = true;
            lblRoomAvailability.BackColor = Color.Transparent;
            lblRoomAvailability.Font = new Font("Verdana", 9F);
            lblRoomAvailability.Location = new Point(1015, 132);
            lblRoomAvailability.Name = "lblRoomAvailability";
            lblRoomAvailability.Size = new Size(168, 22);
            lblRoomAvailability.TabIndex = 44;
            lblRoomAvailability.Text = "Room Availability";
            // 
            // cboRoomAvailability
            // 
            cboRoomAvailability.FormattingEnabled = true;
            cboRoomAvailability.Items.AddRange(new object[] { "Occupied", "Available" });
            cboRoomAvailability.Location = new Point(1013, 161);
            cboRoomAvailability.Name = "cboRoomAvailability";
            cboRoomAvailability.Size = new Size(346, 33);
            cboRoomAvailability.TabIndex = 45;
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.BackColor = Color.Transparent;
            lblRoomNum.Font = new Font("Verdana", 9F);
            lblRoomNum.Location = new Point(1022, 439);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(18, 22);
            lblRoomNum.TabIndex = 46;
            lblRoomNum.Text = "-";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = Color.Transparent;
            lblRoomType.Font = new Font("Verdana", 9F);
            lblRoomType.Location = new Point(1022, 471);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(18, 22);
            lblRoomType.TabIndex = 47;
            lblRoomType.Text = "-";
            // 
            // lblRoomAvail
            // 
            lblRoomAvail.AutoSize = true;
            lblRoomAvail.BackColor = Color.Transparent;
            lblRoomAvail.Font = new Font("Verdana", 9F);
            lblRoomAvail.Location = new Point(1022, 508);
            lblRoomAvail.Name = "lblRoomAvail";
            lblRoomAvail.Size = new Size(18, 22);
            lblRoomAvail.TabIndex = 48;
            lblRoomAvail.Text = "-";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Verdana", 9F);
            btnReset.ForeColor = Color.Transparent;
            btnReset.Location = new Point(645, 287);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 46);
            btnReset.TabIndex = 49;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.room_bg;
            ClientSize = new Size(1502, 903);
            Controls.Add(btnReset);
            Controls.Add(lblRoomAvail);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNum);
            Controls.Add(cboRoomAvailability);
            Controls.Add(lblRoomAvailability);
            Controls.Add(lblback);
            Controls.Add(btnApply);
            Controls.Add(dtgPatientInfo);
            Controls.Add(label4);
            Controls.Add(txtRoomtype);
            Controls.Add(cbCrud);
            Controls.Add(label2);
            Controls.Add(lblRoomInfo);
            Controls.Add(label1);
            Controls.Add(txtRoomNo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room";
            Load += frmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPatientInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRoomInfo;
        private DataGridView dtgPatientInfo;
        private ComboBox cbCrud;
        private TextBox txtRoomNo;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox txtRoomtype;
        private Button btnApply;
        private LinkLabel lblback;
        private Label lblRoomAvailability;
        private ComboBox cboRoomAvailability;
        private Label lblRoomNum;
        private Label lblRoomType;
        private Label lblRoomAvail;
        private Button btnReset;
    }
}