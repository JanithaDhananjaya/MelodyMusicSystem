using System;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    
    /**
     * created by :  D. Thisali Bhagya
     * Registration no - 00066694
     */
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent fr = new frmStudent();
            this.Hide();
            fr.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseDetailsForm courseDetailsForm = new CourseDetailsForm();
            this.Hide();
            courseDetailsForm.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            this.Hide();
            paymentDetails.Show();
        }
    }
}