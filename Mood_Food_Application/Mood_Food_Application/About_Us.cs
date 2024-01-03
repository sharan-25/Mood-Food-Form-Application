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
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            //by clicking on the Home button u will reach the Home page again
            Home_Page home_page = new Home_Page();
            home_page.Show();
            this.Hide();
        }
    }
}
