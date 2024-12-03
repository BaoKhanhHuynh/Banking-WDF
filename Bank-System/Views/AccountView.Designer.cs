namespace WindowsFormsApp1.Views
{
    partial class AccountView
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
            dataGridView1 = new DataGridView();
            ID = new Label();
            CustomerID = new Label();
            Date_Opened = new Label();
            Balance = new Label();
            tid = new TextBox();
            tdateopened = new TextBox();
            tbalance = new TextBox();
            groupBox1 = new GroupBox();
            tcustomerid = new TextBox();
            Edit = new Button();
            save = new Button();
            Resert = new Button();
            Close = new Button();
            Delete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(259, 189);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 144);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(35, 30);
            ID.Margin = new Padding(4, 0, 4, 0);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 0;
            ID.Text = "ID";
            ID.Click += ID_Click;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(338, 22);
            CustomerID.Margin = new Padding(4, 0, 4, 0);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(70, 15);
            CustomerID.TabIndex = 1;
            CustomerID.Text = "CustomerID";
            CustomerID.Click += CustomerID_Click;
            // 
            // Date_Opened
            // 
            Date_Opened.AutoSize = true;
            Date_Opened.Location = new Point(8, 83);
            Date_Opened.Margin = new Padding(4, 0, 4, 0);
            Date_Opened.Name = "Date_Opened";
            Date_Opened.Size = new Size(78, 15);
            Date_Opened.TabIndex = 2;
            Date_Opened.Text = "Date_Opened";
            Date_Opened.Click += Date_Opened_Click;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Location = new Point(345, 78);
            Balance.Margin = new Padding(4, 0, 4, 0);
            Balance.Name = "Balance";
            Balance.Size = new Size(48, 15);
            Balance.TabIndex = 3;
            Balance.Text = "Balance";
            Balance.Click += Balance_Click;
            // 
            // tid
            // 
            tid.Location = new Point(94, 22);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(206, 23);
            tid.TabIndex = 4;
            tid.TextChanged += tid_TextChanged;
            // 
            // tdateopened
            // 
            tdateopened.Location = new Point(94, 77);
            tdateopened.Margin = new Padding(4, 3, 4, 3);
            tdateopened.Name = "tdateopened";
            tdateopened.Size = new Size(206, 23);
            tdateopened.TabIndex = 6;
            tdateopened.TextChanged += tdateopened_TextChanged;
            // 
            // tbalance
            // 
            tbalance.Location = new Point(416, 75);
            tbalance.Margin = new Padding(4, 3, 4, 3);
            tbalance.Name = "tbalance";
            tbalance.Size = new Size(206, 23);
            tbalance.TabIndex = 7;
            tbalance.TextChanged += tbalance_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.MenuHighlight;
            groupBox1.Controls.Add(tcustomerid);
            groupBox1.Controls.Add(tbalance);
            groupBox1.Controls.Add(tdateopened);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(Balance);
            groupBox1.Controls.Add(Date_Opened);
            groupBox1.Controls.Add(CustomerID);
            groupBox1.Controls.Add(ID);
            groupBox1.Location = new Point(169, 40);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(668, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tcustomerid
            // 
            tcustomerid.Location = new Point(416, 17);
            tcustomerid.Margin = new Padding(4, 3, 4, 3);
            tcustomerid.Name = "tcustomerid";
            tcustomerid.Size = new Size(206, 23);
            tcustomerid.TabIndex = 8;
            tcustomerid.TextChanged += tcustomerid_TextChanged_1;
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(255, 192, 192);
            Edit.Location = new Point(749, 208);
            Edit.Margin = new Padding(4, 3, 4, 3);
            Edit.Name = "Edit";
            Edit.Size = new Size(88, 27);
            Edit.TabIndex = 2;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.GradientInactiveCaption;
            save.Location = new Point(507, 354);
            save.Margin = new Padding(4, 3, 4, 3);
            save.Name = "save";
            save.Size = new Size(88, 27);
            save.TabIndex = 3;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // Resert
            // 
            Resert.BackColor = Color.FromArgb(255, 192, 192);
            Resert.Location = new Point(749, 268);
            Resert.Margin = new Padding(4, 3, 4, 3);
            Resert.Name = "Resert";
            Resert.Size = new Size(88, 27);
            Resert.TabIndex = 4;
            Resert.Text = "Resert";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // Close
            // 
            Close.BackColor = SystemColors.ControlDark;
            Close.Location = new Point(637, 354);
            Close.Margin = new Padding(4, 3, 4, 3);
            Close.Name = "Close";
            Close.Size = new Size(88, 27);
            Close.TabIndex = 5;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(381, 354);
            Delete.Margin = new Padding(4, 3, 4, 3);
            Delete.Name = "Delete";
            Delete.Size = new Size(88, 27);
            Delete.TabIndex = 6;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 6);
            label1.Name = "label1";
            label1.Size = new Size(316, 31);
            label1.TabIndex = 7;
            label1.Text = "Account INFORMATION";
            label1.Click += label1_Click;
            // 
            // AccountView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Controls.Add(Delete);
            Controls.Add(Close);
            Controls.Add(Resert);
            Controls.Add(save);
            Controls.Add(Edit);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AccountView";
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            Load += Account_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label Date_Opened;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox tdateopened;
        private System.Windows.Forms.TextBox tbalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tcustomerid;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Resert;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Delete;
        private Label label1;
    }
}