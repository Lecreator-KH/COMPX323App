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
    public partial class Default : Form
    {
        public String usernameAdminDefault;
        public String passwordAdminDefault;
        public Default()
        {
            InitializeComponent();
        }

        private void buttonWatchEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String sport = textBoxSport.Text;
            String date = textBoxDate.Text;
            String comp = comboBox1.Text;
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=" + usernameAdminDefault + ";Password=" + passwordAdminDefault + ";";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from SportEvent where Sport like '" + sport + "' and Eventdate " + comp + "to_date('" + date + "','DD-MON-YY')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
            String resultEventDate = dr.GetString(0);
            listBox1.Items.Add(resultEventDate);
             }
           
            conn.Dispose();
        }
    }
}
