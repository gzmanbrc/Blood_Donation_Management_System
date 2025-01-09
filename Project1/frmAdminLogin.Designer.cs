namespace Project1
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            label18 = new Label();
            label5 = new Label();
            lblContinueAsAdmin = new Label();
            btnLogin = new Button();
            txtAdminPassword = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(324, 203);
            label18.Name = "label18";
            label18.Size = new Size(366, 29);
            label18.TabIndex = 56;
            label18.Text = "Blood Bank Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1111, 101);
            label5.Name = "label5";
            label5.Size = new Size(28, 28);
            label5.TabIndex = 55;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // lblContinueAsAdmin
            // 
            lblContinueAsAdmin.AutoSize = true;
            lblContinueAsAdmin.Font = new Font("Bahnschrift", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblContinueAsAdmin.ForeColor = Color.Red;
            lblContinueAsAdmin.Location = new Point(466, 627);
            lblContinueAsAdmin.Name = "lblContinueAsAdmin";
            lblContinueAsAdmin.Size = new Size(59, 19);
            lblContinueAsAdmin.TabIndex = 54;
            lblContinueAsAdmin.Text = "Cancel";
            lblContinueAsAdmin.Click += lblContinueAsAdmin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(351, 559);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(293, 52);
            btnLogin.TabIndex = 53;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdminPassword.Location = new Point(417, 426);
            txtAdminPassword.Margin = new Padding(3, 2, 3, 2);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.Size = new Size(298, 36);
            txtAdminPassword.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(260, 429);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 51;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, 269);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(label18);
            Controls.Add(label5);
            Controls.Add(lblContinueAsAdmin);
            Controls.Add(btnLogin);
            Controls.Add(txtAdminPassword);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += frmAdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Label label5;
        private Label lblContinueAsAdmin;
        private Button btnLogin;
        private TextBox txtAdminPassword;
        private Label label3;
        private PictureBox pictureBox1;
    }
}