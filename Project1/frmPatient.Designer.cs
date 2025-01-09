namespace Project1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            label11 = new Label();
            txtPhone = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            cbxBloodGroup = new ComboBox();
            txtAddress = new TextBox();
            cbxGender = new ComboBox();
            label10 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 130);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(932, 433);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(192, 57);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(745, 100);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 25;
            label11.Text = "Patient";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(393, 375);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 30);
            txtPhone.TabIndex = 66;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(393, 318);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(192, 30);
            txtAge.TabIndex = 67;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(393, 255);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 30);
            txtName.TabIndex = 68;
            // 
            // cbxBloodGroup
            // 
            cbxBloodGroup.FlatStyle = FlatStyle.Popup;
            cbxBloodGroup.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBloodGroup.FormattingEnabled = true;
            cbxBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            cbxBloodGroup.Location = new Point(790, 297);
            cbxBloodGroup.Margin = new Padding(3, 2, 3, 2);
            cbxBloodGroup.Name = "cbxBloodGroup";
            cbxBloodGroup.Size = new Size(191, 31);
            cbxBloodGroup.TabIndex = 65;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(393, 433);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 114);
            txtAddress.TabIndex = 64;
            // 
            // cbxGender
            // 
            cbxGender.FlatStyle = FlatStyle.Popup;
            cbxGender.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Female", "Male" });
            cbxGender.Location = new Point(1075, 290);
            cbxGender.Margin = new Padding(3, 2, 3, 2);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(191, 31);
            cbxGender.TabIndex = 63;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(822, 252);
            label10.Name = "label10";
            label10.Size = new Size(128, 25);
            label10.TabIndex = 62;
            label10.Text = "Blood Group";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(289, 433);
            label19.Name = "label19";
            label19.Size = new Size(90, 25);
            label19.TabIndex = 61;
            label19.Text = "Address";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(308, 373);
            label20.Name = "label20";
            label20.Size = new Size(71, 25);
            label20.TabIndex = 60;
            label20.Text = "Phone";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(1128, 253);
            label21.Name = "label21";
            label21.Size = new Size(80, 25);
            label21.TabIndex = 59;
            label21.Text = "Gender";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(331, 316);
            label22.Name = "label22";
            label22.Size = new Size(48, 25);
            label22.TabIndex = 58;
            label22.Text = "Age";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(312, 252);
            label23.Name = "label23";
            label23.Size = new Size(67, 25);
            label23.TabIndex = 57;
            label23.Text = "Name";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1233, 681);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 44);
            btnExit.TabIndex = 47;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(239, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 57);
            panel2.TabIndex = 70;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(376, 14);
            label18.Name = "label18";
            label18.Size = new Size(366, 29);
            label18.TabIndex = 46;
            label18.Text = "Blood Bank Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 752);
            panel1.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 168);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 76;
            label1.Text = "Donate";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 598);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 74;
            label2.Text = "Logout";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 215);
            label5.Name = "label5";
            label5.Size = new Size(148, 29);
            label5.TabIndex = 70;
            label5.Text = "View Donors";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(52, 469);
            label8.Name = "label8";
            label8.Size = new Size(129, 29);
            label8.TabIndex = 73;
            label8.Text = "Dashboard";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 120);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 67;
            label3.Text = "Donor";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 418);
            label6.Name = "label6";
            label6.Size = new Size(178, 29);
            label6.TabIndex = 71;
            label6.Text = "Blood Transfert";
            label6.Click += label6_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 317);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 68;
            label4.Text = "View Patients";
            label4.Click += label4_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(52, 367);
            label9.Name = "label9";
            label9.Size = new Size(141, 29);
            label9.TabIndex = 69;
            label9.Text = "Blood Stock";
            label9.Click += label9_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 45);
            panel3.TabIndex = 81;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(53, 8);
            label7.Name = "label7";
            label7.Size = new Size(88, 29);
            label7.TabIndex = 77;
            label7.Text = "Patient";
            // 
            // frmPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(txtPhone);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(cbxBloodGroup);
            Controls.Add(txtAddress);
            Controls.Add(cbxGender);
            Controls.Add(label10);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSave;
        private Label label11;
        private TextBox txtPhone;
        private TextBox txtAge;
        private TextBox txtName;
        private ComboBox cbxBloodGroup;
        private TextBox txtAddress;
        private ComboBox cbxGender;
        private Label label10;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Button btnExit;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label9;
        private Panel panel3;
        private Label label7;
    }
}