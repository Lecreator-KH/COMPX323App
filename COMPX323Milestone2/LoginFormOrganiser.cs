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
    public partial class LoginFormOrganiser : Form
    {
        public LoginFormOrganiser()
        {
            InitializeComponent();
        }

        public string usernameAdminOrganiser;
        public string passwordAdminOrganiser;
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
            {   //umfamsxr4300
                //usbb8600curl
                // Get username and password from textboxes.
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();



                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=" + usernameAdminOrganiser + ";Password=" + passwordAdminOrganiser + ";";

                OracleConnection conn = new OracleConnection(oradb); 
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                

                cmd.Connection = conn;
                cmd.CommandText = "select USERNAME from person where Username like '" + username + "'";
                
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                dr2.Read();
                String resultUsername = dr2.GetString(0);

                Console.WriteLine(resultUsername);

                cmd.CommandText = "select password from person where password like '" + password + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr3 = cmd.ExecuteReader();
                dr3.Read();
                String resultPassword = dr3.GetString(0);

                Console.WriteLine("result name: " + resultPassword);
                //conn.Dispose();


                if (password.Equals(resultPassword))
                {
                    MessageBox.Show(resultUsername + " " + resultPassword);
                    Organizer d = new Organizer();
                    d.Owner = this;
                    d.organiser = username;
                    d.txtOrganiserName.Text = username;
                    d.conn = conn;
                    d.ShowDialog();

                }


            }
            catch (Exception ex)
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format." + ex);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }


        }
    }
}
