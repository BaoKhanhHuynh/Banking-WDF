namespace WindowsFormsApp1
{
    partial class Customer
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
            close = new Button();
            Resert = new Button();
            edit = new Button();
            save = new Button();
            delete = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lid = new Label();
            lname = new Label();
            lphone = new Label();
            lemail = new Label();
            lhouseno = new Label();
            lcity = new Label();
            lpin = new Label();
            tid = new TextBox();
            tname = new TextBox();
            tphone = new TextBox();
            temail = new TextBox();
            thouseno = new TextBox();
            tcity = new TextBox();
            tpin = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlDarkDark;
            close.Location = new Point(706, 436);
            close.Margin = new Padding(4, 3, 4, 3);
            close.Name = "close";
            close.Size = new Size(88, 27);
            close.TabIndex = 9;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Resert
            // 
            Resert.BackColor = Color.FromArgb(255, 192, 192);
            Resert.Location = new Point(706, 173);
            Resert.Margin = new Padding(4, 3, 4, 3);
            Resert.Name = "Resert";
            Resert.Size = new Size(88, 27);
            Resert.TabIndex = 8;
            Resert.Text = "Resert";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 192, 192);
            edit.Location = new Point(706, 112);
            edit.Margin = new Padding(4, 3, 4, 3);
            edit.Name = "edit";
            edit.Size = new Size(88, 27);
            edit.TabIndex = 7;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.InactiveCaption;
            save.Location = new Point(583, 436);
            save.Margin = new Padding(4, 3, 4, 3);
            save.Name = "save";
            save.Size = new Size(88, 27);
            save.TabIndex = 6;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Location = new Point(453, 436);
            delete.Margin = new Padding(4, 3, 4, 3);
            delete.Name = "delete";
            delete.Size = new Size(88, 27);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lid
            // 
            lid.AutoSize = true;
            lid.Location = new Point(21, 35);
            lid.Margin = new Padding(4, 0, 4, 0);
            lid.Name = "lid";
            lid.Size = new Size(18, 15);
            lid.TabIndex = 0;
            lid.Text = "ID";
            lid.Click += lid_Click;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(18, 70);
            lname.Margin = new Padding(4, 0, 4, 0);
            lname.Name = "lname";
            lname.Size = new Size(39, 15);
            lname.TabIndex = 1;
            lname.Text = "Name";
            lname.Click += lname_Click;
            // 
            // lphone
            // 
            lphone.AutoSize = true;
            lphone.Location = new Point(21, 103);
            lphone.Margin = new Padding(4, 0, 4, 0);
            lphone.Name = "lphone";
            lphone.Size = new Size(41, 15);
            lphone.TabIndex = 2;
            lphone.Text = "Phone";
            lphone.Click += lphone_Click;
            // 
            // lemail
            // 
            lemail.AutoSize = true;
            lemail.Location = new Point(231, 30);
            lemail.Margin = new Padding(4, 0, 4, 0);
            lemail.Name = "lemail";
            lemail.Size = new Size(36, 15);
            lemail.TabIndex = 3;
            lemail.Text = "Email";
            lemail.Click += lemail_Click;
            // 
            // lhouseno
            // 
            lhouseno.AutoSize = true;
            lhouseno.Location = new Point(205, 65);
            lhouseno.Margin = new Padding(4, 0, 4, 0);
            lhouseno.Name = "lhouseno";
            lhouseno.Size = new Size(62, 15);
            lhouseno.TabIndex = 4;
            lhouseno.Text = "House_No";
            lhouseno.Click += lhouseno_Click;
            // 
            // lcity
            // 
            lcity.AutoSize = true;
            lcity.Location = new Point(231, 97);
            lcity.Margin = new Padding(4, 0, 4, 0);
            lcity.Name = "lcity";
            lcity.Size = new Size(28, 15);
            lcity.TabIndex = 5;
            lcity.Text = "City";
            lcity.Click += lcity_Click;
            // 
            // lpin
            // 
            lpin.AutoSize = true;
            lpin.Location = new Point(235, 133);
            lpin.Margin = new Padding(4, 0, 4, 0);
            lpin.Name = "lpin";
            lpin.Size = new Size(24, 15);
            lpin.TabIndex = 6;
            lpin.Text = "Pin";
            lpin.Click += lpin_Click;
            // 
            // tid
            // 
            tid.Location = new Point(70, 27);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(133, 23);
            tid.TabIndex = 7;
            tid.TextChanged += tid_TextChanged;
            // 
            // tname
            // 
            tname.Location = new Point(70, 62);
            tname.Margin = new Padding(4, 3, 4, 3);
            tname.Name = "tname";
            tname.Size = new Size(133, 23);
            tname.TabIndex = 8;
            tname.TextChanged += tname_TextChanged;
            // 
            // tphone
            // 
            tphone.Location = new Point(70, 103);
            tphone.Margin = new Padding(4, 3, 4, 3);
            tphone.Name = "tphone";
            tphone.Size = new Size(133, 23);
            tphone.TabIndex = 9;
            tphone.TextChanged += tphone_TextChanged;
            // 
            // temail
            // 
            temail.Location = new Point(275, 27);
            temail.Margin = new Padding(4, 3, 4, 3);
            temail.Name = "temail";
            temail.Size = new Size(133, 23);
            temail.TabIndex = 10;
            temail.TextChanged += temail_TextChanged;
            // 
            // thouseno
            // 
            thouseno.Location = new Point(274, 57);
            thouseno.Margin = new Padding(4, 3, 4, 3);
            thouseno.Name = "thouseno";
            thouseno.Size = new Size(134, 23);
            thouseno.TabIndex = 11;
            thouseno.TextChanged += thouseno_TextChanged;
            // 
            // tcity
            // 
            tcity.Location = new Point(274, 90);
            tcity.Margin = new Padding(4, 3, 4, 3);
            tcity.Name = "tcity";
            tcity.Size = new Size(133, 23);
            tcity.TabIndex = 12;
            tcity.TextChanged += tcity_TextChanged;
            // 
            // tpin
            // 
            tpin.Location = new Point(275, 130);
            tpin.Margin = new Padding(4, 3, 4, 3);
            tpin.Name = "tpin";
            tpin.Size = new Size(134, 23);
            tpin.TabIndex = 13;
            tpin.TextChanged += tpin_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GreenYellow;
            groupBox1.Controls.Add(tpin);
            groupBox1.Controls.Add(tcity);
            groupBox1.Controls.Add(thouseno);
            groupBox1.Controls.Add(temail);
            groupBox1.Controls.Add(tphone);
            groupBox1.Controls.Add(tname);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(lpin);
            groupBox1.Controls.Add(lcity);
            groupBox1.Controls.Add(lhouseno);
            groupBox1.Controls.Add(lemail);
            groupBox1.Controls.Add(lphone);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(lid);
            groupBox1.Location = new Point(118, 47);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(531, 174);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 227);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 203);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 31);
            label1.TabIndex = 19;
            label1.Text = "Customer INFORMATION";
            label1.Click += label1_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(Resert);
            Controls.Add(edit);
            Controls.Add(save);
            Controls.Add(delete);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close;
        private Button Resert;
        private Button edit;
        private Button save;
        private Button delete;
        private ContextMenuStrip contextMenuStrip1;
        private Label lid;
        private Label lname;
        private Label lphone;
        private Label lemail;
        private Label lhouseno;
        private Label lcity;
        private Label lpin;
        private TextBox tid;
        private TextBox tname;
        private TextBox tphone;
        private TextBox temail;
        private TextBox thouseno;
        private TextBox tcity;
        private TextBox tpin;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}