using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetHavenManagementSystem.Components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PetHavenManagementSystem
{

    public partial class AdminForm : Form
    {


 
        public AdminForm()
        {
            InitializeComponent();

        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            VetClinic form = new VetClinic();
            form.Show();
            this.Hide();

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
          
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
          


        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
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
                    String query = "SELECT 'Admin' AS UserType FROM usertypes WHERE Fullname = @Fullname AND password = @Password";
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

        private void cbxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = cbxshowpass.Checked ? '\0' : '*';
        }

        private void btnregisteradmin_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegisterForm = new AdminRegisterForm();
            adminRegisterForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cbxusertype.Items.Add("Admin");
        }
    }
}
    

