using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_System.Controllers;
using Bank_System.Models;

namespace Bank_System.Views
{
    public partial class chuyentien : Form
    {
        private _TransactionController controller = new _TransactionController();

        public chuyentien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }

        private void transfer_Click(object sender, EventArgs e)

        {
            var model = new Bank_System.Models.Transaction(int.Parse(id.Text), int.Parse(idnguoiguitxt.Text), "", DateTime.Now, int.Parse(sotien.Text), "", int.Parse(idnguoinhan.Text), "");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
