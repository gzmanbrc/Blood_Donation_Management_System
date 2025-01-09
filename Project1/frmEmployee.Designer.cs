namespace Project1
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            txtEmployeeName = new TextBox();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnSave = new Button();
            label17 = new Label();
            label12 = new Label();
            txtEmployeePassword = new TextBox();
            label11 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            txtEmployeeID = new TextBox();
            lwEmployeeList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeName.HideSelection = false;
            txtEmployeeName.Location = new Point(1157, 416);
            txtEmployeeName.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(236, 36);
            txtEmployeeName.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(904, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1415, 916);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 59);
            btnExit.TabIndex = 54;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(567, 797);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(219, 59);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(1015, 488);
            label17.Name = "label17";
            label17.Size = new Size(136, 33);
            label17.TabIndex = 51;
            label17.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1057, 416);
            label12.Name = "label12";
            label12.Size = new Size(85, 33);
            label12.TabIndex = 50;
            label12.Text = "Name";
            // 
            // txtEmployeePassword
            // 
            txtEmployeePassword.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeePassword.HideSelection = false;
            txtEmployeePassword.Location = new Point(1157, 487);
            txtEmployeePassword.Margin = new Padding(3, 4, 3, 4);
            txtEmployeePassword.Name = "txtEmployeePassword";
            txtEmployeePassword.Size = new Size(278, 36);
            txtEmployeePassword.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(873, 116);
            label11.Name = "label11";
            label11.Size = new Size(146, 33);
            label11.TabIndex = 49;
            label11.Text = "Employees";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1061, 797);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(219, 59);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Green;
            btnEdit.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(815, 797);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(219, 59);
            btnEdit.TabIndex = 61;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(273, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 76);
            panel2.TabIndex = 63;
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
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 1003);
            panel1.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 280);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 60);
            panel3.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(58, 11);
            label5.Name = "label5";
            label5.Size = new Size(161, 36);
            label5.TabIndex = 75;
            label5.Text = "Employees";
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
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeID.HideSelection = false;
            txtEmployeeID.Location = new Point(1400, 417);
            txtEmployeeID.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(35, 36);
            txtEmployeeID.TabIndex = 64;
            // 
            // lwEmployeeList
            // 
            lwEmployeeList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lwEmployeeList.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lwEmployeeList.FullRowSelect = true;
            lwEmployeeList.GridLines = true;
            lwEmployeeList.Location = new Point(342, 280);
            lwEmployeeList.Margin = new Padding(3, 4, 3, 4);
            lwEmployeeList.Name = "lwEmployeeList";
            lwEmployeeList.Size = new Size(587, 416);
            lwEmployeeList.TabIndex = 65;
            lwEmployeeList.UseCompatibleStateImageBehavior = false;
            lwEmployeeList.View = View.Details;
            lwEmployeeList.SelectedIndexChanged += lwEmployeeList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Password";
            columnHeader3.Width = 200;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1552, 1003);
            Controls.Add(lwEmployeeList);
            Controls.Add(txtEmployeeID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(txtEmployeeName);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(label17);
            Controls.Add(label12);
            Controls.Add(txtEmployeePassword);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += frmEmployee_Load;
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
        private TextBox txtEmployeeName;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnSave;
        private Label label17;
        private Label label12;
        private TextBox txtEmployeePassword;
        private Label label11;
        private Button btnDelete;
        private Button btnEdit;
        private Panel panel2;
        private Label label18;
        private Panel panel1;
        private Label label2;
        private TextBox txtEmployeeID;
        private ListView lwEmployeeList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel3;
        private Label label5;
    }
}