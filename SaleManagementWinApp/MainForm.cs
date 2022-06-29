using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMemberForm().Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            frmLogin frmLogin = new frmLogin();
            MainForm frmMain = new MainForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmMain.Hide();
                frmLogin.Show();
            }
        }
    }
}
