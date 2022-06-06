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
    public partial class Organizer : Form
    {
        public OracleConnection conn;
        public String organiser;

        
        public Organizer()
        {
            InitializeComponent();

        }

        private void buttonUpcomingEvent_Click(object sender, EventArgs e)
        {
            listBoxEvent.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from sportEvent where Eventdate > trunc(sysdate) and Organizer like '" + organiser + "'";

            cmd.CommandType = CommandType.Text;
            OracleDataReader drupcoming = cmd.ExecuteReader();

            while (drupcoming.Read())
            {
                String result0 = drupcoming.GetString(0);
                String result1 = drupcoming.GetString(1);
                String result2 = drupcoming.GetString(2);
                String result3 = drupcoming.GetString(3);
                String result4 = drupcoming.GetString(4);
                String result5 = drupcoming.GetString(5);
                String result6 = drupcoming.GetString(6);
                listBoxEvent.Items.Add(result0.PadRight(10) + result1.PadRight(10) + result2.PadRight(35) + result3.PadRight(10) + result4.PadRight(30)
                    + result5.PadRight(10) + result6.PadRight(10));
            }
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonPastEvent_Click(object sender, EventArgs e)
        {
            
                listBoxEvent.Items.Clear();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from sportEvent where Eventdate < trunc(sysdate) and Organizer like '" + organiser + "'";

                cmd.CommandType = CommandType.Text;
                OracleDataReader drupcoming = cmd.ExecuteReader();

                while (drupcoming.Read())
                {
                    String result0 = drupcoming.GetString(0);
                    String result1 = drupcoming.GetString(1);
                    String result2 = drupcoming.GetString(2);
                    String result3 = drupcoming.GetString(3);
                    String result4 = drupcoming.GetString(4);
                    String result5 = drupcoming.GetString(5);
                    String result6 = drupcoming.GetString(6);
                listBoxEvent.Items.Add(result0.PadRight(10) + result1.PadRight(10) + result2.PadRight(35) + result3.PadRight(10) + result4.PadRight(30)
                    + result5.PadRight(10) + result6.PadRight(10));
                }

            
        }
    }
}
