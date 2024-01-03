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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //by clicking on the login button u will reach the login page
            Login_Page login_page = new Login_Page();
            login_page.Show();
            this.Hide();

        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            //by clicking on the about us button u will reach the about us page
            About_Us about_us = new About_Us();
            about_us.Show();
            this.Hide();
        }
    }
}
