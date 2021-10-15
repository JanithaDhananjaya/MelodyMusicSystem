using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    /**
     * created by : H.Sashmi nethusara dulhari silva
     * Registration no - 00066994
     */
    public partial class PaymentDetails : Form
    {
        
        private Regex numbersOnlyRegX = new Regex("^[0-9]+$");
        
        public PaymentDetails()
        {
            InitializeComponent();
            this.PaymentDetailsLoad();
            this.LoadPaymentTypes();
        }

        private void LoadPaymentTypes()
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT * FROM Payment";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cboPayment.Items.Add(reader[2]);
            }

            reader.Close();
            conn.Close();
        }
        
        private void PaymentDetailsLoad()
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT RegNo FROM Payment";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cboRegNo.Items.Add(reader[0]);
            }

            reader.Close();
            conn.Close();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";

            commandString = "INSERT INTO Payment VALUES ('" +
                            cboRegNo.Text + "','" + txtCName.Text + "','" + cboPayment.Text + "','"
                            + txtAmount.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("New Payment is Added Successfully");
            cboRegNo.Items.Add(cboRegNo.Text);
            Clear();
            cboRegNo.Focus();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "UPDATE Payment SET CName = '" +
                            txtCName.Text + "', Payment = '" + cboPayment.Text + "', Amount = '" +
                            txtAmount.Text + "' where RegNo = '" +
                            cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this payment?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Payment details is Updated Succesfully");
            Clear();
            cboRegNo.Focus();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "DELETE Payment FROM Payment where Payment.RegNo = '" + cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this payment?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Payment Details are Deleted Successfully");
            conn.Close();
            cboRegNo.Items.Remove(cboRegNo.Text);
            cboRegNo.Focus();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
        
        public void Clear()
        {
            cboRegNo.Text = "";
            txtCName.Text = "";
            cboPayment.Text = "";
            txtAmount.Text = "";
            
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT * FROM Payment WHERE RegNo='" +
                            cboRegNo.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txtCName.Text = reader[1].ToString();
                cboPayment.Text = reader[2].ToString();
                txtAmount.Text = reader[3].ToString();
            }

            reader.Close();
            conn.Close();
        }
        
        private bool ValidateFields()
        {
            if (cboCOID.Text == "" || txtCName.Text == "" || cboPayment.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Warning!");
                return false;
            }
            
            if (numbersOnlyRegX.IsMatch(txtAmount.Text.Trim()) == false)
            {
                MessageBox.Show("Invalid Amount !!");
                txtAmount.Focus();
                return false;
            }

            return true;
        }
    }
}
