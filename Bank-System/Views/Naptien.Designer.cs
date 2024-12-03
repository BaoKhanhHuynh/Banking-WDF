namespace Bank_System.Views
{
    partial class Naptien
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
            tengiaodich = new TextBox();
            label2 = new Label();
            sotien = new TextBox();
            dataGridView1 = new DataGridView();
            close = new Button();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 14;
            label1.Text = "Tên giao dịch";
            // 
            // tengiaodich
            // 
            tengiaodich.Location = new Point(317, 103);
            tengiaodich.Margin = new Padding(4, 3, 4, 3);
            tengiaodich.Name = "tengiaodich";
            tengiaodich.Size = new Size(181, 23);
            tengiaodich.TabIndex = 22;
            tengiaodich.TextChanged += tengiaodich_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 23;
            label2.Text = "Số tiền";
            // 
            // sotien
            // 
            sotien.Location = new Point(317, 152);
            sotien.Margin = new Padding(4, 3, 4, 3);
            sotien.Name = "sotien";
            sotien.Size = new Size(181, 23);
            sotien.TabIndex = 24;
            sotien.TextChanged += sotien_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(221, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(454, 150);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // close
            // 
            close.BackColor = SystemColors.ControlDark;
            close.Location = new Point(480, 386);
            close.Margin = new Padding(4, 3, 4, 3);
            close.Name = "close";
            close.Size = new Size(88, 27);
            close.TabIndex = 26;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 28);
            label3.Name = "label3";
            label3.Size = new Size(309, 31);
            label3.TabIndex = 27;
            label3.Text = "Deposit INFORMATION";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(352, 386);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 28;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Naptien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            Controls.Add(sotien);
            Controls.Add(label2);
            Controls.Add(tengiaodich);
            Controls.Add(label1);
            Name = "Naptien";
            Text = "Naptien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tengiaodich;
        private Label label2;
        private TextBox sotien;
        private DataGridView dataGridView1;
        private Button close;
        private Label label3;
        private Button button1;
    }
}