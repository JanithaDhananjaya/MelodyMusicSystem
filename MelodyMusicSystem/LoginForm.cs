using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d1;
            d1 = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (d1.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPass.Text == "Admin123")
            {
                MessageBox.Show("Valid Username or Passoword");
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                this.Hide();
            }
            else if (txtUser.Text == "User" && txtPass.Text == "User123")
            {
                MessageBox.Show("Valid Username or Passoword");
                // LoadingForm loadingForm = new LoadingForm();
                // loadingForm.Show();
                // this.Hide();
                
                frmStudent fr = new frmStudent();
                this.Hide();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Passoword");
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }
    }
}