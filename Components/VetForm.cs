using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetHavenManagementSystem
{
    public partial class VetForm : Form
    {
        public VetForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection (@"Data Source =.\sqlexpress; Initial Catalog = login; Integrated Security = True; Encrypt=True;TrustServerCertificate=True");
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            VetClinic form = new VetClinic();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VetRegisterForm form = new VetRegisterForm();
            form.Show();
            this.Hide();
        }

        private void cbxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword2.PasswordChar = cbxshowpass2.Checked ? '\0' : '*';
        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            txtpassword2.PasswordChar = '*';

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string fullName = txtusername2.Text.Trim();
            string password = txtpassword2.Text.Trim();

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
                    String query = "SELECT 'Veterinarian' AS UserType FROM usertypes WHERE Fullname = @Fullname AND password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(@"Fullname", txtusername2.Text.Trim());
                        cmd.Parameters.AddWithValue(@"Password", txtpassword2.Text.Trim());

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

        private void cbxusertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VetForm_Load(object sender, EventArgs e)
        {
            cbxusertype.Items.Add("Veterinarian");
        }
    }
}
