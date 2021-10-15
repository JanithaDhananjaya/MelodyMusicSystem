using System;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    
    /**
     * created by :  D. Thisali Bhagya
     * Registration no - 00066694
     */
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            else
            {
                timer1.Enabled = false;
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }
    }
}
