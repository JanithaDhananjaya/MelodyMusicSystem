using System;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    /**
     * created by : H.N.K Buddhika Tharanga Chandrasiri
     * Registration no - 00068271
     */
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d1;
            d1 = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if(d1.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
