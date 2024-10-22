namespace HOSPITALDB
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            txtPassword = new MaskedTextBox();
            txtUsername = new MaskedTextBox();
            btnSignup = new Button();
            btnLogin = new Button();
            label2 = new Label();
            Username = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
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
            txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(846, 313);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 31);
            txtUsername.TabIndex = 16;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Black;
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(1037, 516);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(141, 46);
            btnSignup.TabIndex = 15;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(836, 516);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 46);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(836, 377);
            label2.Name = "label2";
            label2.Size = new Size(140, 34);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(836, 264);
            Username.Name = "Username";
            Username.Size = new Size(151, 34);
            Username.TabIndex = 12;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(893, 167);
            label1.Name = "label1";
            label1.Size = new Size(210, 34);
            label1.TabIndex = 11;
            label1.Text = "Ready to login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 829);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaskedTextBox txtPassword;
        private MaskedTextBox txtUsername;
        private Button btnSignup;
        private Button btnLogin;
        private Label label2;
        private Label Username;
        private Label label1;
    }
}
