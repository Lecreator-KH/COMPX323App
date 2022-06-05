using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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

                //ornkhjjn415 username to test
                //kcll830arpf PASSWORD FOR ABOVE
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=" + usernameAdminViewer + ";Password=" + passwordAdminViewer + ";";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select USERNAME from Person where Username like '"+username+"'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String resultUsername = dr.GetString(0);
                cmd.CommandText = "select Password from Person where Username like '" + username + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                dr2.Read();
                String resultpassword = dr2.GetString(0);
               // conn.Dispose();

               
                if (password.Equals(resultpassword))
                {
                    //MessageBox.Show(resultUsername+" "+resultpassword);
                    Default d = new Default();
                    d.Owner = this;
                    d.usernameAdminDefault = usernameAdminViewer;
                    d.passwordAdminDefault = passwordAdminViewer;
                    d.labelUserName.Text = "Welcome "+username;
                    d.conn = conn;
                    d.ShowDialog();

                }


            }
            catch(Exception ex)
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format."+usernameAdminViewer+passwordAdminViewer);
                Console.WriteLine(ex.Message);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

        }
    }
}
