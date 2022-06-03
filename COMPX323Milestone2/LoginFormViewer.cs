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
    public partial class LoginFormViewer : Form
    {
        public LoginFormViewer()
        {
            InitializeComponent();
        }
        public string usernameAdminViewer;
        public string passwordAdminViewer;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username, password;


            //If textboxes are empty, display the error message
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please enter your username and password");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

            try
            {
                // Get username and password from textboxes.
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
                
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

        }
    }
}
