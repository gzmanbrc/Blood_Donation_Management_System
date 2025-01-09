namespace Project1
{
    partial class frmDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonor));
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cbxGender = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            txtAddress = new TextBox();
            cbxBloodGroup = new ComboBox();
            label17 = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtPhone = new TextBox();
            btnExit = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(764, 71);
            label11.Name = "label11";
            label11.Size = new Size(69, 25);
            label11.TabIndex = 7;
            label11.Text = "Donor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(434, 200);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 9;
            label12.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(770, 200);
            label13.Name = "label13";
            label13.Size = new Size(48, 25);
            label13.TabIndex = 11;
            label13.Text = "Age";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(1083, 200);
            label14.Name = "label14";
            label14.Size = new Size(80, 25);
            label14.TabIndex = 13;
            label14.Text = "Gender";
            // 
            // cbxGender
            // 
            cbxGender.FlatStyle = FlatStyle.Popup;
            cbxGender.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Female", "Male" });
            cbxGender.Location = new Point(1031, 228);
            cbxGender.Margin = new Padding(3, 2, 3, 2);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(191, 31);
            cbxGender.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(430, 366);
            label15.Name = "label15";
            label15.Size = new Size(71, 25);
            label15.TabIndex = 15;
            label15.Text = "Phone";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(746, 362);
            label16.Name = "label16";
            label16.Size = new Size(90, 25);
            label16.TabIndex = 17;
            label16.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(663, 394);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(257, 104);
            txtAddress.TabIndex = 18;
            // 
            // cbxBloodGroup
            // 
            cbxBloodGroup.FlatStyle = FlatStyle.Popup;
            cbxBloodGroup.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBloodGroup.FormattingEnabled = true;
            cbxBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            cbxBloodGroup.Location = new Point(1031, 398);
            cbxBloodGroup.Margin = new Padding(3, 2, 3, 2);
            cbxBloodGroup.Name = "cbxBloodGroup";
            cbxBloodGroup.Size = new Size(191, 31);
            cbxBloodGroup.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(1061, 366);
            label17.Name = "label17";
            label17.Size = new Size(128, 25);
            label17.TabIndex = 19;
            label17.Text = "Blood Group";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(631, 550);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(310, 44);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(743, 98);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(376, 228);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 23);
            txtName.TabIndex = 23;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(706, 228);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(192, 23);
            txtAge.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(376, 398);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 23);
            txtPhone.TabIndex = 23;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1238, 687);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 44);
            btnExit.TabIndex = 21;
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
            panel2.TabIndex = 25;
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 752);
            panel1.TabIndex = 24;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(52, 268);
            label7.Name = "label7";
            label7.Size = new Size(88, 29);
            label7.TabIndex = 72;
            label7.Text = "Patient";
            label7.Click += label7_Click;
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
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 317);
            label3.Name = "label3";
            label3.Size = new Size(158, 29);
            label3.TabIndex = 68;
            label3.Text = "View Patients";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 367);
            label4.Name = "label4";
            label4.Size = new Size(141, 29);
            label4.TabIndex = 69;
            label4.Text = "Blood Stock";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 45);
            panel3.TabIndex = 81;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(52, 8);
            label10.Name = "label10";
            label10.Size = new Size(78, 29);
            label10.TabIndex = 82;
            label10.Text = "Donor";
            // 
            // frmDonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(cbxBloodGroup);
            Controls.Add(label17);
            Controls.Add(txtAddress);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(cbxGender);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donor";
            Load += frmDonor_Load;
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
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cbxGender;
        private Label label15;
        private Label label16;
        private TextBox txtAddress;
        private ComboBox cbxBloodGroup;
        private Label label17;
        private Button btnSave;
        private PictureBox pictureBox1;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtPhone;
        private Button btnExit;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label10;
    }
}