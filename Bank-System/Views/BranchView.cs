using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bank_System.Controllers;
using Bank_System.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;

namespace Bank_System.Views
{
    public partial class BranchView : Form
    {
        private BranchController controller;

        public BranchView()
        {
            InitializeComponent();
            controller = new BranchController();

        }

        public void LoadData()

        {
            tid.Enabled = true;
            controller.Load(); // Load lại dữ liệu từ cơ sở dữ liệu
            dataGridView1.DataSource = null; // Xóa dữ liệu hiện tại
            dataGridView1.DataSource = controller.Items; // Thiết lập lại nguồn dữ liệu mới
        }

        private void BranchView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
        //    {
        //        MessageBox.Show("No row is selected. Please select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    int i = dataGridView1.CurrentRow.Index;
        //    tid.Text = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? string.Empty;
        //    tname.Text = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? string.Empty;
        //    thouseno.Text = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? string.Empty;
        //    tcity.Text = dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? string.Empty;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không có hàng nào được chọn hoặc CurrentRow là null
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("No row is selected. Please select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = dataGridView1.CurrentRow.Index;

            // Kiểm tra và gán dữ liệu từ các ô trong hàng hiện tại
            tid.Text = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? string.Empty;
            tname.Text = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? string.Empty;
            thouseno.Text = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? string.Empty;
            tcity.Text = dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? string.Empty;

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new Branch
            {
                Id = tid.Text,
                Name = tname.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text
            };

            if (controller.Create(model))
            {
                MessageBox.Show("Branch added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add branch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var model = new Branch
            {
                Id = tid.Text,
                Name = tname.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tname.Text = "";
            thouseno.Text = "";
            tcity.Text = "";
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            var model = new Branch
            {
                Id = tid.Text,
                Name = tname.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            var model = new Branch
            {
                Id = tid.Text,
                Name = tname.Text,
                HouseNo = thouseno.Text,
                City = tcity.Text
            };

            if (controller.Create(model))
            {
                MessageBox.Show("Branch added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
            }
            else
            {
                MessageBox.Show("Failed to add branch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            string id = tid.Text;
            controller.Delete(id);
            LoadData();
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tname.Text = "";
            thouseno.Text = "";
            tcity.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
