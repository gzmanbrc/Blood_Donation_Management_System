namespace Project1
{
    partial class frmReport
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
            label18 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            lwAbleToDonateList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            lwNotAbleToDonateList = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(490, 20);
            label18.Name = "label18";
            label18.Size = new Size(456, 36);
            label18.TabIndex = 46;
            label18.Text = "Blood Bank Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1534, 76);
            panel2.TabIndex = 81;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1274, 644);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 59);
            btnBack.TabIndex = 79;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lwAbleToDonateList
            // 
            lwAbleToDonateList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lwAbleToDonateList.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lwAbleToDonateList.FullRowSelect = true;
            lwAbleToDonateList.GridLines = true;
            lwAbleToDonateList.Location = new Point(67, 172);
            lwAbleToDonateList.Name = "lwAbleToDonateList";
            lwAbleToDonateList.Size = new Size(608, 342);
            lwAbleToDonateList.TabIndex = 79;
            lwAbleToDonateList.UseCompatibleStateImageBehavior = false;
            lwAbleToDonateList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Donor";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Blood Group";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Amount";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date";
            columnHeader5.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(67, 133);
            label1.Name = "label1";
            label1.Size = new Size(145, 24);
            label1.TabIndex = 83;
            label1.Text = "Able To Donate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(813, 133);
            label2.Name = "label2";
            label2.Size = new Size(182, 24);
            label2.TabIndex = 84;
            label2.Text = "Not Able To Donate";
            // 
            // lwNotAbleToDonateList
            // 
            lwNotAbleToDonateList.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lwNotAbleToDonateList.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lwNotAbleToDonateList.FullRowSelect = true;
            lwNotAbleToDonateList.GridLines = true;
            lwNotAbleToDonateList.Location = new Point(813, 172);
            lwNotAbleToDonateList.Name = "lwNotAbleToDonateList";
            lwNotAbleToDonateList.Size = new Size(608, 342);
            lwNotAbleToDonateList.TabIndex = 85;
            lwNotAbleToDonateList.UseCompatibleStateImageBehavior = false;
            lwNotAbleToDonateList.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Donor";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Blood Group";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Amount";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Date";
            columnHeader10.Width = 150;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 800);
            Controls.Add(lwNotAbleToDonateList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lwAbleToDonateList);
            Controls.Add(panel2);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReport";
            Text = "frmReport";
            Load += frmReport_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label18;
        private Panel panel2;
        private Label label11;
        private Button btnBack;
        private ListView lwAbleToDonateList;
        private ListView lwVeremezler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Label label2;
        private ListView lwNotAbleToDonateList;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}