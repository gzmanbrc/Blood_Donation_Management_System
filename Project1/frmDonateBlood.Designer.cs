namespace Project1
{
    partial class frmDonateBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonateBlood));
            label11 = new Label();
            label12 = new Label();
            label17 = new Label();
            btnDonate = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            lwBloodStock = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lwDonor = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            cbxBloodGroup = new ComboBox();
            txtDonorID = new TextBox();
            txtBloodGroupID = new TextBox();
            txtBloodStock = new TextBox();
            txtBloodAmount = new TextBox();
            label9 = new Label();
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
            label11.Size = new Size(78, 25);
            label11.TabIndex = 26;
            label11.Text = "Donate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(402, 517);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 27;
            label12.Text = "Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(700, 517);
            label17.Name = "label17";
            label17.Size = new Size(128, 25);
            label17.TabIndex = 34;
            label17.Text = "Blood Group";
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.Red;
            btnDonate.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonate.ForeColor = Color.White;
            btnDonate.Location = new Point(660, 623);
            btnDonate.Margin = new Padding(3, 2, 3, 2);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(310, 44);
            btnDonate.TabIndex = 36;
            btnDonate.Text = "Donate";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
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
            btnExit.TabIndex = 38;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(775, 98);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HideSelection = false;
            txtName.Location = new Point(344, 545);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 30);
            txtName.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(889, 151);
            label13.Name = "label13";
            label13.Size = new Size(110, 25);
            label13.TabIndex = 45;
            label13.Text = "Donor List";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(346, 151);
            label14.Name = "label14";
            label14.Size = new Size(123, 25);
            label14.TabIndex = 47;
            label14.Text = "Blood Stock";
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
            panel2.TabIndex = 49;
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 752);
            panel1.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 45);
            panel3.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(51, 8);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 80;
            label1.Text = "Donate";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(52, 120);
            label10.Name = "label10";
            label10.Size = new Size(78, 29);
            label10.TabIndex = 67;
            label10.Text = "Donor";
            label10.Click += label10_Click;
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
            // lwBloodStock
            // 
            lwBloodStock.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lwBloodStock.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lwBloodStock.FullRowSelect = true;
            lwBloodStock.GridLines = true;
            lwBloodStock.Location = new Point(278, 196);
            lwBloodStock.Name = "lwBloodStock";
            lwBloodStock.Size = new Size(255, 251);
            lwBloodStock.TabIndex = 74;
            lwBloodStock.UseCompatibleStateImageBehavior = false;
            lwBloodStock.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Blood Group ID";
            columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Blood Group";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Stock";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // lwDonor
            // 
            lwDonor.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader5, columnHeader6 });
            lwDonor.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lwDonor.FullRowSelect = true;
            lwDonor.GridLines = true;
            lwDonor.Location = new Point(569, 196);
            lwDonor.Name = "lwDonor";
            lwDonor.Size = new Size(777, 251);
            lwDonor.TabIndex = 75;
            lwDonor.UseCompatibleStateImageBehavior = false;
            lwDonor.View = View.Details;
            lwDonor.SelectedIndexChanged += lwDonor_SelectedIndexChanged;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Blood Group";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Gender";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Name";
            columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Age";
            columnHeader13.Width = 50;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Phone";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Address";
            columnHeader15.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "BGID";
            columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "BSID";
            columnHeader6.Width = 0;
            // 
            // cbxBloodGroup
            // 
            cbxBloodGroup.FlatStyle = FlatStyle.Popup;
            cbxBloodGroup.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbxBloodGroup.FormattingEnabled = true;
            cbxBloodGroup.Location = new Point(675, 544);
            cbxBloodGroup.Name = "cbxBloodGroup";
            cbxBloodGroup.Size = new Size(183, 31);
            cbxBloodGroup.TabIndex = 76;
            // 
            // txtDonorID
            // 
            txtDonorID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonorID.HideSelection = false;
            txtDonorID.Location = new Point(309, 545);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(29, 30);
            txtDonorID.TabIndex = 77;
            txtDonorID.Visible = false;
            // 
            // txtBloodGroupID
            // 
            txtBloodGroupID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBloodGroupID.HideSelection = false;
            txtBloodGroupID.Location = new Point(640, 544);
            txtBloodGroupID.Name = "txtBloodGroupID";
            txtBloodGroupID.Size = new Size(29, 30);
            txtBloodGroupID.TabIndex = 78;
            txtBloodGroupID.Visible = false;
            // 
            // txtBloodStock
            // 
            txtBloodStock.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBloodStock.HideSelection = false;
            txtBloodStock.Location = new Point(605, 544);
            txtBloodStock.Name = "txtBloodStock";
            txtBloodStock.Size = new Size(29, 30);
            txtBloodStock.TabIndex = 79;
            txtBloodStock.Visible = false;
            // 
            // txtBloodAmount
            // 
            txtBloodAmount.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBloodAmount.HideSelection = false;
            txtBloodAmount.Location = new Point(980, 545);
            txtBloodAmount.Name = "txtBloodAmount";
            txtBloodAmount.Size = new Size(86, 30);
            txtBloodAmount.TabIndex = 80;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(980, 517);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 81;
            label9.Text = "Amount";
            // 
            // frmDonateBlood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(label9);
            Controls.Add(txtBloodAmount);
            Controls.Add(txtBloodStock);
            Controls.Add(txtBloodGroupID);
            Controls.Add(txtDonorID);
            Controls.Add(cbxBloodGroup);
            Controls.Add(lwDonor);
            Controls.Add(lwBloodStock);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDonate);
            Controls.Add(label17);
            Controls.Add(label12);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDonateBlood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DonateBlood";
            Load += frmDonateBlood_Load;
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
        private Label label17;
        private Button btnDonate;
        private Button btnExit;
        private PictureBox pictureBox1;
        private TextBox txtName;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label6;
        private Label label3;
        private Label label4;
        private ListView lwBloodStock;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lwDonor;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ComboBox cbxBloodGroup;
        private TextBox txtDonorID;
        private TextBox txtBloodGroupID;
        private ColumnHeader columnHeader5;
        private TextBox txtBloodStock;
        private ColumnHeader columnHeader6;
        private Panel panel3;
        private Label label1;
        private TextBox txtBloodAmount;
        private Label label9;
    }
}