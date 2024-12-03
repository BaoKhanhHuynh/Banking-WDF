using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
using Bank_System.Controllers;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Views
{
    public partial class AccountView : Form
    {
        private AccountController controller;

        public AccountView()
        {
            controller = new AccountController();
            InitializeComponent();
        }

        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void Date_Opened_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdateopened_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tcustomerid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tdateopened.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbalance.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void tcustomerid_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Account_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(tid.Text) ? Convert.ToInt32(tid.Text) : 0;
            string customerId = tcustomerid.Text ?? string.Empty;
            DateTime dateOpened = DateTime.TryParse(tdateopened.Text, out DateTime tempDateOpened) ? tempDateOpened : DateTime.MinValue;
            double balance = double.TryParse(tbalance.Text, out double tempBalance) ? tempBalance : 0.0;

            // Tạo một đối tượng Account mới
            var model = new Bank_System.Models.Account(id, customerId, dateOpened, balance);

            if (controller.Update(model))
            {
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update Account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(tid.Text) ? Convert.ToInt32(tid.Text) : 0;
            string customerId = tcustomerid.Text ?? string.Empty;
            DateTime dateOpened = DateTime.TryParse(tdateopened.Text, out DateTime tempDateOpened) ? tempDateOpened : DateTime.MinValue;
            double balance = double.TryParse(tbalance.Text, out double tempBalance) ? tempBalance : 0.0;

            // Khởi tạo model với constructor
            var model = new Bank_System.Models.Account(id, customerId, dateOpened, balance);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("Account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add Account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resert_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tcustomerid.Text = "";
            tdateopened.Text = "";
            tbalance.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(tid.Text) ? Convert.ToInt32(tid.Text) : 0;
            if (controller.Delete(id))
            {
                MessageBox.Show("Branch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi xóa
            }
            else
            {
                MessageBox.Show("Failed to delete branch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
