namespace HOSPITALDB
{
    partial class frmLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanding));
            pictureBox1 = new PictureBox();
            pbRoom = new PictureBox();
            pbDoctor = new PictureBox();
            pbPatient = new PictureBox();
            lblRoom = new Label();
            lblDoctor = new Label();
            lblPatient = new Label();
            btnBack = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatient).BeginInit();
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
            // pbRoom
            // 
            pbRoom.Image = (Image)resources.GetObject("pbRoom.Image");
            pbRoom.Location = new Point(755, 323);
            pbRoom.Name = "pbRoom";
            pbRoom.Size = new Size(120, 120);
            pbRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRoom.TabIndex = 1;
            pbRoom.TabStop = false;
            pbRoom.Click += pbRoom_Click;
            // 
            // pbDoctor
            // 
            pbDoctor.Image = (Image)resources.GetObject("pbDoctor.Image");
            pbDoctor.Location = new Point(1119, 323);
            pbDoctor.Name = "pbDoctor";
            pbDoctor.Size = new Size(120, 120);
            pbDoctor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDoctor.TabIndex = 2;
            pbDoctor.TabStop = false;
            pbDoctor.Click += pbDoctor_Click;
            // 
            // pbPatient
            // 
            pbPatient.Image = (Image)resources.GetObject("pbPatient.Image");
            pbPatient.Location = new Point(937, 323);
            pbPatient.Name = "pbPatient";
            pbPatient.Size = new Size(120, 120);
            pbPatient.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPatient.TabIndex = 3;
            pbPatient.TabStop = false;
            pbPatient.Click += pbPatient_Click;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoom.ForeColor = Color.LightSeaGreen;
            lblRoom.Location = new Point(763, 464);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(104, 34);
            lblRoom.TabIndex = 12;
            lblRoom.Text = "ROOM";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctor.ForeColor = Color.LightSeaGreen;
            lblDoctor.Location = new Point(1113, 465);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(133, 34);
            lblDoctor.TabIndex = 13;
            lblDoctor.Text = "DOCTOR";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatient.ForeColor = Color.LightSeaGreen;
            lblPatient.Location = new Point(937, 465);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(120, 34);
            lblPatient.TabIndex = 14;
            lblPatient.Text = "PATIENT";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(930, 614);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 46);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back to Login ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(896, 83);
            label4.Name = "label4";
            label4.Size = new Size(230, 34);
            label4.TabIndex = 16;
            label4.Text = "CHOOSE TRACK";
            // 
            // frmLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 829);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(lblPatient);
            Controls.Add(lblDoctor);
            Controls.Add(lblRoom);
            Controls.Add(pbPatient);
            Controls.Add(pbDoctor);
            Controls.Add(pbRoom);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLanding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLanding";
            Load += frmLanding_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbRoom;
        private PictureBox pbDoctor;
        private PictureBox pbPatient;
        private Label lblRoom;
        private Label lblDoctor;
        private Label lblPatient;
        private Button btnBack;
        private Label label4;
    }
}