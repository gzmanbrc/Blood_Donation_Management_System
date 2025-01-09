namespace Project1
{
    partial class frmBloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloodStock));
            label12 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            cbxBloodGroupFilter = new ComboBox();
            label17 = new Label();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            lwBloodStock = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(360, 129);
            label12.Name = "label12";
            label12.Size = new Size(0, 27);
            label12.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(729, 90);
            label10.Name = "label10";
            label10.Size = new Size(136, 28);
            label10.TabIndex = 25;
            label10.Text = "Blood Stock";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(742, 130);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1242, 697);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 44);
            btnExit.TabIndex = 66;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cbxBloodGroupFilter
            // 
            cbxBloodGroupFilter.FlatStyle = FlatStyle.Popup;
            cbxBloodGroupFilter.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBloodGroupFilter.FormattingEnabled = true;
            cbxBloodGroupFilter.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            cbxBloodGroupFilter.Location = new Point(742, 204);
            cbxBloodGroupFilter.Margin = new Padding(3, 2, 3, 2);
            cbxBloodGroupFilter.Name = "cbxBloodGroupFilter";
            cbxBloodGroupFilter.Size = new Size(239, 31);
            cbxBloodGroupFilter.TabIndex = 69;
            cbxBloodGroupFilter.SelectedIndexChanged += cbxBloodGroupFilter_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(615, 204);
            label17.Name = "label17";
            label17.Size = new Size(62, 25);
            label17.TabIndex = 68;
            label17.Text = "Filter";
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
            panel2.TabIndex = 72;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 752);
            panel1.TabIndex = 71;
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
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Location = new Point(27, 362);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(9, 40);
            panel5.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(58, 367);
            label9.Name = "label9";
            label9.Size = new Size(141, 29);
            label9.TabIndex = 69;
            label9.Text = "Blood Stock";
            // 
            // lwBloodStock
            // 
            lwBloodStock.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lwBloodStock.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lwBloodStock.FullRowSelect = true;
            lwBloodStock.GridLines = true;
            lwBloodStock.Location = new Point(653, 332);
            lwBloodStock.Name = "lwBloodStock";
            lwBloodStock.Size = new Size(255, 251);
            lwBloodStock.TabIndex = 73;
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
            // frmBloodStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(lwBloodStock);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbxBloodGroupFilter);
            Controls.Add(label17);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBloodStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodStock";
            Load += BloodStock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label10;
        private PictureBox pictureBox1;
        private Button btnExit;
        private ComboBox cbxBloodGroupFilter;
        private Label label17;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Panel panel5;
        private Label label9;
        private ListView lwBloodStock;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}