using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Bank_System.Controllers;
using Bank_System.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class _Transaction : Form
    {
        private _TransactionController controller;

        public _Transaction()
        {
            controller = new _TransactionController();
            InitializeComponent();
        }

        public void LoadData()
        {
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }

        private void labelid_Click(object sender, EventArgs e)
        {
            // load thêm groupBox (note)
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelfromaccountid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxfromaccounid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelbranchid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbranchid_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeldateoftrans_Click(object sender, EventArgs e)
        {

        }

        private void labelamount_Click(object sender, EventArgs e)
        {

        }

        private void textBoxamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelpin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeltoaccountid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtoaccountid_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelemployeeid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxemployeeid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdatoftrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBoxid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxfromaccounid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxbranchid.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textdatoftrans.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxamount.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBoxpin.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBoxtoaccountid.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBoxemployeeid.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

        }

        private void _Transaction_Load_2(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu vào DataGridView nếu kết nối thành công  
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(textBoxid.Text) ? Convert.ToInt32(textBoxid.Text) : 0;
            int from_account_id = !string.IsNullOrWhiteSpace(textBoxfromaccounid.Text) ? Convert.ToInt32(textBoxfromaccounid.Text) : 0;
            string branch_id = textBoxbranchid.Text ?? string.Empty;
            DateTime date_of_trans = DateTime.TryParse(textdatoftrans.Text, out DateTime temptextdatoftrans) ? temptextdatoftrans : DateTime.MinValue;
            double amount = double.TryParse(textBoxamount.Text, out double tempAmount) ? tempAmount : 0.0;
            string pin = textBoxpin.Text ?? string.Empty;
            int to_account_id = !string.IsNullOrWhiteSpace(textBoxtoaccountid.Text) ? Convert.ToInt32(textBoxtoaccountid.Text) : 0;
            string employeeid = textBoxemployeeid.Text ?? string.Empty;

            // Khởi tạo model với constructor
            var model = new Bank_System.Models.Transaction(id, from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employeeid);
            LoadData();
            if (controller.Create(model))
            {
                MessageBox.Show("_Transaction added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add _Transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(textBoxid.Text) ? Convert.ToInt32(textBoxid.Text) : 0;
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

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = !string.IsNullOrWhiteSpace(textBoxid.Text) ? Convert.ToInt32(textBoxid.Text) : 0;
            int from_account_id = !string.IsNullOrWhiteSpace(textBoxfromaccounid.Text) ? Convert.ToInt32(textBoxfromaccounid.Text) : 0;
            string branch_id = textBoxbranchid.Text ?? string.Empty;
            DateTime date_of_trans = DateTime.TryParse(textdatoftrans.Text, out DateTime temptextdatoftrans) ? temptextdatoftrans : DateTime.MinValue;
            double amount = double.TryParse(textBoxamount.Text, out double tempAmount) ? tempAmount : 0.0;
            string pin = textBoxpin.Text ?? string.Empty;
            int to_account_id = !string.IsNullOrWhiteSpace(textBoxtoaccountid.Text) ? Convert.ToInt32(textBoxtoaccountid.Text) : 0;
            string employeeid = textBoxemployeeid.Text ?? string.Empty;

            // Tạo một đối tượng Account mới
            var model = new Bank_System.Models.Transaction(id, from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employeeid);

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

        private void Resert_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxfromaccounid.Text = "";
            textBoxbranchid.Text = "";
            textdatoftrans.Text = "";
            textBoxamount.Text = "";
            textBoxpin.Text = "";
            textBoxtoaccountid.Text = "";
            textBoxemployeeid.Text = "";
        }
    }

}
