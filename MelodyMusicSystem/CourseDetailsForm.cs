using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    public partial class CourseDetailsForm : Form
    {
        
        private Regex numbersOnlyRegX = new Regex("^[0-9]+$");
        
        public CourseDetailsForm()
        {
            InitializeComponent();
            this.CourseLoad();
        }

        private void CourseLoad()
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT COID FROM Course";
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
                cboCOID.Items.Add(reader[0]);
            }

            reader.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            var validateFields = this.ValidateFields();
            if (!validateFields)
            {
                return;
            }
            
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";

            commandString = "INSERT INTO Course VALUES ('" +
                            cboCOID.Text + "','" + txtCName.Text + "','" + txtDivision.Text + "','"
                            + txtDuration.Text + "','" + txtFee.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("New Course is Added Successfully");
            cboCOID.Items.Add(cboCOID.Text);
            Clear();
            cboCOID.Focus();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            var validateFields = this.ValidateFields();
            if (!validateFields)
            {
                return;
            }
            
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "UPDATE Course SET CName = '" +
                            txtCName.Text + "', Division = '" + txtDivision.Text + "', CDuration = '" +
                            txtDuration.Text + "', CFee = '" + txtFee.Text + "' where COID = '" +
                            cboCOID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this course?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Course details is Updated Succesfully");
            Clear();
            cboCOID.Focus();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "DELETE Course FROM Student where COID = '" + cboCOID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this course?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Course is Deleted Successfully");
            conn.Close();
            cboCOID.Items.Remove(cboCOID.Text);
            cboCOID.Focus();
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

        private void cboCOID_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT * FROM Course WHERE COID='" +
                            cboCOID.Text + "'";
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
                txtDivision.Text = reader[2].ToString();
                txtDuration.Text = reader[3].ToString();
                txtFee.Text = reader[4].ToString();
            }

            reader.Close();
            conn.Close();
        }

        public void Clear()
        {
            cboCOID.Text = "";
            txtCName.Text = "";
            txtDivision.Text = "";
            txtDuration.Text = "";
            txtFee.Text = "";
            
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        
        private bool ValidateFields()
        {
            if (cboCOID.Text == "" || txtCName.Text == "" || txtDivision.Text == "" || txtDuration.Text == "" ||
                txtFee.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Warning!");
                return false;
            }
            
            if (numbersOnlyRegX.IsMatch(txtDuration.Text.Trim()) == false)
            {
                MessageBox.Show("Invalid Duration !!");
                txtDuration.Focus();
                return false;
            }

            if (numbersOnlyRegX.IsMatch(txtFee.Text.Trim()) == false)
            {
                MessageBox.Show("Invalid Fee !!");
                txtFee.Focus();
                return false;
            }

            return true;
        }
    }
}