﻿using DataAccess;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text;
            string password = txtPassword.Text;

            try
            {
                if (email.Length > 0 && password.Length > 0)
                {
                    Login login = new Login();
                    string role = login.CheckLogin(email, password);

                    if (role == "Admin")
                    {
                        MessageBox.Show("Login successfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new MainForm().Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login failed...");
            }

        }
    }
}
