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
            //this is for making the oracle server connect to your account, 
            //set your usename and password here
        public string usernameAdmin="kh216";
        public string passwordAdmin="";

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

        private void buttonTeam_Click(object sender, EventArgs e)
        {
            LoginFormTeam teamLoginForm = new LoginFormTeam();
            teamLoginForm.Owner = this;
            teamLoginForm.usernameAdminTeam = usernameAdmin;
            teamLoginForm.passwordAdminTeam = passwordAdmin;
            teamLoginForm.ShowDialog();
        }

        private void buttonLoginViewer_Click(object sender, EventArgs e)
        {
            LoginFormViewer viewerLoginForm = new LoginFormViewer();
            viewerLoginForm.Owner = this;
            viewerLoginForm.usernameAdminViewer = usernameAdmin;
            viewerLoginForm.passwordAdminViewer = passwordAdmin;
            viewerLoginForm.ShowDialog();
        }

        private void buttonLoginOrganiser_Click(object sender, EventArgs e)
        {
            LoginFormOrganiser organiserLoginForm = new LoginFormOrganiser();
            organiserLoginForm.Owner = this;
            organiserLoginForm.usernameAdminOrganiser = usernameAdmin;
            organiserLoginForm.passwordAdminOrganiser = passwordAdmin;
            organiserLoginForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
