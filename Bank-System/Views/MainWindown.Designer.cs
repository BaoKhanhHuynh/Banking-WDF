namespace WindowsFormsApp1
{
    partial class MainWindown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindown));
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuidToolStripMenuItem = new ToolStripMenuItem();
            transactionLogToolStripMenuItem = new ToolStripMenuItem();
            balanceAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionAmountToolStripMenuItem = new ToolStripMenuItem();
            withdrawAmountToolStripMenuItem = new ToolStripMenuItem();
            depositAmountToolStripMenuItem = new ToolStripMenuItem();
            createAccountToolStripMenuItem = new ToolStripMenuItem();
            createCustomerToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            rmployeeToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            bankingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(125, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuidToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuidToolStripMenuItem
            // 
            userGuidToolStripMenuItem.Name = "userGuidToolStripMenuItem";
            userGuidToolStripMenuItem.Size = new Size(125, 22);
            userGuidToolStripMenuItem.Text = "User Guid";
            // 
            // transactionLogToolStripMenuItem
            // 
            transactionLogToolStripMenuItem.Name = "transactionLogToolStripMenuItem";
            transactionLogToolStripMenuItem.Size = new Size(181, 22);
            transactionLogToolStripMenuItem.Text = "Transaction Log";
            transactionLogToolStripMenuItem.Click += transactionLogToolStripMenuItem_Click;
            // 
            // balanceAccountToolStripMenuItem
            // 
            balanceAccountToolStripMenuItem.Name = "balanceAccountToolStripMenuItem";
            balanceAccountToolStripMenuItem.Size = new Size(181, 22);
            balanceAccountToolStripMenuItem.Text = "Balance Account";
            // 
            // transactionAmountToolStripMenuItem
            // 
            transactionAmountToolStripMenuItem.Name = "transactionAmountToolStripMenuItem";
            transactionAmountToolStripMenuItem.Size = new Size(181, 22);
            transactionAmountToolStripMenuItem.Text = "Transaction Amount";
            transactionAmountToolStripMenuItem.Click += transactionAmountToolStripMenuItem_Click;
            // 
            // withdrawAmountToolStripMenuItem
            // 
            withdrawAmountToolStripMenuItem.Name = "withdrawAmountToolStripMenuItem";
            withdrawAmountToolStripMenuItem.Size = new Size(181, 22);
            withdrawAmountToolStripMenuItem.Text = "Withdraw Amount";
            withdrawAmountToolStripMenuItem.Click += withdrawAmountToolStripMenuItem_Click;
            // 
            // depositAmountToolStripMenuItem
            // 
            depositAmountToolStripMenuItem.Name = "depositAmountToolStripMenuItem";
            depositAmountToolStripMenuItem.Size = new Size(181, 22);
            depositAmountToolStripMenuItem.Text = "Deposit Amount";
            depositAmountToolStripMenuItem.Click += depositAmountToolStripMenuItem_Click;
            // 
            // createAccountToolStripMenuItem
            // 
            createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            createAccountToolStripMenuItem.Size = new Size(181, 22);
            createAccountToolStripMenuItem.Text = "Create Account";
            createAccountToolStripMenuItem.Click += createAccountToolStripMenuItem_Click;
            // 
            // createCustomerToolStripMenuItem
            // 
            createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            createCustomerToolStripMenuItem.Size = new Size(181, 22);
            createCustomerToolStripMenuItem.Text = "Create Customer";
            createCustomerToolStripMenuItem.Click += createCustomerToolStripMenuItem_Click;
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.ImageAlign = ContentAlignment.BottomRight;
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(139, 22);
            branchToolStripMenuItem.Text = "Branch";
            branchToolStripMenuItem.Click += branchToolStripMenuItem_Click;
            // 
            // rmployeeToolStripMenuItem
            // 
            rmployeeToolStripMenuItem.Name = "rmployeeToolStripMenuItem";
            rmployeeToolStripMenuItem.Size = new Size(139, 22);
            rmployeeToolStripMenuItem.Text = "Employee";
            rmployeeToolStripMenuItem.Click += rmployeeToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rmployeeToolStripMenuItem, branchToolStripMenuItem, customerToolStripMenuItem, accountToolStripMenuItem, transactionToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(57, 20);
            systemToolStripMenuItem.Text = "System";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(139, 22);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(139, 22);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click_1;
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(139, 22);
            transactionToolStripMenuItem.Text = "_Transaction";
            transactionToolStripMenuItem.Click += transactionToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(112, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // bankingToolStripMenuItem
            // 
            bankingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createCustomerToolStripMenuItem, createAccountToolStripMenuItem, depositAmountToolStripMenuItem, withdrawAmountToolStripMenuItem, transactionAmountToolStripMenuItem, balanceAccountToolStripMenuItem, transactionLogToolStripMenuItem });
            bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            bankingToolStripMenuItem.Size = new Size(62, 20);
            bankingToolStripMenuItem.Text = "Banking";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, bankingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(933, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Bank_System.Properties.Resources.R__1_;
            pictureBox1.Location = new Point(98, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(727, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainWindown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainWindown";
            Text = "MainWindown";
            WindowState = FormWindowState.Maximized;
            Load += MainWindown_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem userGuidToolStripMenuItem;
        private ToolStripMenuItem transactionLogToolStripMenuItem;
        private ToolStripMenuItem balanceAccountToolStripMenuItem;
        private ToolStripMenuItem transactionAmountToolStripMenuItem;
        private ToolStripMenuItem withdrawAmountToolStripMenuItem;
        private ToolStripMenuItem depositAmountToolStripMenuItem;
        private ToolStripMenuItem createAccountToolStripMenuItem;
        private ToolStripMenuItem createCustomerToolStripMenuItem;
        private ToolStripMenuItem branchToolStripMenuItem;
        private ToolStripMenuItem rmployeeToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem bankingToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripProgressBar toolStripProgressBar1;
        private PictureBox pictureBox1;
    }
}