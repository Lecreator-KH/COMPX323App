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
            //need better fix


            String myString = Regex.Replace(listBox1.SelectedItem.ToString(), @"\s+", " ");
            String[] sarray=myString.Split(' ');
            MessageBox.Show(sarray[1]);
            listBox2.Items.Clear();

            //why doesnt this work

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "Insert into watches values(\'" + userid + "\', " + sarray[0] + ", " + sarray[1] + ",'" + sarray[2] + "')";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader drtest = cmd2.ExecuteReader();

            //this works

            OracleCommand cmd = new OracleCommand();
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
    }
}
