namespace Project1
{
    partial class frmViewPatient
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
            btnDelete = new Button();
            label11 = new Label();
            btnEdit = new Button();
            label1 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtPhone = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            cbxBloodGroup = new ComboBox();
            txtAddress = new TextBox();
            cbxGender = new ComboBox();
            btnExit = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            lwPatientList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtPatientID = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(791, 683);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 45);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(707, 75);
            label11.Name = "label11";
            label11.Size = new Size(129, 25);
            label11.TabIndex = 25;
            label11.Text = "Patients List";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(599, 683);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(186, 45);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(349, 255);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 50;
            label1.Text = "Blood Group";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(640, 253);
            label19.Name = "label19";
            label19.Size = new Size(90, 25);
            label19.TabIndex = 49;
            label19.Text = "Address";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(851, 132);
            label20.Name = "label20";
            label20.Size = new Size(71, 25);
            label20.TabIndex = 48;
            label20.Text = "Phone";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(1085, 132);
            label21.Name = "label21";
            label21.Size = new Size(80, 25);
            label21.TabIndex = 47;
            label21.Text = "Gender";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(628, 132);
            label22.Name = "label22";
            label22.Size = new Size(48, 25);
            label22.TabIndex = 46;
            label22.Text = "Age";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(378, 132);
            label23.Name = "label23";
            label23.Size = new Size(67, 25);
            label23.TabIndex = 45;
            label23.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(791, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 30);
            txtPhone.TabIndex = 54;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(557, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(192, 30);
            txtAge.TabIndex = 55;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(317, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 30);
            txtName.TabIndex = 56;
            // 
            // cbxBloodGroup
            // 
            cbxBloodGroup.FlatStyle = FlatStyle.System;
            cbxBloodGroup.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBloodGroup.FormattingEnabled = true;
            cbxBloodGroup.Items.AddRange(new object[] { "" });
            cbxBloodGroup.Location = new Point(317, 300);
            cbxBloodGroup.Margin = new Padding(3, 2, 3, 2);
            cbxBloodGroup.Name = "cbxBloodGroup";
            cbxBloodGroup.Size = new Size(191, 31);
            cbxBloodGroup.TabIndex = 53;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(557, 300);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(257, 78);
            txtAddress.TabIndex = 52;
            // 
            // cbxGender
            // 
            cbxGender.FlatStyle = FlatStyle.System;
            cbxGender.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "" });
            cbxGender.Location = new Point(1032, 169);
            cbxGender.Margin = new Padding(3, 2, 3, 2);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(191, 31);
            cbxGender.TabIndex = 51;
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
            btnExit.TabIndex = 57;
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
            panel2.TabIndex = 61;
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 752);
            panel1.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 168);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 76;
            label2.Text = "Donate";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 598);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 74;
            label3.Text = "Logout";
            label3.Click += label3_Click;
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
            label7.Click += label7_Click_1;
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
            // lwPatientList
            // 
            lwPatientList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lwPatientList.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lwPatientList.FullRowSelect = true;
            lwPatientList.GridLines = true;
            lwPatientList.Location = new Point(279, 401);
            lwPatientList.Name = "lwPatientList";
            lwPatientList.Size = new Size(1039, 277);
            lwPatientList.TabIndex = 62;
            lwPatientList.UseCompatibleStateImageBehavior = false;
            lwPatientList.View = View.Details;
            lwPatientList.SelectedIndexChanged += lwPatientList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Gender";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Blood Group";
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
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phone";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Address";
            columnHeader7.Width = 200;
            // 
            // txtPatientID
            // 
            txtPatientID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientID.Location = new Point(279, 172);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(33, 30);
            txtPatientID.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 45);
            panel3.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(51, 8);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 77;
            label4.Text = "View Patients";
            // 
            // frmViewPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 752);
            Controls.Add(txtPatientID);
            Controls.Add(lwPatientList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(txtPhone);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(cbxBloodGroup);
            Controls.Add(txtAddress);
            Controls.Add(cbxGender);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmViewPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPatient";
            Load += frmViewPatient_Load;
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
        private Button btnDelete;
        private Label label11;
        private Button btnEdit;
        private Label label1;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtPhone;
        private TextBox txtAge;
        private TextBox txtName;
        private ComboBox cbxBloodGroup;
        private TextBox txtAddress;
        private ComboBox cbxGender;
        private Button btnExit;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label6;
        private Label label9;
        private ListView lwPatientList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox txtPatientID;
        private Panel panel3;
        private Label label4;
    }
}