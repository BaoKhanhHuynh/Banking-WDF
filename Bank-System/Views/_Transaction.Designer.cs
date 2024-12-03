namespace WindowsFormsApp1
{
    partial class _Transaction
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBoxemployeeid = new TextBox();
            labelemployeeid = new Label();
            textBoxtoaccountid = new TextBox();
            labeltoaccountid = new Label();
            textBoxpin = new TextBox();
            labelpin = new Label();
            textBoxamount = new TextBox();
            labelamount = new Label();
            textdatoftrans = new TextBox();
            labeldateoftrans = new Label();
            textBoxbranchid = new TextBox();
            labelbranchid = new Label();
            textBoxfromaccounid = new TextBox();
            labelfromaccountid = new Label();
            textBoxid = new TextBox();
            labelid = new Label();
            bankSystemDataSetBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            close = new Button();
            label1 = new Label();
            save = new Button();
            Delete = new Button();
            Edit = new Button();
            Resert = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankSystemDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(textBoxemployeeid);
            groupBox1.Controls.Add(labelemployeeid);
            groupBox1.Controls.Add(textBoxtoaccountid);
            groupBox1.Controls.Add(labeltoaccountid);
            groupBox1.Controls.Add(textBoxpin);
            groupBox1.Controls.Add(labelpin);
            groupBox1.Controls.Add(textBoxamount);
            groupBox1.Controls.Add(labelamount);
            groupBox1.Controls.Add(textdatoftrans);
            groupBox1.Controls.Add(labeldateoftrans);
            groupBox1.Controls.Add(textBoxbranchid);
            groupBox1.Controls.Add(labelbranchid);
            groupBox1.Controls.Add(textBoxfromaccounid);
            groupBox1.Controls.Add(labelfromaccountid);
            groupBox1.Controls.Add(textBoxid);
            groupBox1.Controls.Add(labelid);
            groupBox1.Location = new Point(150, 58);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(715, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += labelid_Click;
            // 
            // textBoxemployeeid
            // 
            textBoxemployeeid.Location = new Point(451, 153);
            textBoxemployeeid.Margin = new Padding(4, 3, 4, 3);
            textBoxemployeeid.Name = "textBoxemployeeid";
            textBoxemployeeid.Size = new Size(206, 23);
            textBoxemployeeid.TabIndex = 15;
            textBoxemployeeid.TextChanged += textBoxemployeeid_TextChanged;
            // 
            // labelemployeeid
            // 
            labelemployeeid.AutoSize = true;
            labelemployeeid.Location = new Point(359, 156);
            labelemployeeid.Margin = new Padding(4, 0, 4, 0);
            labelemployeeid.Name = "labelemployeeid";
            labelemployeeid.Size = new Size(75, 15);
            labelemployeeid.TabIndex = 14;
            labelemployeeid.Text = "Employee_ID";
            labelemployeeid.Click += labelemployeeid_Click;
            // 
            // textBoxtoaccountid
            // 
            textBoxtoaccountid.Location = new Point(451, 116);
            textBoxtoaccountid.Margin = new Padding(4, 3, 4, 3);
            textBoxtoaccountid.Name = "textBoxtoaccountid";
            textBoxtoaccountid.Size = new Size(206, 23);
            textBoxtoaccountid.TabIndex = 13;
            textBoxtoaccountid.TextChanged += textBoxtoaccountid_TextChanged;
            // 
            // labeltoaccountid
            // 
            labeltoaccountid.AutoSize = true;
            labeltoaccountid.Location = new Point(349, 119);
            labeltoaccountid.Margin = new Padding(4, 0, 4, 0);
            labeltoaccountid.Name = "labeltoaccountid";
            labeltoaccountid.Size = new Size(85, 15);
            labeltoaccountid.TabIndex = 12;
            labeltoaccountid.Text = "To_Account_ID";
            labeltoaccountid.Click += labeltoaccountid_Click;
            // 
            // textBoxpin
            // 
            textBoxpin.Location = new Point(451, 75);
            textBoxpin.Margin = new Padding(4, 3, 4, 3);
            textBoxpin.Name = "textBoxpin";
            textBoxpin.Size = new Size(206, 23);
            textBoxpin.TabIndex = 11;
            textBoxpin.TextChanged += textBoxpin_TextChanged;
            // 
            // labelpin
            // 
            labelpin.AutoSize = true;
            labelpin.Location = new Point(410, 78);
            labelpin.Margin = new Padding(4, 0, 4, 0);
            labelpin.Name = "labelpin";
            labelpin.Size = new Size(24, 15);
            labelpin.TabIndex = 10;
            labelpin.Text = "Pin";
            labelpin.Click += labelpin_Click;
            // 
            // textBoxamount
            // 
            textBoxamount.Location = new Point(451, 30);
            textBoxamount.Margin = new Padding(4, 3, 4, 3);
            textBoxamount.Name = "textBoxamount";
            textBoxamount.Size = new Size(206, 23);
            textBoxamount.TabIndex = 9;
            textBoxamount.TextChanged += textBoxamount_TextChanged;
            // 
            // labelamount
            // 
            labelamount.AutoSize = true;
            labelamount.Location = new Point(383, 38);
            labelamount.Margin = new Padding(4, 0, 4, 0);
            labelamount.Name = "labelamount";
            labelamount.Size = new Size(51, 15);
            labelamount.TabIndex = 8;
            labelamount.Text = "Amount";
            labelamount.Click += labelamount_Click;
            // 
            // textdatoftrans
            // 
            textdatoftrans.Location = new Point(126, 156);
            textdatoftrans.Margin = new Padding(4, 3, 4, 3);
            textdatoftrans.Name = "textdatoftrans";
            textdatoftrans.Size = new Size(181, 23);
            textdatoftrans.TabIndex = 7;
            textdatoftrans.TextChanged += textdatoftrans_TextChanged;
            // 
            // labeldateoftrans
            // 
            labeldateoftrans.AutoSize = true;
            labeldateoftrans.Location = new Point(28, 159);
            labeldateoftrans.Margin = new Padding(4, 0, 4, 0);
            labeldateoftrans.Name = "labeldateoftrans";
            labeldateoftrans.Size = new Size(81, 15);
            labeldateoftrans.TabIndex = 6;
            labeldateoftrans.Text = "Date_Of_Trans";
            labeldateoftrans.Click += labeldateoftrans_Click;
            // 
            // textBoxbranchid
            // 
            textBoxbranchid.Location = new Point(126, 116);
            textBoxbranchid.Margin = new Padding(4, 3, 4, 3);
            textBoxbranchid.Name = "textBoxbranchid";
            textBoxbranchid.Size = new Size(181, 23);
            textBoxbranchid.TabIndex = 5;
            textBoxbranchid.TextChanged += textBoxbranchid_TextChanged;
            // 
            // labelbranchid
            // 
            labelbranchid.AutoSize = true;
            labelbranchid.Location = new Point(49, 119);
            labelbranchid.Margin = new Padding(4, 0, 4, 0);
            labelbranchid.Name = "labelbranchid";
            labelbranchid.Size = new Size(60, 15);
            labelbranchid.TabIndex = 4;
            labelbranchid.Text = "Branch_ID";
            labelbranchid.Click += labelbranchid_Click;
            // 
            // textBoxfromaccounid
            // 
            textBoxfromaccounid.Location = new Point(126, 75);
            textBoxfromaccounid.Margin = new Padding(4, 3, 4, 3);
            textBoxfromaccounid.Name = "textBoxfromaccounid";
            textBoxfromaccounid.Size = new Size(181, 23);
            textBoxfromaccounid.TabIndex = 3;
            textBoxfromaccounid.TextChanged += textBoxfromaccounid_TextChanged;
            // 
            // labelfromaccountid
            // 
            labelfromaccountid.AutoSize = true;
            labelfromaccountid.Location = new Point(8, 83);
            labelfromaccountid.Margin = new Padding(4, 0, 4, 0);
            labelfromaccountid.Name = "labelfromaccountid";
            labelfromaccountid.Size = new Size(101, 15);
            labelfromaccountid.TabIndex = 2;
            labelfromaccountid.Text = "From_Account_ID";
            labelfromaccountid.Click += labelfromaccountid_Click;
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(126, 33);
            textBoxid.Margin = new Padding(4, 3, 4, 3);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(181, 23);
            textBoxid.TabIndex = 1;
            textBoxid.TextChanged += textBoxid_TextChanged;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(91, 41);
            labelid.Margin = new Padding(4, 0, 4, 0);
            labelid.Name = "labelid";
            labelid.Size = new Size(18, 15);
            labelid.TabIndex = 0;
            labelid.Text = "ID";
            labelid.Click += labelid_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 264);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(759, 160);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlDark;
            close.Location = new Point(740, 430);
            close.Margin = new Padding(4, 3, 4, 3);
            close.Name = "close";
            close.Size = new Size(88, 27);
            close.TabIndex = 5;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 31);
            label1.TabIndex = 8;
            label1.Text = "Transaction INFORMATION";
            // 
            // save
            // 
            save.BackColor = SystemColors.GradientInactiveCaption;
            save.Location = new Point(607, 430);
            save.Margin = new Padding(4, 3, 4, 3);
            save.Name = "save";
            save.Size = new Size(88, 27);
            save.TabIndex = 9;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(469, 430);
            Delete.Margin = new Padding(4, 3, 4, 3);
            Delete.Name = "Delete";
            Delete.Size = new Size(88, 27);
            Delete.TabIndex = 10;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(255, 192, 192);
            Edit.Location = new Point(888, 316);
            Edit.Margin = new Padding(4, 3, 4, 3);
            Edit.Name = "Edit";
            Edit.Size = new Size(88, 27);
            Edit.TabIndex = 11;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Resert
            // 
            Resert.BackColor = Color.FromArgb(255, 192, 192);
            Resert.Location = new Point(888, 365);
            Resert.Margin = new Padding(4, 3, 4, 3);
            Resert.Name = "Resert";
            Resert.Size = new Size(88, 27);
            Resert.TabIndex = 12;
            Resert.Text = "Resert";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // _Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 519);
            Controls.Add(Resert);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(save);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "_Transaction";
            Text = "_Transaction";
            WindowState = FormWindowState.Maximized;
            Load += _Transaction_Load_2;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankSystemDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelfromaccountid;
        private System.Windows.Forms.TextBox textBoxfromaccounid;
        private System.Windows.Forms.Label labelbranchid;
        private System.Windows.Forms.TextBox textBoxbranchid;
        private System.Windows.Forms.Label labeldateoftrans;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.TextBox textdatoftrans;
        private System.Windows.Forms.TextBox textBoxamount;
        private System.Windows.Forms.Label labelpin;
        private System.Windows.Forms.TextBox textBoxpin;
        private System.Windows.Forms.Label labeltoaccountid;
        private System.Windows.Forms.TextBox textBoxtoaccountid;
        private System.Windows.Forms.Label labelemployeeid;
        private System.Windows.Forms.TextBox textBoxemployeeid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
        private Label label1;
        private Button save;
        private Button Delete;
        private Button Edit;
        private Button Resert;
    }
}