using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_System.Controllers;
using Bank_System.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        private CustomerController controller;

        public Customer()
        {
            controller = new CustomerController();
            InitializeComponent();
        }

        public void LoadData()
        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lid_Click(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void lphone_Click(object sender, EventArgs e)
        {

        }

        private void lemail_Click(object sender, EventArgs e)
        {

        }

        private void lhouseno_Click(object sender, EventArgs e)
        {

        }

        private void lcity_Click(object sender, EventArgs e)
        {

        }

        private void lpin_Click(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void temail_TextChanged(object sender, EventArgs e)
        {

        }

        private void thouseno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tphone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            temail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            thouseno.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tcity.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            tpin.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu vào DataGridView nếu kết nối thành công
        }

        private void delete_Click(object sender, EventArgs e)
        {

            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var model = new Bank_System.Models.Customer
            {
                Id = tid.Text,
                Name = tname.Text,
                Phone = tphone.Text,
                Email = temail.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text,
                Pin = tpin.Text
            };

            // Gọi phương thức Create để thêm mới nhân viên
            if (controller.Create(model))
            {
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add Customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            var model = new Bank_System.Models.Customer
            {
                Id = tid.Text,
                Name = tname.Text,
                Phone = tphone.Text,
                Email = temail.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text,
                Pin = tpin.Text
            };

            if (controller.Update(model))
            {
                MessageBox.Show("Branch updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update branch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resert_Click(object sender, EventArgs e)
        {
            {
                tid.Text = "";
                tname.Text = "";
                tphone.Text = "";
                temail.Text = "";
                thouseno.Text = "";
                tcity.Text = "";
                tpin.Text = "";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
