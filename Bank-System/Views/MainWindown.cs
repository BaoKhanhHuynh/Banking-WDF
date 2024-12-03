using Bank_System.Models;
using Bank_System.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    public partial class MainWindown : Form
    {
        public MainWindown()
        {
            InitializeComponent();
        }

        private void MainWindown_Load(object sender, EventArgs e)
        {

        }

        private void rmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeView epl = new EmployeeView();
            epl.ShowDialog();

        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer ctm = new Customer();
            ctm.ShowDialog();
        }

        //private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Account account = new Account();
        //    account.ShowDialog();
        //}

        //private void balanceAccountToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Account account = new Account();
        //    account.ShowDialog();
        //}

        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Transaction tran = new _Transaction();
            tran.ShowDialog();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranchView br = new BranchView();
            br.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }


        private void accountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountView account = new AccountView();
            account.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Transaction transaction = new _Transaction();
            transaction.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountView account = new AccountView();
            account.ShowDialog();
        }

        private void transactionAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyentien ct = new chuyentien();
            ct.ShowDialog();
        }

        private void withdrawAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruttien rt = new ruttien();
            rt.ShowDialog();
        }

        private void depositAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Naptien nt = new Naptien();
            nt.ShowDialog();
        }
    }
}
 