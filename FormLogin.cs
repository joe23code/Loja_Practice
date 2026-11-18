using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Practice
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private readonly User users;

        public FormLogin(User registeredUser)
        {
            InitializeComponent();
            users = registeredUser;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "xzheb" &&  txtPassword.Text == "12345")
            {
                MessageBox.Show("NAKAPASOK KA SA BAHAY NI KUYA");
                var inventoryForm = new FormInventory();
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ikaw ay nominado");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp FormSignUp = new FormSignUp();
            FormSignUp.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =  ! cbxPassword.Checked;
        }
    }
}
