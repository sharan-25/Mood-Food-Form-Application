using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food_Application
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void buttonToLogin_Click(object sender, EventArgs e)
        {

            //Check If user enters some data using IsValidateInput function (There should not be null or white space)
            if (IsValidateInput())
            {
                //Take input from the user and store it into temp variables
                string UserName = textBoxUsername.Text;
                string Password = textBoxPassword.Text;
                //store Login credentials to temporary variables.
                string storedUsername = "Admin";
                string storedPassword = "admin@123";

                if (UserName == storedUsername && Password == storedPassword)
                {
                    //Login successfull if User enters correct credentials
                    MessageBox.Show("Login successful!");
                    //connect form 1 with form2
                    First_Page first_page = new First_Page();
                    first_page.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
