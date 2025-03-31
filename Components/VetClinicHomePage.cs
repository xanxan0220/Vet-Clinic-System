using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace PetHavenManagementSystem
{
    public partial class VetClinic : Form
    {
  

        public VetClinic()
        {
            InitializeComponent();

            
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedform = cbx_Users.SelectedItem.ToString();

            switch (selectedform) {

                case "Admin":
                    {
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        this.Hide();
                    }
                    break;
                case "Veterinarian":
                    {
                        VetForm vet = new VetForm();
                        vet.Show();
                        this.Hide();
                    }
                    break;
                case "Client":
                    {
                        ClientsForm client = new ClientsForm();
                        client.Show();
                        this.Hide();
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VetClinic_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VetClinic_Load_1(object sender, EventArgs e)
        {
            cbx_Users.Items.Add("Admin");
            cbx_Users.Items.Add("Veterinarian");
            cbx_Users.Items.Add("Client");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
