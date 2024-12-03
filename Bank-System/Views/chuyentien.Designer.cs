namespace Bank_System.Views
{
    partial class chuyentien
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
            label3 = new Label();
            labelfromaccountid = new Label();
            nguoigui = new Label();
            label2 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            close = new Button();
            id = new TextBox();
            sotien = new TextBox();
            idnguoinhan = new TextBox();
            transfer = new Button();
            idnguoigui = new Label();
            idnguoiguitxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(225, 25);
            label3.Name = "label3";
            label3.Size = new Size(321, 31);
            label3.TabIndex = 10;
            label3.Text = "Transfer INFORMATION";
            // 
            // labelfromaccountid
            // 
            labelfromaccountid.AutoSize = true;
            labelfromaccountid.Location = new Point(69, 81);
            labelfromaccountid.Margin = new Padding(4, 0, 4, 0);
            labelfromaccountid.Name = "labelfromaccountid";
            labelfromaccountid.Size = new Size(0, 15);
            labelfromaccountid.TabIndex = 11;
            // 
            // nguoigui
            // 
            nguoigui.AutoSize = true;
            nguoigui.Location = new Point(69, 81);
            nguoigui.Margin = new Padding(4, 0, 4, 0);
            nguoigui.Name = "nguoigui";
            nguoigui.Size = new Size(18, 15);
            nguoigui.TabIndex = 12;
            nguoigui.Text = "ID";
            nguoigui.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 13;
            label2.Text = "Số tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 14;
            label4.Text = "ID người thụ hưởng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(140, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 150);
            dataGridView1.TabIndex = 18;
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlDark;
            close.Location = new Point(557, 401);
            close.Margin = new Padding(4, 3, 4, 3);
            close.Name = "close";
            close.Size = new Size(88, 27);
            close.TabIndex = 19;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // id
            // 
            id.Location = new Point(205, 73);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Name = "id";
            id.Size = new Size(181, 23);
            id.TabIndex = 20;
            // 
            // sotien
            // 
            sotien.Location = new Point(205, 121);
            sotien.Margin = new Padding(4, 3, 4, 3);
            sotien.Name = "sotien";
            sotien.Size = new Size(181, 23);
            sotien.TabIndex = 21;
            // 
            // idnguoinhan
            // 
            idnguoinhan.Location = new Point(205, 167);
            idnguoinhan.Margin = new Padding(4, 3, 4, 3);
            idnguoinhan.Name = "idnguoinhan";
            idnguoinhan.Size = new Size(181, 23);
            idnguoinhan.TabIndex = 22;
            // 
            // transfer
            // 
            transfer.BackColor = SystemColors.ControlDark;
            transfer.Location = new Point(416, 401);
            transfer.Margin = new Padding(4, 3, 4, 3);
            transfer.Name = "transfer";
            transfer.Size = new Size(88, 27);
            transfer.TabIndex = 23;
            transfer.Text = "Transfer";
            transfer.UseVisualStyleBackColor = false;
            transfer.Click += transfer_Click;
            // 
            // idnguoigui
            // 
            idnguoigui.AutoSize = true;
            idnguoigui.Location = new Point(69, 213);
            idnguoigui.Margin = new Padding(4, 0, 4, 0);
            idnguoigui.Name = "idnguoigui";
            idnguoigui.Size = new Size(72, 15);
            idnguoigui.TabIndex = 24;
            idnguoigui.Text = "ID nguoi gui";
            idnguoigui.UseMnemonic = false;
            idnguoigui.Click += label1_Click;
            // 
            // idnguoiguitxt
            // 
            idnguoiguitxt.Location = new Point(205, 213);
            idnguoiguitxt.Margin = new Padding(4, 3, 4, 3);
            idnguoiguitxt.Name = "idnguoiguitxt";
            idnguoiguitxt.Size = new Size(181, 23);
            idnguoiguitxt.TabIndex = 25;
            idnguoiguitxt.TextChanged += textBox1_TextChanged;
            // 
            // chuyentien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idnguoiguitxt);
            Controls.Add(idnguoigui);
            Controls.Add(transfer);
            Controls.Add(idnguoinhan);
            Controls.Add(sotien);
            Controls.Add(id);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(nguoigui);
            Controls.Add(labelfromaccountid);
            Controls.Add(label3);
            Name = "chuyentien";
            Text = "chuyentien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label labelfromaccountid;
        private Label nguoigui;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private Button close;
        private TextBox id;
        private TextBox sotien;
        private TextBox idnguoinhan;
        private Button transfer;
        private Label idnguoigui;
        private TextBox idnguoiguitxt;
    }
}