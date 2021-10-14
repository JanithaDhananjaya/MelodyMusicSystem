using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyMusicSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            this.StudentForm_Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";

            commandString = "INSERT INTO Student VALUES ('" +
                            cboRegNo.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','"
                            + txtAddress.Text + "','" + dtpDOB.Text + "','" + txtContact.Text + "','"
                            + txtAge.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("New Student is Added Successfully");
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
            commandString = "UPDATE Student SET FName = '" +
                            txtFName.Text + "', LName = '" + txtLName.Text + "', Address = '" +
                            txtAddress.Text + "', DOB = '" + dtpDOB.Text + "', Contact = '" +
                            txtContact.Text + "',Age='" + txtAge.Text + "' where RegNo = '" +
                            cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this student?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Student details is Updated Succesfully");
            Clear();
            cboRegNo.Focus();
            conn.Close();
        }

        private void StudentForm_Load()
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT RegNo FROM Student";
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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "DELETE Student FROM Student where Student.RegNo = '" + cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this student?", "Sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Student is Deleted Successfully");
            conn.Close();
            cboRegNo.Items.Remove(cboRegNo.Text);
            cboRegNo.Focus();
            Clear();
        }

        public void Clear()
        {
            cboRegNo.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            dtpDOB.Value = System.DateTime.Now;
            txtContact.Text = "";
            txtAge.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboRegNo.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            dtpDOB.Value = System.DateTime.Now;
            txtContact.Text = "";
            txtAge.Text = "";
        }

        private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString =
                "Data Source=DESKTOP-OCRRRLB\\SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "SELECT * FROM Student WHERE RegNo='" +
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
                txtFName.Text = reader[1].ToString();
                txtLName.Text = reader[2].ToString();
                txtAddress.Text = reader[3].ToString();
                dtpDOB.Text = reader[4].ToString();
                txtContact.Text = reader[5].ToString();
                txtAge.Text = reader[6].ToString();
            }

            reader.Close();
            conn.Close();
        }
    }
}