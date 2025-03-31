using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetHavenManagementSystem.Components
{
    public partial class AdminRegisterForm : Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string fullName = txtusername.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();
            string phone = txtphone.Text.Trim();
            string address = txtadress.Text.Trim();
            string userType = cbxusertype.SelectedItem.ToString();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=petHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Context Connection=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usertypes (FullName, Email, Password, Phone, Address, UserType) " +
                                   "VALUES (@FullName, @Email, @Password, @Phone, @Address, @UserType)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@UserType", userType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbxusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {
            cbxusertype.Items.Add("Veterinarian");
            cbxusertype.Items.Add("Pet Owner");
            cbxusertype.Items.Add("Admin");
        }

        private void linklbalreadyhaveanaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Close();
        }
    }
}
