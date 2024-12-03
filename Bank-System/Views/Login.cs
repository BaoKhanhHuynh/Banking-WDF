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
using WindowsFormsApp1;

namespace Bank_System.Views
{
    public partial class Login : Form
    {
        private readonly EmployeeController employeeController = new EmployeeController();
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = employeeController.Login(textBox2.Text, textBox1.Text);
            MainWindown main = new MainWindown();
            if (result) { main.ShowDialog(); Close(); }
            else
            {
                MessageBox.Show("Name and password incorrect!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
