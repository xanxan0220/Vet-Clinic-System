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

namespace PetHavenManagementSystem
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection(@"Data Source =.\sqlexpress; Initial Catalog = login; Integrated Security = True; Encrypt=True;TrustServerCertificate=True");
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';

        }

        private void cbxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = cbxshowpass.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientregisterForm frm = new ClientregisterForm();
            frm.Show();
            this.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            VetClinic form = new VetClinic();
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            cbousertype.Items.Add("Client");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fullName = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=petHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Context Connection=False";

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    String query = "SELECT 'Client' AS UserType FROM usertypes WHERE Fullname = @Fullname AND password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(@"Fullname", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue(@"Password", txtpassword.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("Login Succeesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminAcc acc = new AdminAcc();
                            acc.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password,Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Error connecting Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }
            }
        }

    }
}

