namespace Project1
{
    partial class frmViewDonor
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
            label10 = new Label();
            label12 = new Label();
            btnSave = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label9 = new Label();
            btnExit = new Button();
            lwDonorList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnStatus = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(853, 105);
            label10.Name = "label10";
            label10.Size = new Size(142, 33);
            label10.TabIndex = 6;
            label10.Text = "Donor List";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(440, 191);
            label12.Name = "label12";
            label12.Size = new Size(85, 33);
            label12.TabIndex = 11;
            label12.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(793, 843);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(223, 57);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(523, 191);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 39);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(273, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 76);
            panel2.TabIndex = 26;
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 1003);
            panel1.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 280);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 60);
            panel3.TabIndex = 82;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(58, 12);
            label5.Name = "label5";
            label5.Size = new Size(185, 36);
            label5.TabIndex = 83;
            label5.Text = "View Donors";
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
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 160);
            label3.Name = "label3";
            label3.Size = new Size(97, 36);
            label3.TabIndex = 67;
            label3.Text = "Donor";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 557);
            label6.Name = "label6";
            label6.Size = new Size(223, 36);
            label6.TabIndex = 71;
            label6.Text = "Blood Transfert";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 423);
            label4.Name = "label4";
            label4.Size = new Size(198, 36);
            label4.TabIndex = 68;
            label4.Text = "View Patients";
            label4.Click += label4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(59, 489);
            label9.Name = "label9";
            label9.Size = new Size(174, 36);
            label9.TabIndex = 69;
            label9.Text = "Blood Stock";
            label9.Click += label9_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1385, 899);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 59);
            btnExit.TabIndex = 77;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lwDonorList
            // 
            lwDonorList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lwDonorList.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lwDonorList.FullRowSelect = true;
            lwDonorList.GridLines = true;
            lwDonorList.Location = new Point(310, 357);
            lwDonorList.Margin = new Padding(3, 4, 3, 4);
            lwDonorList.Name = "lwDonorList";
            lwDonorList.Size = new Size(1205, 455);
            lwDonorList.TabIndex = 78;
            lwDonorList.UseCompatibleStateImageBehavior = false;
            lwDonorList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Blood Group";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Gender";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Age";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phone";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Address";
            columnHeader7.Width = 220;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Gold;
            btnStatus.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(310, 828);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(223, 57);
            btnStatus.TabIndex = 22;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // frmViewDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1552, 1003);
            Controls.Add(btnStatus);
            Controls.Add(lwDonorList);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(label12);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDonor";
            Load += frmViewDonor_Load;
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
        private Label label10;
        private Label label12;
        private Button btnSave;
        private TextBox txtSearch;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label9;
        private Button btnExit;
        private ListView lwDonorList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Panel panel3;
        private Label label5;
        private Button btnStatus;
    }
}