namespace HOSPITALDB
{
    partial class frmCreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAcc));
            pictureBox1 = new PictureBox();
            txtPassword = new MaskedTextBox();
            txtUsername = new MaskedTextBox();
            btnCreate = new Button();
            label2 = new Label();
            Username = new Label();
            label1 = new Label();
            label4 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 830);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(846, 425);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 31);
            txtPassword.TabIndex = 24;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(846, 313);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 31);
            txtUsername.TabIndex = 23;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(836, 516);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(141, 46);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Sign up";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(836, 377);
            label2.Name = "label2";
            label2.Size = new Size(140, 34);
            label2.TabIndex = 20;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(836, 264);
            Username.Name = "Username";
            Username.Size = new Size(151, 34);
            Username.TabIndex = 19;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(893, 167);
            label1.Name = "label1";
            label1.Size = new Size(233, 34);
            label1.TabIndex = 18;
            label1.Text = "Create Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(835, 249);
            label4.Name = "label4";
            label4.Size = new Size(0, 34);
            label4.TabIndex = 27;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1037, 516);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 46);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back to Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmCreateAcc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 829);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateAcc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            Load += frmCreateAcc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaskedTextBox txtPassword;
        private MaskedTextBox txtUsername;
        private Button btnCreate;
        private Label label2;
        private Label Username;
        private Label label1;
        private Label label4;
        private Button btnBack;
    }
}