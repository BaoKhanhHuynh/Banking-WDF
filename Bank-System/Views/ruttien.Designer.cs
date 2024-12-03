namespace Bank_System.Views
{
    partial class ruttien
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
            label1 = new Label();
            label2 = new Label();
            tengiaodich = new TextBox();
            sotien = new TextBox();
            dataGridView1 = new DataGridView();
            close = new Button();
            label3 = new Label();
            ruttientxt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 13;
            label1.Text = "Tên giao dịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 14;
            label2.Text = "Số tiền";
            // 
            // tengiaodich
            // 
            tengiaodich.Location = new Point(277, 88);
            tengiaodich.Margin = new Padding(4, 3, 4, 3);
            tengiaodich.Name = "tengiaodich";
            tengiaodich.Size = new Size(181, 23);
            tengiaodich.TabIndex = 21;
            tengiaodich.TextChanged += tengiaodich_TextChanged;
            // 
            // sotien
            // 
            sotien.Location = new Point(277, 133);
            sotien.Margin = new Padding(4, 3, 4, 3);
            sotien.Name = "sotien";
            sotien.Size = new Size(181, 23);
            sotien.TabIndex = 22;
            sotien.TextChanged += sotien_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(525, 150);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlDark;
            close.Location = new Point(482, 374);
            close.Margin = new Padding(4, 3, 4, 3);
            close.Name = "close";
            close.Size = new Size(88, 27);
            close.TabIndex = 24;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 22);
            label3.Name = "label3";
            label3.Size = new Size(340, 31);
            label3.TabIndex = 25;
            label3.Text = "Withdraw INFORMATION";
            label3.Click += label3_Click;
            // 
            // ruttientxt
            // 
            ruttientxt.BackColor = SystemColors.ControlDark;
            ruttientxt.Location = new Point(346, 374);
            ruttientxt.Margin = new Padding(4, 3, 4, 3);
            ruttientxt.Name = "ruttientxt";
            ruttientxt.Size = new Size(88, 27);
            ruttientxt.TabIndex = 26;
            ruttientxt.Text = "Withdraw";
            ruttientxt.UseVisualStyleBackColor = false;
            ruttientxt.Click += ruttientxt_Click;
            // 
            // ruttien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ruttientxt);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            Controls.Add(sotien);
            Controls.Add(tengiaodich);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ruttien";
            Text = "ruttien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tengiaodich;
        private TextBox sotien;
        private DataGridView dataGridView1;
        private Button close;
        private Label label3;
        private Button ruttientxt;
    }
}