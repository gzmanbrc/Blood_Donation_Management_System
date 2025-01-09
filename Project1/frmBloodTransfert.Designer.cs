namespace Project1
{
    partial class frmBloodTransfert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloodTransfert));
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label13 = new Label();
            label11 = new Label();
            label14 = new Label();
            txtBloodGroupName = new TextBox();
            cbxPatientName = new ComboBox();
            btnExit = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPatientID = new TextBox();
            btnTransfer = new Button();
            txtPatientBloodGroupID = new TextBox();
            txtBloodStock = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(846, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(1221, 404);
            label17.Name = "label17";
            label17.Size = new Size(166, 33);
            label17.TabIndex = 53;
            label17.Text = "Blood Group";
            label17.Click += label17_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(827, 404);
            label13.Name = "label13";
            label13.Size = new Size(176, 33);
            label13.TabIndex = 46;
            label13.Text = "Patient Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(807, 153);
            label11.Name = "label11";
            label11.Size = new Size(215, 35);
            label11.TabIndex = 42;
            label11.Text = "Blood Transfert";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(491, 404);
            label14.Name = "label14";
            label14.Size = new Size(131, 33);
            label14.TabIndex = 48;
            label14.Text = "Patient ID";
            // 
            // txtBloodGroupName
            // 
            txtBloodGroupName.BackColor = Color.White;
            txtBloodGroupName.BorderStyle = BorderStyle.None;
            txtBloodGroupName.Enabled = false;
            txtBloodGroupName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBloodGroupName.Location = new Point(1255, 449);
            txtBloodGroupName.Margin = new Padding(3, 4, 3, 4);
            txtBloodGroupName.Name = "txtBloodGroupName";
            txtBloodGroupName.Size = new Size(86, 29);
            txtBloodGroupName.TabIndex = 62;
            // 
            // cbxPatientName
            // 
            cbxPatientName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPatientName.FormattingEnabled = true;
            cbxPatientName.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            cbxPatientName.Location = new Point(792, 449);
            cbxPatientName.Name = "cbxPatientName";
            cbxPatientName.Size = new Size(218, 37);
            cbxPatientName.TabIndex = 63;
            cbxPatientName.SelectedIndexChanged += cbxPatientName_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1419, 929);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 59);
            btnExit.TabIndex = 64;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(273, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 76);
            panel2.TabIndex = 67;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(430, 19);
            label18.Name = "label18";
            label18.Size = new Size(456, 36);
            label18.TabIndex = 46;
            label18.Text = "Blood Bank Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 1003);
            panel1.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 224);
            label1.Name = "label1";
            label1.Size = new Size(110, 36);
            label1.TabIndex = 76;
            label1.Text = "Donate";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 797);
            label2.Name = "label2";
            label2.Size = new Size(107, 36);
            label2.TabIndex = 74;
            label2.Text = "Logout";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 287);
            label5.Name = "label5";
            label5.Size = new Size(185, 36);
            label5.TabIndex = 70;
            label5.Text = "View Donors";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(59, 625);
            label8.Name = "label8";
            label8.Size = new Size(161, 36);
            label8.TabIndex = 73;
            label8.Text = "Dashboard";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(59, 357);
            label7.Name = "label7";
            label7.Size = new Size(110, 36);
            label7.TabIndex = 72;
            label7.Text = "Patient";
            label7.Click += label7_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Location = new Point(31, 552);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 53);
            panel7.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(59, 160);
            label10.Name = "label10";
            label10.Size = new Size(97, 36);
            label10.TabIndex = 67;
            label10.Text = "Donor";
            label10.Click += label10_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(66, 557);
            label6.Name = "label6";
            label6.Size = new Size(223, 36);
            label6.TabIndex = 71;
            label6.Text = "Blood Transfert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 423);
            label3.Name = "label3";
            label3.Size = new Size(198, 36);
            label3.TabIndex = 68;
            label3.Text = "View Patients";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 489);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 69;
            label4.Text = "Blood Stock";
            label4.Click += label4_Click;
            // 
            // txtPatientID
            // 
            txtPatientID.BackColor = Color.White;
            txtPatientID.BorderStyle = BorderStyle.None;
            txtPatientID.Enabled = false;
            txtPatientID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientID.Location = new Point(522, 453);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(51, 29);
            txtPatientID.TabIndex = 62;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.Red;
            btnTransfer.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(792, 672);
            btnTransfer.Margin = new Padding(3, 4, 3, 4);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(218, 68);
            btnTransfer.TabIndex = 68;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Visible = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // txtPatientBloodGroupID
            // 
            txtPatientBloodGroupID.BackColor = Color.White;
            txtPatientBloodGroupID.BorderStyle = BorderStyle.None;
            txtPatientBloodGroupID.Enabled = false;
            txtPatientBloodGroupID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientBloodGroupID.Location = new Point(1255, 489);
            txtPatientBloodGroupID.Margin = new Padding(3, 4, 3, 4);
            txtPatientBloodGroupID.Name = "txtPatientBloodGroupID";
            txtPatientBloodGroupID.Size = new Size(86, 29);
            txtPatientBloodGroupID.TabIndex = 69;
            txtPatientBloodGroupID.Visible = false;
            // 
            // txtBloodStock
            // 
            txtBloodStock.BackColor = Color.White;
            txtBloodStock.BorderStyle = BorderStyle.None;
            txtBloodStock.Enabled = false;
            txtBloodStock.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBloodStock.Location = new Point(1255, 528);
            txtBloodStock.Margin = new Padding(3, 4, 3, 4);
            txtBloodStock.Name = "txtBloodStock";
            txtBloodStock.Size = new Size(86, 29);
            txtBloodStock.TabIndex = 70;
            txtBloodStock.Visible = false;
            // 
            // frmBloodTransfert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1552, 1003);
            Controls.Add(txtBloodStock);
            Controls.Add(txtPatientBloodGroupID);
            Controls.Add(btnTransfer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(cbxPatientName);
            Controls.Add(txtPatientID);
            Controls.Add(txtBloodGroupName);
            Controls.Add(pictureBox1);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBloodTransfert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodTransfert";
            Load += BloodTransfert_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label17;
        private Label label13;
        private Label label11;
        private Label label14;
        private TextBox txtPatientName;
        private TextBox txtBloodGroupName;
        private ComboBox cbxPatientName;
        private Button btnExit;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Panel panel7;
        private Label label10;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox txtPatientID;
        private Button btnTransfer;
        private TextBox txtPatientBloodGroupID;
        private TextBox txtBloodStock;
    }
}