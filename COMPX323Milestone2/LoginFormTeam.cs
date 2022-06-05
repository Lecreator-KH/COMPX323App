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
    public partial class LoginFormTeam : Form
    {
        public LoginFormTeam()
        {
            InitializeComponent();
        }
        public string usernameAdminTeam;
        public string passwordAdminTeam;

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

                
                
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=" + usernameAdminTeam + ";Password=" + passwordAdminTeam + ";";

                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select TEAMID from player where username like '"+username+"'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String team = dr.GetString(0);
                //MessageBox.Show(team);
                cmd.Connection = conn;
                cmd.CommandText = "select USERNAME from player where Username like '" + username + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                dr2.Read();
                String resultUsername = dr2.GetString(0);

                cmd.CommandText = "select password from person where Username like '"+username+"'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr3 = cmd.ExecuteReader();
                dr3.Read();
                String resultPassword = dr3.GetString(0);

               
                //conn.Dispose();


                if (password.Equals(resultPassword))
                {
                    MessageBox.Show(resultUsername+" "+resultPassword);
                    Player d = new Player();
                    d.Owner = this;
                    d.txtTeamName.Text = team;
                    d.teamid = team;
                    d.conn = conn;
                    d.ShowDialog();

                }


            }
            catch (Exception ex)
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format."+ex);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }


        }
    }
}
