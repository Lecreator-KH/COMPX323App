using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace COMPX323Milestone2
{
    public partial class Default : Form
    {
        public String usernameAdminDefault;
        public String passwordAdminDefault;
        public string userid;
        public Default()
        {
            InitializeComponent();
        }

        private void buttonWatchEvent_Click(object sender, EventArgs e)
        {
            //Get the lisiting the user has clicked on

            if (listBox1.Items.Count != 0 &&  listBox1.SelectedItem!=null)
            {
                String myString = Regex.Replace(listBox1.SelectedItem.ToString(), @"\s+", " ");
                String[] sarray = myString.Split(' ');
                MessageBox.Show(sarray[1]);
                listBox2.Items.Clear();

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;

                //insert it into the watches list
                cmd2.CommandText = "Insert into watches values (person, eventadte, starttime, location) (\'" + userid + "', to_date('" + sarray[0] + "', 'DD/MMYYYY'), to_date('" + sarray[1] + "', 'HH24:MI'), " + sarray[2] + "')";
                cmd2.CommandType = CommandType.Text;
                OracleDataReader drtest = cmd2.ExecuteReader();
            }

            
            // show all of the watches table
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from watches where person like '" + userid + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String result1 = dr.GetString(0);
                String result2 = dr.GetString(1);
                String result3 = dr.GetString(2);
                String result4 = dr.GetString(3);
                listBox2.Items.Add(result1.PadRight(15)+ result2.PadRight(15) + result3.PadRight(30) + result4.PadLeft(5) );
            }

        }
        public OracleConnection conn;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String date = textBoxDate.Text;
            String comp = comboBox1.Text;
            // string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=" + usernameAdminDefault + ";Password=" + passwordAdminDefault + ";";
            //OracleConnection conn = new OracleConnection(oradb);  // C#
            //conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from SportEvent where Eventdate = to_date('" + date + "','DD-MM-YY')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                String result1 = dr.GetString(0);
                String result2 = dr.GetString(1);
                String result3 = dr.GetString(2);
                String result4 = dr.GetString(3);
                listBox1.Items.Add(result1.PadRight(15) + result2.PadRight(15) + result3.PadRight(15) + result4.PadRight(15));
            }
           
           // conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gets an entry that the user has watched
            String myString = Regex.Replace(listBox2.SelectedItem.ToString(), @"\s+", " ");
            String[] sarray = myString.Split(' ');
            String command = "DELETE  FROM  watches  WHERE person like '" + userid + "' and location like '" + sarray[3] + "'";
            listBox2.Items.Clear();

            //executes it in the oracle db
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = command;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            //requeries the remaining data
            cmd.CommandText = "select * from watches where person like '" + userid + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                String result1 = dr2.GetString(0);
                String result2 = dr2.GetString(1);
                String result3 = dr2.GetString(2);
                String result4 = dr2.GetString(3);
                listBox2.Items.Add(result1.PadRight(15) + result2.PadRight(15) + result3.PadRight(30) + result4.PadLeft(5));
            }
        }
    }
}
