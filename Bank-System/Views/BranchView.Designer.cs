namespace Bank_System.Views
{
    partial class BranchView
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
            House_No = new Label();
            name = new Label();
            ID = new Label();
            groupBox1 = new GroupBox();
            tcity = new TextBox();
            thouseno = new TextBox();
            tname = new TextBox();
            tid = new TextBox();
            City = new Label();
            buttonResert = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonSave = new Button();
            buttonClose = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // House_No
            // 
            House_No.AutoSize = true;
            House_No.Location = new Point(271, 25);
            House_No.Margin = new Padding(4, 0, 4, 0);
            House_No.Name = "House_No";
            House_No.Size = new Size(62, 15);
            House_No.TabIndex = 2;
            House_No.Text = "House_No";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(2, 65);
            name.Margin = new Padding(4, 0, 4, 0);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(8, 30);
            ID.Margin = new Padding(4, 0, 4, 0);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 0;
            ID.Text = "ID";
            ID.Click += ID_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkKhaki;
            groupBox1.Controls.Add(tcity);
            groupBox1.Controls.Add(thouseno);
            groupBox1.Controls.Add(tname);
            groupBox1.Controls.Add(tid);
            groupBox1.Controls.Add(City);
            groupBox1.Controls.Add(House_No);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(ID);
            groupBox1.Location = new Point(123, 72);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(547, 123);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tcity
            // 
            tcity.Location = new Point(354, 62);
            tcity.Margin = new Padding(4, 3, 4, 3);
            tcity.Name = "tcity";
            tcity.Size = new Size(162, 23);
            tcity.TabIndex = 7;
            // 
            // thouseno
            // 
            thouseno.Location = new Point(354, 22);
            thouseno.Margin = new Padding(4, 3, 4, 3);
            thouseno.Name = "thouseno";
            thouseno.Size = new Size(162, 23);
            thouseno.TabIndex = 6;
            // 
            // tname
            // 
            tname.Location = new Point(49, 62);
            tname.Margin = new Padding(4, 3, 4, 3);
            tname.Name = "tname";
            tname.Size = new Size(162, 23);
            tname.TabIndex = 5;
            // 
            // tid
            // 
            tid.Location = new Point(49, 22);
            tid.Margin = new Padding(4, 3, 4, 3);
            tid.Name = "tid";
            tid.Size = new Size(162, 23);
            tid.TabIndex = 4;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(305, 65);
            City.Margin = new Padding(4, 0, 4, 0);
            City.Name = "City";
            City.Size = new Size(28, 15);
            City.TabIndex = 3;
            City.Text = "City";
            // 
            // buttonResert
            // 
            buttonResert.BackColor = Color.FromArgb(255, 192, 192);
            buttonResert.Location = new Point(600, 297);
            buttonResert.Margin = new Padding(4, 3, 4, 3);
            buttonResert.Name = "buttonResert";
            buttonResert.Size = new Size(88, 27);
            buttonResert.TabIndex = 17;
            buttonResert.Text = "Resert";
            buttonResert.UseVisualStyleBackColor = false;
            buttonResert.Click += buttonResert_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(142, 361);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(88, 27);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 192, 192);
            buttonEdit.Location = new Point(600, 249);
            buttonEdit.Margin = new Padding(4, 3, 4, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(88, 27);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.GradientInactiveCaption;
            buttonSave.Location = new Point(314, 361);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 27);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ControlDark;
            buttonClose.Location = new Point(477, 361);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(88, 27);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 212);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 143);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 27);
            label1.Name = "label1";
            label1.Size = new Size(306, 31);
            label1.TabIndex = 18;
            label1.Text = "Branch INFORMATION";
            // 
            // BranchView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(buttonResert);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSave);
            Controls.Add(buttonClose);
            Controls.Add(dataGridView1);
            Name = "BranchView";
            Text = "BranchView";
            Load += BranchView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label House_No;
        private Label name;
        private Label ID;
        private GroupBox groupBox1;
        private TextBox tcity;
        private TextBox thouseno;
        private TextBox tname;
        private TextBox tid;
        private Label City;
        private Button buttonResert;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonSave;
        private Button buttonClose;
        private DataGridView dataGridView1;
        private Label label1;
    }
}