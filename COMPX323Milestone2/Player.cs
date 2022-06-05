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
    public partial class Player : Form
    {
        public OracleConnection conn;
        public String teamid;
        public Player()
        {
            InitializeComponent();
            MessageBox.Show(teamid);



        }

        private void buttonMemShow_Click(object sender, EventArgs e)
        {

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select UserName from player where teamid like '" + teamid + "'";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader drplayer = cmd2.ExecuteReader();

            while (drplayer.Read())
            {
                String resultU = drplayer.GetString(0);
                listBoxTeamMember.Items.Add(resultU);
            }
        }

        private void buttonUpcomingEvent_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.Items.Add("There are no upocming events for your team!");
          
        }

        private void buttonPatEvent_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from attends a  where Eventdate < trunc(sysdate) and teamid like '" + teamid + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader drupcoming = cmd.ExecuteReader();

            while (drupcoming.Read())
            {
                String resultU = drupcoming.GetString(0);
                String resultE = drupcoming.GetString(1);
                String resultS = drupcoming.GetString(2);
                String resultL = drupcoming.GetString(3);
                listBoxEvents.Items.Add(resultU.PadRight(10) + resultE.PadRight(10) + resultS.PadRight(10) + resultL.PadRight(10));
            }
        }
    }
}
