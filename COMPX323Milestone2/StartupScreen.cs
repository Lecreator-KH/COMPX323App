using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPX323Milestone2
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();
        }

        private void buttonLoginTeam_Click(object sender, EventArgs e)
        {
            //Hides the login page form from user
            // this.Hide();
            //Create a Register Page object to change to
            //LoginFormTeam loginFormTeam = new LoginFormTeam();
            //loginFormTeam.Owner = this;
            //loginFormTeam.ShowDialog();
            Register register = new Register();
            register.ShowDialog();
            //close the login page we are currently on
            // this.Close();
        }

<<<<<<< HEAD
=======
        private void buttonTeam_Click(object sender, EventArgs e)
        {
            LoginFormTeam organiserLoginForm = new LoginFormTeam();
            organiserLoginForm.Owner = this;
            organiserLoginForm.ShowDialog();
        }

>>>>>>> Add project files.
        private void buttonLoginViewer_Click(object sender, EventArgs e)
        {
            LoginFormViewer viewerLoginForm = new LoginFormViewer();
            viewerLoginForm.Owner = this;
            viewerLoginForm.ShowDialog();
        }

        private void buttonLoginOrganiser_Click(object sender, EventArgs e)
        {
            LoginFormOrganiser organiserLoginForm = new LoginFormOrganiser();
            organiserLoginForm.Owner = this;
            organiserLoginForm.ShowDialog();
        }
<<<<<<< HEAD
=======

        
>>>>>>> Add project files.
    }
}
